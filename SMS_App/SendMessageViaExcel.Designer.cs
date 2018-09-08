using System.Drawing;

namespace SMS_App
{
    partial class SendMessageViaExcel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMessageViaExcel));
            this.panel_Back = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridExcelloadedFile = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_close = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OpenExcelfilePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Columns1Grid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Columns2Grid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.richTxt_message = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label_home = new System.Windows.Forms.Label();
            this.lblError_message = new System.Windows.Forms.Label();
            this.panel_Back.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExcelloadedFile)).BeginInit();
            this.panel_head.SuspendLayout();
            this.OpenExcelfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Columns1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns2Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Back
            // 
            this.panel_Back.BackColor = System.Drawing.Color.Black;
            this.panel_Back.BackgroundImage = global::SMS_App.Properties.Resources.dark_blue_background_blue_15092414061;
            this.panel_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Back.Controls.Add(this.lblError_message);
            this.panel_Back.Controls.Add(this.richTxt_message);
            this.panel_Back.Controls.Add(this.label5);
            this.panel_Back.Controls.Add(this.txt_phone);
            this.panel_Back.Controls.Add(this.label_home);
            this.panel_Back.Controls.Add(this.OpenExcelfilePanel);
            this.panel_Back.Controls.Add(this.panel4);
            this.panel_Back.Controls.Add(this.panel3);
            this.panel_Back.Controls.Add(this.panel1);
            this.panel_Back.Controls.Add(this.panel_head);
            this.panel_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Back.Location = new System.Drawing.Point(0, 0);
            this.panel_Back.Name = "panel_Back";
            this.panel_Back.Size = new System.Drawing.Size(935, 562);
            this.panel_Back.TabIndex = 0;
            this.panel_Back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Brown;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(190, 524);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 39);
            this.panel4.TabIndex = 83;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(72, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cancel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(0, 523);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 39);
            this.panel3.TabIndex = 82;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(77, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "OK";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.Columns2Grid);
            this.panel1.Controls.Add(this.Columns1Grid);
            this.panel1.Controls.Add(this.gridExcelloadedFile);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(385, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 512);
            this.panel1.TabIndex = 81;
            // 
            // gridExcelloadedFile
            // 
            this.gridExcelloadedFile.AllowUserToAddRows = false;
            this.gridExcelloadedFile.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridExcelloadedFile.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridExcelloadedFile.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridExcelloadedFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridExcelloadedFile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridExcelloadedFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridExcelloadedFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridExcelloadedFile.DoubleBuffered = true;
            this.gridExcelloadedFile.EnableHeadersVisualStyles = false;
            this.gridExcelloadedFile.HeaderBgColor = System.Drawing.Color.Silver;
            this.gridExcelloadedFile.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.gridExcelloadedFile.Location = new System.Drawing.Point(239, 45);
            this.gridExcelloadedFile.Name = "gridExcelloadedFile";
            this.gridExcelloadedFile.ReadOnly = true;
            this.gridExcelloadedFile.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridExcelloadedFile.RowTemplate.Height = 24;
            this.gridExcelloadedFile.Size = new System.Drawing.Size(311, 470);
            this.gridExcelloadedFile.TabIndex = 82;
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_head.Controls.Add(this.label1);
            this.panel_head.Controls.Add(this.panel_close);
            this.panel_head.Controls.Add(this.panel2);
            this.panel_head.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel_head.Location = new System.Drawing.Point(-1, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(936, 50);
            this.panel_head.TabIndex = 0;
            this.panel_head.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_head_Paint);
            this.panel_head.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_head_MouseDown);
            this.panel_head.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_head_MouseMove);
            this.panel_head.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_head_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(54, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Number from PhoneBook";
            // 
            // panel_close
            // 
            this.panel_close.BackColor = System.Drawing.Color.Transparent;
            this.panel_close.BackgroundImage = global::SMS_App.Properties.Resources.a947bd4c478b;
            this.panel_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_close.Location = new System.Drawing.Point(894, 9);
            this.panel_close.Name = "panel_close";
            this.panel_close.Size = new System.Drawing.Size(34, 32);
            this.panel_close.TabIndex = 2;
            this.panel_close.Click += new System.EventHandler(this.panel_close_Click);
            this.panel_close.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_close_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::SMS_App.Properties.Resources.blue_sms_icon_hi;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(4, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(47, 33);
            this.panel2.TabIndex = 1;
            // 
            // OpenExcelfilePanel
            // 
            this.OpenExcelfilePanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.OpenExcelfilePanel.Controls.Add(this.label4);
            this.OpenExcelfilePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenExcelfilePanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenExcelfilePanel.Location = new System.Drawing.Point(743, 51);
            this.OpenExcelfilePanel.Name = "OpenExcelfilePanel";
            this.OpenExcelfilePanel.Size = new System.Drawing.Size(189, 39);
            this.OpenExcelfilePanel.TabIndex = 83;
            this.OpenExcelfilePanel.Click += new System.EventHandler(this.OpenExcelfilePanel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(47, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Open Excel File";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Columns1Grid
            // 
            this.Columns1Grid.AllowUserToAddRows = false;
            this.Columns1Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Columns1Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Columns1Grid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Columns1Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Columns1Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Columns1Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Columns1Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns1Grid.DoubleBuffered = true;
            this.Columns1Grid.EnableHeadersVisualStyles = false;
            this.Columns1Grid.HeaderBgColor = System.Drawing.Color.Silver;
            this.Columns1Grid.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Columns1Grid.Location = new System.Drawing.Point(3, 45);
            this.Columns1Grid.Name = "Columns1Grid";
            this.Columns1Grid.ReadOnly = true;
            this.Columns1Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Columns1Grid.RowTemplate.Height = 24;
            this.Columns1Grid.Size = new System.Drawing.Size(230, 112);
            this.Columns1Grid.TabIndex = 83;
            this.Columns1Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Columns1Grid_CellClick);
            // 
            // Columns2Grid
            // 
            this.Columns2Grid.AllowUserToAddRows = false;
            this.Columns2Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Columns2Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Columns2Grid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Columns2Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Columns2Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Columns2Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Columns2Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns2Grid.DoubleBuffered = true;
            this.Columns2Grid.EnableHeadersVisualStyles = false;
            this.Columns2Grid.HeaderBgColor = System.Drawing.Color.Silver;
            this.Columns2Grid.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Columns2Grid.Location = new System.Drawing.Point(3, 179);
            this.Columns2Grid.Name = "Columns2Grid";
            this.Columns2Grid.ReadOnly = true;
            this.Columns2Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Columns2Grid.RowTemplate.Height = 24;
            this.Columns2Grid.Size = new System.Drawing.Size(230, 112);
            this.Columns2Grid.TabIndex = 84;
            this.Columns2Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Columns2Grid_CellClick);
            // 
            // richTxt_message
            // 
            this.richTxt_message.Location = new System.Drawing.Point(119, 156);
            this.richTxt_message.Name = "richTxt_message";
            this.richTxt_message.Size = new System.Drawing.Size(217, 143);
            this.richTxt_message.TabIndex = 87;
            this.richTxt_message.Text = "";
            this.richTxt_message.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTxt_message_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(11, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 86;
            this.label5.Text = "Message";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(119, 121);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.ReadOnly = true;
            this.txt_phone.Size = new System.Drawing.Size(217, 20);
            this.txt_phone.TabIndex = 85;
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.BackColor = System.Drawing.Color.Transparent;
            this.label_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_home.Location = new System.Drawing.Point(11, 122);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(68, 16);
            this.label_home.TabIndex = 84;
            this.label_home.Text = "Phone No";
            // 
            // lblError_message
            // 
            this.lblError_message.AutoSize = true;
            this.lblError_message.BackColor = System.Drawing.Color.Transparent;
            this.lblError_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_message.ForeColor = System.Drawing.Color.Red;
            this.lblError_message.Location = new System.Drawing.Point(120, 303);
            this.lblError_message.Name = "lblError_message";
            this.lblError_message.Size = new System.Drawing.Size(13, 16);
            this.lblError_message.TabIndex = 85;
            this.lblError_message.Text = "*";
            // 
            // SendMessageViaExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 562);
            this.Controls.Add(this.panel_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendMessageViaExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Message Via Excel file";
            this.panel_Back.ResumeLayout(false);
            this.panel_Back.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridExcelloadedFile)).EndInit();
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            this.OpenExcelfilePanel.ResumeLayout(false);
            this.OpenExcelfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Columns1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns2Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_bg;
        private System.Windows.Forms.Panel panel_Back;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridExcelloadedFile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel OpenExcelfilePanel;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Columns2Grid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Columns1Grid;
        private System.Windows.Forms.RichTextBox richTxt_message;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Label lblError_message;
    }
}

