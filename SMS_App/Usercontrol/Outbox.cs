using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS_App.DAL;
using SMS_App.BAL;

namespace SMS_App.Usercontrol
{
    public partial class Outbox : UserControl
    {
        SMSDAL sms_db = new SMSDAL();
        ResendDAL resend_db = new ResendDAL();

        DataGridViewButtonColumn btn_newrow = new DataGridViewButtonColumn();

        DataGridViewButtonColumn btn_MoveToTrash = new DataGridViewButtonColumn();
        public Outbox()
        {
            InitializeComponent();
            SeenOutbox();
            LoadOutbox();

        }
        public void SeenOutbox()
        {
            foreach (var item in sms_db.LoadAll().Where(m=>!m.IsDelieverd&&!m.IsSeen))
            {
                item.IsSeen = true;
                sms_db.Update(item);
            }
        }
        public void LoadOutbox()
        {

            gridOutbox.Rows.Clear();
            gridOutbox.Columns.Clear();
            gridOutbox.Columns.Add("sms_id", "sms_id");//0
            gridOutbox.Columns["sms_id"].Visible = false;
            gridOutbox.Columns.Add("phoneNo", "Phone No");//1
            gridOutbox.Columns.Add("Message", "Message");//2
            gridOutbox.Columns["Message"].Width = 250;
            gridOutbox.Columns.Add("Time", "Date/Time");//3
            gridOutbox.Columns["Time"].Width = 150;
            gridOutbox.Columns.Add("Resend Times", "Resend Times");//4
            gridOutbox.Columns.Add(btn_newrow);             //5
            btn_newrow.HeaderText = "Resend";
            btn_newrow.Text = "Resend";
            btn_newrow.Name = "Resend";

            btn_newrow.UseColumnTextForButtonValue = true;
            gridOutbox.Columns.Add(btn_MoveToTrash);        //6
            btn_MoveToTrash.HeaderText = "Move to Trash";
            btn_MoveToTrash.Text = "Move to Trash";
            btn_MoveToTrash.Name = "Move to Trash";
            btn_MoveToTrash.UseColumnTextForButtonValue = true;
            foreach (var item in sms_db.LoadAll().Where(m => !m.IsDelieverd && m.status))
            {

                int resendCount = resend_db.LoadAll().Where(m => m.sms_id == item.sms_id).Count();
                gridOutbox.Rows.Add(item.sms_id, item.phoneNo, item.Message,item.TimeStamp, resendCount);
            }

            gridOutbox.Columns["Resend Times"].ReadOnly = true;

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<string> arg = e.Argument as List<string>;//0 message, 1 phoneNo, 2 sms_id,3 status
            bool IsSend = false;
            SMS sms = new SMS();
            foreach (var port in sms.GetConnectedPort())
            {
                if (sms.SendSMS(port, arg[0],arg[1]))
                {
                    //message send
                    //MessageBox.Show("Message Sended");
                    var resend_list = resend_db.LoadAll().Where(m => m.sms_id == Convert.ToInt32(arg[2])).ToList();
                    foreach (var item in resend_list)
                    {
                        resend_db.Delete(item);
                    }
                    SMSBAL sms_single = sms_db.LoadAll().Where(m => m.sms_id == Convert.ToInt32(arg[2])).SingleOrDefault();
                    sms_single.Message = arg[0];
                    sms_single.phoneNo = arg[1];
                    sms_single.IsDelieverd = true;
                    sms_single.IsSeen = true;
                    sms_db.Update(sms_single);
                    IsSend = true;
                    break;
                }

            }
            if (!IsSend)
            {
                ResendBAL resend = new ResendBAL();
                resend.sms_id = Convert.ToInt32(arg[2]);
                resend_db.Add(resend);
                //Message not Send
                //  MessageBox.Show("Message not Sended");
            }
        }

