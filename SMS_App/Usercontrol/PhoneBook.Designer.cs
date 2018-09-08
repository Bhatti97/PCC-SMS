using System.Drawing;

namespace SMS_App.Usercontrol
{
    partial class PhoneBook
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.lblError_FirstName = new System.Windows.Forms.Label();
            this.lblError_LastName = new System.Windows.Forms.Label();
            this.lblError_PhoneNo = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Panel();
            this.lbl_Send = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridContact = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_nav.SuspendLayout();
            this.btn_Save.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContact)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_nav.Controls.Add(this.panel1);
            this.panel_nav.Controls.Add(this.lblError_FirstName);
            this.panel_nav.Controls.Add(this.lblError_LastName);
            this.panel_nav.Controls.Add(this.lblError_PhoneNo);
            this.panel_nav.Controls.Add(this.btn_Save);
            this.panel_nav.Controls.Add(this.txt_Number);
            this.panel_nav.Controls.Add(this.label4);
            this.panel_nav.Controls.Add(this.txt_LastName);
            this.panel_nav.Controls.Add(this.label3);
            this.panel_nav.Controls.Add(this.txt_firstname);
            this.panel_nav.Controls.Add(this.label2);
            this.panel_nav.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_nav.Location = new System.Drawing.Point(-1, 0);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(785, 171);
            this.panel_nav.TabIndex = 2;
            // 
            // lblError_FirstName
            // 
            this.lblError_FirstName.AutoSize = true;
            this.lblError_FirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblError_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_FirstName.ForeColor = System.Drawing.Color.Red;
            this.lblError_FirstName.Location = new System.Drawing.Point(549, 28);
            this.lblError_FirstName.Name = "lblError_FirstName";
            this.lblError_FirstName.Size = new System.Drawing.Size(0, 16);
            this.lblError_FirstName.TabIndex = 82;
            // 
            // lblError_LastName
            // 
            this.lblError_LastName.AutoSize = true;
            this.lblError_LastName.BackColor = System.Drawing.Color.Transparent;
            this.lblError_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_LastName.ForeColor = System.Drawing.Color.Red;
            this.lblError_LastName.Location = new System.Drawing.Point(549, 60);
            this.lblError_LastName.Name = "lblError_LastName";
            this.lblError_LastName.Size = new System.Drawing.Size(0, 16);
            this.lblError_LastName.TabIndex = 81;
            // 
            // lblError_PhoneNo
            // 
            this.lblError_PhoneNo.AutoSize = true;
            this.lblError_PhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.lblError_PhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_PhoneNo.ForeColor = System.Drawing.Color.Red;
            this.lblError_PhoneNo.Location = new System.Drawing.Point(549, 96);
            this.lblError_PhoneNo.Name = "lblError_PhoneNo";
            this.lblError_PhoneNo.Size = new System.Drawing.Size(0, 16);
            this.lblError_PhoneNo.TabIndex = 80;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Save.Controls.Add(this.lbl_Send);
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Save.Location = new System.Drawing.Point(459, 122);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(74, 31);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Send
            // 
            this.lbl_Send.AutoSize = true;
            this.lbl_Send.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Send.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Send.Location = new System.Drawing.Point(18, 8);
            this.lbl_Send.Name = "lbl_Send";
            this.lbl_Send.Size = new System.Drawing.Size(40, 16);
            this.lbl_Send.TabIndex = 5;
            this.lbl_Send.Text = "Save";
            this.lbl_Send.Click += new System.EventHandler(this.lbl_Send_Click);
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(341, 95);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(192, 20);
            this.txt_Number.TabIndex = 8;
            this.txt_Number.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Number_KeyUp);
            this.txt_Number.Leave += new System.EventHandler(this.txt_Number_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(263, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(341, 59);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(192, 20);
            this.txt_LastName.TabIndex = 6;
            this.txt_LastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_LastName_KeyUp);
            this.txt_LastName.Leave += new System.EventHandler(this.txt_LastName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(249, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(341, 24);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(192, 20);
            this.txt_firstname.TabIndex = 4;
            this.txt_firstname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_firstname_KeyUp);
            this.txt_firstname.Leave += new System.EventHandler(this.txt_firstname_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(249, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // gridContact
            // 
            this.gridContact.AllowUserToAddRows = false;
            this.gridContact.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridContact.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridContact.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridContact.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContact.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridContact.DoubleBuffered = true;
            this.gridContact.EnableHeadersVisualStyles = false;
            this.gridContact.HeaderBgColor = System.Drawing.Color.Silver;
            this.gridContact.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.gridContact.Location = new System.Drawing.Point(0, 168);
            this.gridContact.Name = "gridContact";
            this.gridContact.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridContact.RowTemplate.Height = 24;
            this.gridContact.Size = new System.Drawing.Size(784, 304);
            this.gridContact.TabIndex = 79;
            this.gridContact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContact_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(379, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 31);
            this.panel1.TabIndex = 83;
            this.panel1.Click += new System.EventHandler(this.panel1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clear";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // PhoneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gridContact);
            this.Controls.Add(this.panel_nav);
            this.Name = "PhoneBook";
            this.Size = new System.Drawing.Size(784, 472);
            this.panel_nav.ResumeLayout(false);
            this.panel_nav.PerformLayout();
            this.btn_Save.ResumeLayout(false);
            this.btn_Save.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContact)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_nav;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridContact;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel btn_Save;
        private System.Windows.Forms.Label lbl_Send;
        private System.Windows.Forms.Label lblError_PhoneNo;
        private System.Windows.Forms.Label lblError_LastName;
        private System.Windows.Forms.Label lblError_FirstName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
