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
    public partial class PhoneBook : UserControl
    {
        ContactsDAL db = new ContactsDAL();
        ResendDAL resend_db = new ResendDAL();
        int id = 0;
        DataGridViewButtonColumn btn_Edit = new DataGridViewButtonColumn();
        DataGridViewButtonColumn btn_delete = new DataGridViewButtonColumn();
        public PhoneBook()
        {
            InitializeComponent();
            LoadPhonebook();

        }
      
        public void LoadPhonebook()
        {
            gridContact.Rows.Clear();
            gridContact.Columns.Clear();
            gridContact.Columns.Add("cnt_id", "cnt_id");//0
            gridContact.Columns["cnt_id"].Visible = false;
            gridContact.Columns.Add("cnt_FirstName", "First Name");//1
            gridContact.Columns["cnt_FirstName"].ReadOnly = true;
            gridContact.Columns["cnt_FirstName"].Width = 150;
            gridContact.Columns.Add("cnt_LastName", "Last Name");//2
            gridContact.Columns["cnt_LastName"].ReadOnly = true;
            gridContact.Columns["cnt_LastName"].Width = 150;
            gridContact.Columns.Add("cnt_Number", "Number");//3
            gridContact.Columns["cnt_Number"].ReadOnly = true;
            gridContact.Columns["cnt_Number"].Width = 250;

            gridContact.Columns.Add(btn_Edit);             //4
            btn_Edit.HeaderText = "Edit";
            btn_Edit.Text = "Edit";
            btn_Edit.Name = "Edit";
            btn_Edit.UseColumnTextForButtonValue = true;

            gridContact.Columns.Add(btn_delete);        //5
            btn_delete.HeaderText = "Delete";
            btn_delete.Text = "Delete";
            btn_delete.Name = "Delete";
            btn_delete.UseColumnTextForButtonValue = true;
            foreach (var item in db.LoadAll().Where(m => m.status))
            {
                gridContact.Rows.Add(item.cnt_id, item.cnt_FirstName, item.cnt_LastName,item.cnt_Number);
            }


        }

        //Validation Method
        public bool Validate_txt_phone(string str)
        {
            if (str == string.Empty)
            {
                lblError_PhoneNo.Text = "*Required";
                return false;
            }
            else
            {
                string pattern = @"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
                System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(str, pattern);
                if (result.Success)
                {
                    lblError_PhoneNo.Text = "";
                    return true;
                }
                else
                {
                    lblError_PhoneNo.Text = "Invalid Phone No";
                    return false;
                }
            }
        }
        private bool ValidatephoneNo()
        {
            bool var = false;
            if (Validate_txt_phone(txt_Number.Text))
            {
                var = true;
            }
            else
            {
                string[] str = txt_Number.Text.Split(',');
                for (int i = 0; i < str.Length; i++)
                {
                    if (Validate_txt_phone(str[i]))
                    {
                        var = true;
                    }
                    else
                    {
                        var = false;
                        //       txt_Phone.Focus();
                        break;
                    }
                }
            }
            return var;
        }
        public void Save()
        {
            if ( Validate_txt_firstname() && Validate_txt_LastName()&&ValidatephoneNo())
            {
                ContactsBAL contact = new ContactsBAL();
                contact.cnt_id = id;
                contact.cnt_FirstName = txt_firstname.Text;
                contact.cnt_LastName = txt_LastName.Text;
                contact.cnt_Number = txt_Number.Text;
                contact.status = true;
                if (contact.cnt_id == 0)
                {
                    db.Add(contact);
                }
                else
                {
                    db.Update(contact);
                }
                LoadPhonebook();
                Clear();
            }
        }
        public void Clear()
        {
            id = 0;
            txt_firstname.Text = "";
            txt_LastName.Text = "";
            txt_Number.Text = "";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void gridContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                id =Convert.ToInt32(gridContact.Rows[e.RowIndex].Cells["cnt_id"].Value.ToString());
                txt_firstname.Text= gridContact.Rows[e.RowIndex].Cells["cnt_FirstName"].Value.ToString();
                txt_LastName.Text = gridContact.Rows[e.RowIndex].Cells["cnt_LastName"].Value.ToString();
                txt_Number.Text = gridContact.Rows[e.RowIndex].Cells["cnt_Number"].Value.ToString();                
            }
            else if(e.ColumnIndex == 5)
            {
                db.Delete(Convert.ToInt32(gridContact.Rows[e.RowIndex].Cells["cnt_id"].Value.ToString()));
                LoadPhonebook();
                Clear();
            }
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadPhonebook();
        }


        private void panel13_Click(object sender, EventArgs e)
        {
        }

        private void label_home_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Click(object sender, EventArgs e)
        {
        }

      

      

        private void panel2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void panel3_Click(object sender, EventArgs e)
        {
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void lbl_Send_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void txt_Number_KeyUp(object sender, KeyEventArgs e)
        {
            ValidatephoneNo();
        }

        private void txt_Number_Leave(object sender, EventArgs e)
        {
            ValidatephoneNo();
        }

        //Validation Method
        public bool Validate_txt_LastName()
        {
            if (txt_LastName.Text == string.Empty)
            {
                lblError_LastName.Text = "*Required";
                return false;
            }
            else
            {
                string pattern = "^[A-Za-z ]{1,25}$";
                System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(txt_LastName.Text, pattern);
                if (result.Success)
                {
                    lblError_LastName.Text = "";
                    return true;
                }
                else
                {
                    lblError_LastName.Text = "Invalid LastName";
                    return false;
                }
            }
        }

        //KeyUP
        private void txt_LastName_KeyUp(object sender, KeyEventArgs e)
        {
            Validate_txt_LastName();
        }

        //ON Leave
        private void txt_LastName_Leave(object sender, EventArgs e)
        {
            Validate_txt_LastName();
        }


        //Validation Method
        public bool Validate_txt_firstname()
        {
            if (txt_firstname.Text == string.Empty)
            {
                lblError_FirstName.Text = "*Required";
                return false;
            }
            else
            {
                string pattern = "^[A-Za-z ]{1,25}$";
                System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(txt_firstname.Text, pattern);
                if (result.Success)
                {
                    lblError_FirstName.Text = "";
                    return true;
                }
                else
                {
                    lblError_FirstName.Text = "Invalid lblError_FirstName";
                    return false;
                }
            }
        }

        //KeyUP
        private void txt_firstname_KeyUp(object sender, KeyEventArgs e)
        {
            Validate_txt_firstname();
        }

        //ON Leave
        private void txt_firstname_Leave(object sender, EventArgs e)
        {
            Validate_txt_firstname();
        }

        private void panel1_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