        private void gridOutbox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!backgroundWorker2.IsBusy)
            {
                if (e.ColumnIndex == 5 && !backgroundWorker1.IsBusy && 3 > Convert.ToInt32(gridOutbox.Rows[e.RowIndex].Cells["Resend Times"].Value))
                {
                    List<string> arg = new List<string>();
                    arg.Add(gridOutbox.Rows[e.RowIndex].Cells["Message"].Value.ToString());

                    arg.Add(gridOutbox.Rows[e.RowIndex].Cells["phoneNo"].Value.ToString());

                    arg.Add(gridOutbox.Rows[e.RowIndex].Cells["sms_id"].Value.ToString());

                    backgroundWorker1.RunWorkerAsync(arg);

                }
                else if (e.ColumnIndex == 6)
                {
                    var sms = sms_db.LoadAll().Where(m => m.sms_id == Convert.ToInt32(gridOutbox.Rows[e.RowIndex].Cells["sms_id"].Value)).SingleOrDefault();
                    sms.status = false;
                    sms.phoneNo = gridOutbox.Rows[e.RowIndex].Cells["phoneNo"].Value.ToString();
                    sms.Message = gridOutbox.Rows[e.RowIndex].Cells["Message"].Value.ToString();
                    sms_db.Update(sms);
                    LoadOutbox();
                }
            }else
            {
                MessageBox.Show("Resending of SMS in progress be patient");
            }
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadOutbox();
        }
        public void ResendAll()
        {
            List<SMSBAL> sms_list = new List<SMSBAL>();
            for (int i = 0; i < gridOutbox.RowCount; i++)
            {
                if (3 > Convert.ToInt32(gridOutbox.Rows[i].Cells["Resend Times"].Value))
                {
                    SMSBAL sms = new SMSBAL();
                    sms.Message = gridOutbox.Rows[i].Cells["Message"].Value.ToString();
                    sms.phoneNo = gridOutbox.Rows[i].Cells["phoneNo"].Value.ToString();
                    sms.sms_id = Convert.ToInt32(gridOutbox.Rows[i].Cells["sms_id"].Value);
                    sms_list.Add(sms);
                }
            }
            if (!backgroundWorker2.IsBusy)
            {
                timer1.Start();
                Cursor.Current = Cursors.WaitCursor;
                backgroundWorker2.RunWorkerAsync(sms_list);
            }
                
            
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            ResendAll();
        }

        private void label_home_Click(object sender, EventArgs e)
        {
            ResendAll();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            ResendAll();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            List<SMSBAL> sms_list = e.Argument as List<SMSBAL>;//0 message, 1 phoneNo, 2 sms_id,3 status
            foreach (var item in sms_list)
            {
                bool IsSend = false;
                SMS sms = new SMS();
                foreach (var port in sms.GetConnectedPort())
                {
                    if (sms.SendSMS(port, item.Message, item.phoneNo))
                    {
                        //message send
                        //MessageBox.Show("Message Sended");
                        var resend_list = resend_db.LoadAll().Where(m => m.sms_id == item.sms_id).ToList();
                        foreach (var item1 in resend_list)
                        {
                            resend_db.Delete(item1);
                        }
                        SMSBAL sms_single = sms_db.LoadAll().Where(m => m.sms_id == item.sms_id).SingleOrDefault();
                        sms_single.Message = item.Message;
                        sms_single.phoneNo = item.phoneNo;
                        sms_single.IsDelieverd = true;
                        sms_single.IsSeen = true;
                        sms_db.Update(sms_single);
                        IsSend = true;
                        break;
                    }

                }
                if (!IsSend)
                {
                    ResendBAL resend = new ResendBAL();
                    resend.sms_id = Convert.ToInt32(item.sms_id);
                    resend_db.Add(resend);
                    //Message not Send
                    //  MessageBox.Show("Message not Sended");
                }
                
            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer1.Stop();
            LoadOutbox();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadOutbox();
        }
        public void MoveAllTrash()
        {
            for (int i = 0; i < gridOutbox.RowCount; i++)
            {
                SMSBAL sms = sms_db.LoadAll().Where(m => m.sms_id == Convert.ToInt32(gridOutbox.Rows[i].Cells["sms_id"].Value)).SingleOrDefault();
                sms.status = false;
                sms.phoneNo = gridOutbox.Rows[i].Cells["phoneNo"].Value.ToString();
                sms.Message = gridOutbox.Rows[i].Cells["Message"].Value.ToString();
                sms_db.Update(sms);
            }

            LoadOutbox();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            MoveAllTrash();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            MoveAllTrash();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MoveAllTrash();
        }
    }
}
