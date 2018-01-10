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
    public partial class NewMessages : UserControl
    {
        SMSDAL sms_db = new SMSDAL();
        SMS_tempDAL temp_db = new SMS_tempDAL();
        ResendDAL resend_db = new ResendDAL();
        public NewMessages()
        {
            InitializeComponent();

            this.txt_phone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_phone_KeyUp);
            this.txt_phone.Leave += new System.EventHandler(this.txt_phone_Leave);

            this.richTxt_message.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTxt_message_KeyUp);
            this.richTxt_message.Leave += new System.EventHandler(this.richTxt_message_Leave);
        }

        //Validation Method
        public bool Validate_txt_phone(string str)
        {
            if (str== string.Empty)
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
            if (Validate_txt_phone(txt_phone.Text))
            {
                var = true;
            }
            else
            {
                string[] str = txt_phone.Text.Split(',');
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
        //KeyUP
        private void txt_phone_KeyUp(object sender, KeyEventArgs e)
        {
            ValidatephoneNo();
        }

        //ON Leave
        private void txt_phone_Leave(object sender, EventArgs e)
        {
            ValidatephoneNo();
        }


        //Validation Method
        public bool Validate_richTxt_message()
        {
            if (richTxt_message.Text == string.Empty)
            {
                lblError_message.Text = "*Required";
                return false;
            }
            lblError_message.Text = "";
            return true;
        }

        //KeyUP
        private void richTxt_message_KeyUp(object sender, KeyEventArgs e)
        {
            Validate_richTxt_message();
        }

        //ON Leave
        private void richTxt_message_Leave(object sender, EventArgs e)
        {
            Validate_richTxt_message();
        }
        public void SendSMS()
        {
            if(ValidatephoneNo()&&Validate_richTxt_message())
            {
                string[] str = txt_phone.Text.Split(',');
                for (int i = 0; i < str.Length; i++)
                {
                    SMS_tempBAL temp = new SMS_tempBAL();
                    temp.phoneNo = str[i];
                    temp.message = richTxt_message.Text;
                    temp.TimeStamp = DateTime.Now;
                    temp_db.Add(temp);
                }
                
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            SendSMS();
        }

        private void lbl_Send_Click(object sender, EventArgs e)
        {
            SendSMS();
        }
    }
}
