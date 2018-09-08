namespace SMS_App.Usercontrol
{
    partial class NewMessages
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLimit = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError_message = new System.Windows.Forms.Label();
            this.lblError_PhoneNo = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Panel();
            this.lbl_Send = new System.Windows.Forms.Label();
            this.richTxt_message = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label_home = new System.Windows.Forms.Label();
            this.phonebookSMS_timmer = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.btn_Send.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(149, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 41);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Message";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lblLimit);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lblError_message);
            this.panel3.Controls.Add(this.lblError_PhoneNo);
            this.panel3.Controls.Add(this.btn_Send);
            this.panel3.Controls.Add(this.richTxt_message);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_phone);
            this.panel3.Controls.Add(this.label_home);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Location = new System.Drawing.Point(159, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 338);
            this.panel3.TabIndex = 5;
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.BackColor = System.Drawing.Color.Transparent;
            this.lblLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLimit.Location = new System.Drawing.Point(382, 123);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(36, 13);
            this.lblLimit.TabIndex = 9;
            this.lblLimit.Text = "0/150";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.BackgroundImage = global::SMS_App.Properties.Resources.User_ico1;
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(387, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 27);
            this.panel4.TabIndex = 8;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(164, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 27);
            this.panel2.TabIndex = 6;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(63, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Import from File";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblError_message
            // 
            this.lblError_message.AutoSize = true;
            this.lblError_message.BackColor = System.Drawing.Color.Transparent;
            this.lblError_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_message.ForeColor = System.Drawing.Color.Red;
            this.lblError_message.Location = new System.Drawing.Point(168, 269);
            this.lblError_message.Name = "lblError_message";
            this.lblError_message.Size = new System.Drawing.Size(13, 16);
            this.lblError_message.TabIndex = 7;
            this.lblError_message.Text = "*";
            // 
            // lblError_PhoneNo
            // 
            this.lblError_PhoneNo.AutoSize = true;
            this.lblError_PhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.lblError_PhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_PhoneNo.ForeColor = System.Drawing.Color.Red;
            this.lblError_PhoneNo.Location = new System.Drawing.Point(168, 104);
            this.lblError_PhoneNo.Name = "lblError_PhoneNo";
            this.lblError_PhoneNo.Size = new System.Drawing.Size(99, 16);
            this.lblError_PhoneNo.TabIndex = 6;
            this.lblError_PhoneNo.Text = "E.g 032x-xxxxx1";
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Send.Controls.Add(this.lbl_Send);
            this.btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Send.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Send.Location = new System.Drawing.Point(307, 290);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(74, 31);
            this.btn_Send.TabIndex = 5;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
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
            this.lbl_Send.Text = "Send";
            this.lbl_Send.Click += new System.EventHandler(this.lbl_Send_Click);
            // 
            // richTxt_message
            // 
            this.richTxt_message.Location = new System.Drawing.Point(164, 123);
            this.richTxt_message.Name = "richTxt_message";
            this.richTxt_message.Size = new System.Drawing.Size(217, 143);
            this.richTxt_message.TabIndex = 4;
            this.richTxt_message.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(56, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(164, 45);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(217, 20);
            this.txt_phone.TabIndex = 2;
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.BackColor = System.Drawing.Color.Transparent;
            this.label_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_home.Location = new System.Drawing.Point(56, 46);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(68, 16);
            this.label_home.TabIndex = 1;
            this.label_home.Text = "Phone No";
            // 
            // phonebookSMS_timmer
            // 
            this.phonebookSMS_timmer.Tick += new System.EventHandler(this.phonebookSMS_timmer_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Firebrick;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Location = new System.Drawing.Point(164, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(137, 31);
            this.panel5.TabIndex = 10;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(2, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Send From Excel File";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // NewMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "NewMessages";
            this.Size = new System.Drawing.Size(784, 472);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.btn_Send.ResumeLayout(false);
            this.btn_Send.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel btn_Send;
        private System.Windows.Forms.RichTextBox richTxt_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Label lbl_Send;
        private System.Windows.Forms.Label lblError_PhoneNo;
        private System.Windows.Forms.Label lblError_message;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer phonebookSMS_timmer;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
    }
}
