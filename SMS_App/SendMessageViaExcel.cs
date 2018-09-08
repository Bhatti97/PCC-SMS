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
using Spire.Xls;
using Bunifu.Framework.UI;

namespace SMS_App
{
    public partial class SendMessageViaExcel : Form
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

        public SendMessageViaExcel()
        {
            InitializeComponent();
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
        private void On_OK()
        {
            if (Validategrid() && Validate_richTxt_message())
            {

                MessageBox.Show("Sending " + (gridExcelloadedFile.Rows.Count) + " Messages Please Wait....");

                int phoneNoIndex = GetPhonenoIndex();
                for (int i = 0; i < gridExcelloadedFile.Rows.Count; i++)
                {

                    SMS_tempBAL sMS_Temp = new SMS_tempBAL();
                    sMS_Temp.phoneNo= gridExcelloadedFile.Rows[i].Cells[phoneNoIndex].Value.ToString();
                    sMS_Temp.message = GetMessage(i);
                    sMS_Temp.TimeStamp = DateTime.Now;
                    temp_db.Add(sMS_Temp);

                }
                this.Hide();
            }
          
        }
        public string GetMessage(int rowIndex)
        {
            var messageArray = richTxt_message.Text.ToString().Split(' ');
            List<string> WordList = new List<string>();
            string str = "";
            
            foreach (var word in messageArray)
            {
                if (word.StartsWith("$"))
                {
                    int columnIndex=GetComlumnIndex(word);
                    WordList.Add(gridExcelloadedFile.Rows[rowIndex].Cells[columnIndex].Value.ToString());
                }
                else
                {
                    WordList.Add(word);
                }
                WordList.Add(" ");
            }


            foreach (var item in WordList)
            {
                str += item;
            }
            return str;
        }
        public int GetComlumnIndex(string column)
        {
            for (int i = 0; i < Columns1Grid.Rows.Count; i++)
            {
                if (Columns1Grid.Rows[i].Cells[0].Value.ToString() == column)
                {
                    return Convert.ToInt32(Columns1Grid.Rows[i].Cells[2].Value.ToString());
                }
            }
            return 0;
        }
        public int GetPhonenoIndex()
        {
            for (int i = 0; i < Columns1Grid.Rows.Count; i++)
            {
                if (Columns1Grid.Rows[i].Cells[0].Value.ToString() == txt_phone.Text)
                {
                    return Convert.ToInt32(Columns1Grid.Rows[i].Cells[2].Value.ToString());
                }
            }
            return 0;
        }
        public void On_cancel()
        {

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
        private void OpenExcelFile()
        {
            
            var opFile = new OpenFileDialog();
            opFile.Title = "Select a Excel File";
            opFile.Filter = "Excel workbook (*.xlsx)|*.xlsx|Excel macro-enabled workbook(*.xlsm)|*xlsm";
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                gridExcelloadedFile.Rows.Clear();
                gridExcelloadedFile.Columns.Clear();
                string fileName = opFile.FileName;
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(fileName);
                Worksheet sheet = workbook.Worksheets[0];
                //BunifuCustomDataGrid tempDatatable = new BunifuCustomDataGrid();
                 var   tempDatatable=sheet.ExportDataTable();

                Addcolumns(tempDatatable.Columns);

                this.gridExcelloadedFile.DataSource = sheet.ExportDataTable();

            }
        }
        private void Addcolumns(DataColumnCollection columns)
        {
           // List<string> Columns = new List<string>();
            Columns1Grid.Columns.Clear();
            Columns1Grid.Rows.Clear();
            Columns2Grid.Columns.Clear();
            Columns2Grid.Rows.Clear();

            Columns1Grid.Columns.Add("Columns", "Columns");            //1
            DataGridViewButtonColumn chk1 = new DataGridViewButtonColumn();
            Columns1Grid.Columns.Add(chk1);                          //0
            chk1.HeaderText = "";
            chk1.Name = "isSelected";
            Columns1Grid.Columns.Add("index", "index");            //1
            Columns1Grid.Columns[2].Visible = false;


            Columns2Grid.Columns.Add("Columns", "Columns");            //1
            DataGridViewButtonColumn chk2 = new DataGridViewButtonColumn();
            Columns2Grid.Columns.Add(chk2);                          //0
            chk2.HeaderText = "";
            chk2.Name = "isSelected";
            Columns2Grid.Columns.Add("index", "index");            //1
            Columns2Grid.Columns[2].Visible = false;

            for (int i = 0; i < columns.Count; i++)
            {
                Columns1Grid.Rows.Add("$"+columns[i].ColumnName,"Load in PhoneNo",i);
                Columns2Grid.Rows.Add("$"+columns[i].ColumnName, "Load in Message",i);
            }           

            
        }
        private bool Validategrid()
        {
            return gridExcelloadedFile.Rows.Count > 0 && gridExcelloadedFile.ColumnCount > 0;
        }
        private void OpenExcelfilePanel_Click(object sender, EventArgs e)
        {
            OpenExcelFile();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            OpenExcelFile();
        }

        private void richTxt_message_KeyUp(object sender, KeyEventArgs e)
        {
            Validate_richTxt_message();

        }
        public bool Validate_richTxt_message()
        {
            if (richTxt_message.Text == string.Empty)
            {
                lblError_message.Text = "*Required";
                return false;
            }
            else if (richTxt_message.Text.Length > 250)
            {
                lblError_message.Text = "SMS characters should be in 250";
                return false;
            }
            lblError_message.Text = "";
            return true;
        }


        private void Columns1Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                txt_phone.Text = Columns1Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void Columns2Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                richTxt_message.Text += (richTxt_message.Text.Length==0)? Columns2Grid.Rows[e.RowIndex].Cells[0].Value.ToString():" "+ Columns2Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                Validate_richTxt_message();
            }
        }
    }
}
