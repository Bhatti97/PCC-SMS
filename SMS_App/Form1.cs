using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SMS_App.Usercontrol;
using SMS_App.DAL;
using SMS_App.BAL;

namespace SMS_App
{
    public partial class Form1 : Form
    {
        int Outbox_notificationcount = 0;
        int outboxcount = 0;
        int sentItemscount = 0;
        int trashcount = 0;
        SMSDAL sms_db = new SMSDAL();
        SMS_tempDAL temp_db = new SMS_tempDAL();
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            ViewHome();

        }
        public void ChecknotificationOutbox()
        {

            Outbox_notificationcount = 0;
            List<SMSBAL> smsList = sms_db.LoadAll();
            outboxcount = smsList.Where(m => !m.IsDelieverd&&m.status).Count();
            sentItemscount = smsList.Where(m => m.IsDelieverd && m.status).Count();
            trashcount= smsList.Where(m => ! m.status).Count();
            foreach (var item in smsList)
            {
                if(!item.IsDelieverd&&!item.IsSeen&&item.status)
                {
                    Outbox_notificationcount++;
                }
            }
           
        }
       
        public void InactiveAllnav()
        {
            label_home.ForeColor = System.Drawing.Color.WhiteSmoke;
            label_newMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            label_Outbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            label_sentItems.ForeColor = System.Drawing.Color.WhiteSmoke;
            label_trash.ForeColor = System.Drawing.Color.WhiteSmoke;
            lbl_Phonebook.ForeColor = System.Drawing.Color.WhiteSmoke;
        }
        private void panel_header_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void panel_head_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel_head_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel_head_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel_head_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel_close_Click(object sender, EventArgs e)
        {
          //  Application.ExitThread();
                Application.Exit();
          //  Environment.Exit(0);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            ViewHome();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            ViewHome();
        }
        public void ViewHome()
        {
            panel_body.Controls.Clear();
            Home ucClass = new Home();
            panel_body.Controls.Add(ucClass);
            InactiveAllnav();
            label_home.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }
        private void panel11_Click(object sender, EventArgs e)
        {
            ViewNewMessage();
        }

        private void label_newMessage_Click(object sender, EventArgs e)
        {
            ViewNewMessage();
        }
        public void ViewNewMessage()
        {
            panel_body.Controls.Clear();
            NewMessages ucClass = new NewMessages(this);
            panel_body.Controls.Add(ucClass);
            InactiveAllnav();
            label_newMessage.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }
        private void panel10_Click(object sender, EventArgs e)
        {
            ViewOutbox();
        }

        private void label_Outbox_Click(object sender, EventArgs e)
        {
            ViewOutbox();
        }
        public void ViewOutbox()
        {
            panel_body.Controls.Clear();
            Outbox ucClass = new Outbox();
            panel_body.Controls.Add(ucClass);
            InactiveAllnav();
            label_Outbox.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }
        private void panel_close_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_outbooknotification_Tick(object sender, EventArgs e)
        {if(!backgroundWorker1.IsBusy)
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ChecknotificationOutbox();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label_Outbox.Text="Outbox ("+outboxcount+")";
            label_sentItems.Text = "Sent Items (" + sentItemscount + ")";
            label_trash.Text = "Trash (" + trashcount + ")";
            if (Outbox_notificationcount > 0)
            {
                //panel_OutboxLessThan10Notification.Show();
                //lbl_outboxNotificationount.Show();
               // lbl_outboxNotificationount.Text = Outbox_notificationcount.ToString()+ " unread";
            }
            else
            {

               // lbl_outboxNotificationount.Hide();
                //  panel_OutboxLessThan10Notification.Hide();
            }
        }

        private void timer_SendSMS_Tick(object sender, EventArgs e)
        {
            if(!backgroundWorker2.IsBusy)
            {
                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

            foreach (var item in temp_db.LoadAll())
            {
                int hourcount = sms_db.LoadAll().Where(m => m.TimeStamp.Hour == DateTime.Now.Hour && m.TimeStamp.Date == DateTime.Now.Date&&m.IsDelieverd).Count();
                int daycount = sms_db.LoadAll().Where(m => m.TimeStamp.Date == DateTime.Now.Date && m.IsDelieverd).Count();

                if (daycount <= 3600 && hourcount <= 150)
                {
                    SMSBAL smsObj = new SMSBAL();
                    smsObj.phoneNo = item.phoneNo;
                    smsObj.Message = item.message;
                    smsObj.TimeStamp = item.TimeStamp;
                    smsObj.status = true;

                    bool IsSend = false;
                    SMS sms = new SMS();
                    foreach (var port in sms.GetConnectedPort())
                    {
                        if (sms.SendSMS(port, smsObj.Message, smsObj.phoneNo))
                        {
                            //message send
                            //MessageBox.Show("Message Sended");
                            smsObj.IsSeen = true;
                            smsObj.IsDelieverd = true;
                            IsSend = true;
                            break;
                        }

                    }
                    if (!IsSend)
                    {
                        smsObj.IsSeen = false;
                        smsObj.IsDelieverd = false;
                        //Message not Send
                        //  MessageBox.Show("Message not Sended");
                    }
                    sms_db.Add(smsObj);
                    temp_db.Delete(item);
                }
            }
            
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            ViewSentItems();
        }

        private void label_sentItems_Click(object sender, EventArgs e)
        {
            ViewSentItems();
        }
        public void ViewSentItems()
        {
            panel_body.Controls.Clear();
            SentItems ucClass = new SentItems();
            panel_body.Controls.Add(ucClass);
            InactiveAllnav();
            label_sentItems.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            ViewTrash();
        }

        private void label_trash_Click(object sender, EventArgs e)
        {
            ViewTrash();
        }
        public void ViewTrash()
        {
            panel_body.Controls.Clear();
            Trash ucClass = new Trash();
            panel_body.Controls.Add(ucClass);
            InactiveAllnav();
            label_trash.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }
        public void ViewPhoneBook()
        {
            panel_body.Controls.Clear();
            PhoneBook ucClass = new PhoneBook();
            panel_body.Controls.Add(ucClass);
            InactiveAllnav();
            lbl_Phonebook.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            ViewPhoneBook();
        }

        private void Lbl_Phonebook_Click(object sender, EventArgs e)
        {

            ViewPhoneBook();
        }
    }
}
