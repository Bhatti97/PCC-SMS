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
    public partial class Trash : UserControl
    {
        SMSDAL sms_db = new SMSDAL();
        ResendDAL resend_db = new ResendDAL();

        DataGridViewButtonColumn btn_newrow = new DataGridViewButtonColumn();

        DataGridViewButtonColumn btn_MoveToTrash = new DataGridViewButtonColumn();

        DataGridViewButtonColumn btn_MoveToTrash1 = new DataGridViewButtonColumn();
        public Trash()
        {
            InitializeComponent();
            LoadSendItems();

        }
       
        public void LoadSendItems()
        {

            gridTrash.Rows.Clear();
            gridTrash.Columns.Clear();
            gridTrash.Columns.Add("sms_id", "sms_id");//0
            gridTrash.Columns["sms_id"].Visible = false;
            gridTrash.Columns.Add("phoneNo", "Phone No");//1
            gridTrash.Columns.Add("Message", "Message");//2
            gridTrash.Columns["Message"].Width = 390;
            gridTrash.Columns.Add("Time", "Date/Time");//3
            gridTrash.Columns["Time"].Width = 150;
           
            gridTrash.Columns.Add(btn_MoveToTrash);        //4
            btn_MoveToTrash.HeaderText = "Restore";
            btn_MoveToTrash.Text = "Restore";
            btn_MoveToTrash.Name = "Restore";
            btn_MoveToTrash.UseColumnTextForButtonValue = true;
            gridTrash.Columns.Add(btn_MoveToTrash1);        //5
            btn_MoveToTrash1.HeaderText = "Remove From Trash";
            btn_MoveToTrash1.Text = "Remove From Trash";
            btn_MoveToTrash1.Name = "Remove From Trash";
            btn_MoveToTrash1.UseColumnTextForButtonValue = true;

            gridTrash.Columns[5].Width = 175;
            foreach (var item in sms_db.LoadAll().Where(m => ! m.status))
            {
                gridTrash.Rows.Add(item.sms_id, item.phoneNo, item.Message,item.TimeStamp);
            }
            

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

            if (e.ColumnIndex == 4)
            {
                var sms = sms_db.LoadAll().Where(m => m.sms_id == Convert.ToInt32(gridTrash.Rows[e.RowIndex].Cells["sms_id"].Value)).SingleOrDefault();
                sms.status = true;
                sms.phoneNo = gridTrash.Rows[e.RowIndex].Cells["phoneNo"].Value.ToString();
                sms.Message = gridTrash.Rows[e.RowIndex].Cells["Message"].Value.ToString();
                sms_db.Update(sms);
                LoadSendItems();
            }
                
            if (e.ColumnIndex == 5)
            {
                var sms = sms_db.LoadAll().Where(m => m.sms_id == Convert.ToInt32(gridTrash.Rows[e.RowIndex].Cells["sms_id"].Value)).SingleOrDefault();                
                sms_db.Delete(sms);
                LoadSendItems();
            }
            


        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadSendItems();
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
            LoadSendItems();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadSendItems();
        }
        public void RestoreAllFromTrash()
        {
            for (int i = 0; i < gridTrash.RowCount; i++)
            {
                SMSBAL sms = sms_db.LoadAll().Where(m => m.sms_id == Convert.ToInt32(gridTrash.Rows[i].Cells["sms_id"].Value)).SingleOrDefault();
                sms.status = true;
                sms.phoneNo = gridTrash.Rows[i].Cells["phoneNo"].Value.ToString();
                sms.Message = gridTrash.Rows[i].Cells["Message"].Value.ToString();
                sms_db.Update(sms);
            }

            LoadSendItems();
        }
        public void RemoveAllfromTrash()
        {
            for (int i = 0; i < gridTrash.RowCount; i++)
            {
                SMSBAL sms = sms_db.LoadAll().Where(m => m.sms_id == Convert.ToInt32(gridTrash.Rows[i].Cells["sms_id"].Value)).SingleOrDefault();
                
                sms_db.Delete(sms);
            }

            LoadSendItems();
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            RestoreAllFromTrash();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            RestoreAllFromTrash();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            RestoreAllFromTrash();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            RemoveAllfromTrash();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            RemoveAllfromTrash();
        }
    }
}
