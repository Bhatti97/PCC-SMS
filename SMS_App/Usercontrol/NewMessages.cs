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
        private Form1 form1;
        public NewMessages(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.txt_phone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_phone_KeyUp);
            this.txt_phone.Leave += new System.EventHandler(this.txt_phone_Leave);

            this.richTxt_message.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTxt_message_KeyUp);
            this.richTxt_message.Leave += new System.EventHandler(this.richTxt_message_Leave);

            txt_phone.Text = "";
            for (int i = 0; i < PhoneBookLocalStorage.list.Count; i++)
            {
                txt_phone.Text += (i != PhoneBookLocalStorage.list.Count - 1) ? PhoneBookLocalStorage.list[i] + "," : PhoneBookLocalStorage.list[i];
            }
            PhoneBookLocalStorage.localStorageReaded = false;
            ValidatephoneNo();
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
                    PhoneBookLocalStorage.list.Add(str);
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
            PhoneBookLocalStorage.list.Clear();
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
            lblLimit.Text=richTxt_message.Text.Length+"/150";
            if (richTxt_message.Text == string.Empty)
            {
                lblError_message.Text = "*Required";
                return false;
            }
            else if(richTxt_message.Text.Length>150)
            {
                lblError_message.Text = "SMS characters should be in 150";
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
                txt_phone.Text = "";
                richTxt_message.Text = "";
                PhoneBookLocalStorage.list.Clear();
                
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
        private void ImportContact_Click()
        {
            var opFile = new OpenFileDialog();
            opFile.Title = "Select a Contact File";
            opFile.Filter = "Contact file (*.txt)|*.txt";
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var iName = opFile.SafeFileName; //Image Name(I Don't Use this name instead 'name')
                    var filepath = opFile.FileName; //File path //Make "<WorkOrderNumber>.Jpg"

                    Contacts_in_File contacts_In_File = new Contacts_in_File();
                    if (txt_phone.Text.Length > 0)
                    {
                        txt_phone.Text += "," + contacts_In_File.GetContacts(filepath);
                    }
                    else
                    {
                        txt_phone.Text = contacts_In_File.GetContacts(filepath);
                    }
                    ValidatephoneNo();

                }
                catch (Exception exp)
                {
                    //lblError_PIC.Text = "Unable to open file " + exp.Message;
                }
            }
            else
            {
                opFile.Dispose();
            }
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            ImportContact_Click();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ImportContact_Click();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            //PhoneBookSMS phoneBookSMS = new PhoneBookSMS();
            //phoneBookSMS.Show();
            phonebookSMS_timmer.Enabled = true;
            PhoneBookLocalStorage.phonebookSMSWindowOpen = true;
            var phoneBookSMS = new PhoneBookSMS();
            phoneBookSMS.Closed += (s, args) => this.form1.Close();
            phoneBookSMS.Show();
        }

        private void phonebookSMS_timmer_Tick(object sender, EventArgs e)
        {
            if (!PhoneBookLocalStorage.phonebookSMSWindowOpen)
            {
                phonebookSMS_timmer.Stop();
            }
            if(!PhoneBookLocalStorage.phonebookSMSWindowOpen&& !PhoneBookLocalStorage.localStorageReaded)
            {
                txt_phone.Text = "";
                for (int i = 0; i < PhoneBookLocalStorage.list.Count; i++)
                {
                    txt_phone.Text += (i != PhoneBookLocalStorage.list.Count - 1) ? PhoneBookLocalStorage.list[i] + "," : PhoneBookLocalStorage.list[i];
                }               
                PhoneBookLocalStorage.localStorageReaded = false;
                phonebookSMS_timmer.Stop();
                ValidatephoneNo();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OpenExcelFileForm();
        }
        private void OpenExcelFileForm()
        {
            var SendMessageViaExcel = new SendMessageViaExcel();
            SendMessageViaExcel.Closed += (s, args) => this.form1.Close();
            SendMessageViaExcel.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            OpenExcelFileForm();
        }
    }
}
