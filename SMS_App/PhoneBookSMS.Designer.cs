using System.Drawing;

namespace SMS_App
{
    partial class PhoneBookSMS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneBookSMS));
            this.panel_Back = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridContacts = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_close = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Back.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).BeginInit();
            this.panel_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Back
            // 
            this.panel_Back.BackColor = System.Drawing.Color.Black;
            this.panel_Back.BackgroundImage = global::SMS_App.Properties.Resources.dark_blue_background_blue_15092414061;
            this.panel_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Back.Controls.Add(this.panel4);
            this.panel_Back.Controls.Add(this.panel3);
            this.panel_Back.Controls.Add(this.panel1);
            this.panel_Back.Controls.Add(this.panel_head);
            this.panel_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Back.Location = new System.Drawing.Point(0, 0);
            this.panel_Back.Name = "panel_Back";
            this.panel_Back.Size = new System.Drawing.Size(380, 562);
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
            this.panel1.Controls.Add(this.gridContacts);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(-1, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 477);
            this.panel1.TabIndex = 81;
            // 
            // gridContacts
            // 
            this.gridContacts.AllowUserToAddRows = false;
            this.gridContacts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridContacts.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridContacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContacts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridContacts.DoubleBuffered = true;
            this.gridContacts.EnableHeadersVisualStyles = false;
            this.gridContacts.HeaderBgColor = System.Drawing.Color.Silver;
            this.gridContacts.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.gridContacts.Location = new System.Drawing.Point(0, 0);
            this.gridContacts.Name = "gridContacts";
            this.gridContacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridContacts.RowTemplate.Height = 24;
            this.gridContacts.Size = new System.Drawing.Size(381, 477);
            this.gridContacts.TabIndex = 82;
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
            this.panel_head.Size = new System.Drawing.Size(381, 50);
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
            this.panel_close.Location = new System.Drawing.Point(335, 9);
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
            // PhoneBookSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 562);
            this.Controls.Add(this.panel_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhoneBookSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_Back.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).EndInit();
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
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
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridContacts;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}

