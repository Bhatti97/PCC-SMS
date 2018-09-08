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
    public partial class PhoneBookSMS : Form
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

        public PhoneBookSMS()
        {
            InitializeComponent();
            LoadConacts();
        }
        public void LoadConacts()
        {
            PhoneBookLocalStorage.phonebookSMSWindowOpen = true;
            gridContacts.Rows.Clear();
            gridContacts.Columns.Clear();

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            gridContacts.Columns.Add(chk);                          //0
            chk.HeaderText = "Select";
            chk.Name = "isSelected";

            ContactsDAL db = new ContactsDAL();
            gridContacts.Columns.Add("cnt_id", "cnt_id");            //1
            gridContacts.Columns["cnt_id"].Visible = false;
            gridContacts.Columns.Add("cnt_FirstName_LastName", "Name");     //2
            gridContacts.Columns["cnt_FirstName_LastName"].ReadOnly = true;
            gridContacts.Columns.Add("cnt_Number", "Number");               //3
            gridContacts.Columns["cnt_Number"].ReadOnly = true;
            gridContacts.Columns["cnt_Number"].Width = 140;

          

            foreach (var item in db.LoadAll().Where(m => m.status))
            {
               
                
                gridContacts.Rows.Add(
                    PhoneBookLocalStorage.IsInList(item.cnt_Number),
                    item.cnt_id,
                    item.cnt_FirstName+" "+item.cnt_LastName,
                    item.cnt_Number);
            }
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
            //   Application.Exit();
            this.Hide();
            PhoneBookLocalStorage.phonebookSMSWindowOpen = false;
            //  Environment.Exit(0);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            
        }
       
        private void panel11_Click(object sender, EventArgs e)
        {
           
        }

        private void label_newMessage_Click(object sender, EventArgs e)
        {
           
        }
      
        private void panel10_Click(object sender, EventArgs e)
        {
            
        }

        private void label_Outbox_Click(object sender, EventArgs e)
        {
            
        }
      
        private void panel_close_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void panel9_Click(object sender, EventArgs e)
        {
           
        }

        private void label_sentItems_Click(object sender, EventArgs e)
        {
           
        }
      

        private void panel8_Click(object sender, EventArgs e)
        {
            
        }

        private void label_trash_Click(object sender, EventArgs e)
        {
            
        }
      
      
        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void Lbl_Phonebook_Click(object sender, EventArgs e)
        {

            
        }
        public void On_OK()
        {

            for (int i = 0; i < gridContacts.RowCount; i++)
            {
                if (Convert.ToBoolean(gridContacts.Rows[i].Cells[0].Value))
                {
                    if(!PhoneBookLocalStorage.IsInList(gridContacts.Rows[i].Cells[3].Value.ToString()))
                    {
                        PhoneBookLocalStorage.list.Add(gridContacts.Rows[i].Cells[3].Value.ToString());
                    }
                }
                else
                {
                    if (PhoneBookLocalStorage.IsInList(gridContacts.Rows[i].Cells[3].Value.ToString()))
                    {
                        PhoneBookLocalStorage.list.Remove(gridContacts.Rows[i].Cells[3].Value.ToString());
                    }
                }
            }
            PhoneBookLocalStorage.localStorageReaded = false;
            PhoneBookLocalStorage.phonebookSMSWindowOpen = false;
            this.Hide();
        }

        public void On_cancel()
        {
            PhoneBookLocalStorage.phonebookSMSWindowOpen = false;
            this.Hide();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            On_OK();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            On_OK();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            On_cancel();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            On_cancel();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
