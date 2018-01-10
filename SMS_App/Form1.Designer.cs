using System.Drawing;

namespace SMS_App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_outbooknotification = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timer_SendSMS = new System.Windows.Forms.Timer(this.components);
            this.panel_Back = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label_trash = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label_sentItems = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel_OutboxNotification = new System.Windows.Forms.Panel();
            this.lbl_outboxNotificationCount = new System.Windows.Forms.Label();
            this.label_Outbox = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label_newMessage = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label_home = new System.Windows.Forms.Label();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_close = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Back.SuspendLayout();
            this.panel_nav.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel_OutboxNotification.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_outbooknotification
            // 
            this.timer_outbooknotification.Enabled = true;
            this.timer_outbooknotification.Interval = 500;
            this.timer_outbooknotification.Tick += new System.EventHandler(this.timer_outbooknotification_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // timer_SendSMS
            // 
            this.timer_SendSMS.Enabled = true;
            this.timer_SendSMS.Interval = 1000;
            this.timer_SendSMS.Tick += new System.EventHandler(this.timer_SendSMS_Tick);
            // 
            // panel_Back
            // 
            this.panel_Back.BackColor = System.Drawing.Color.Black;
            this.panel_Back.BackgroundImage = global::SMS_App.Properties.Resources.dark_blue_background_blue_15092414061;
            this.panel_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Back.Controls.Add(this.panel_body);
            this.panel_Back.Controls.Add(this.panel_nav);
            this.panel_Back.Controls.Add(this.panel_head);
            this.panel_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Back.Location = new System.Drawing.Point(0, 0);
            this.panel_Back.Name = "panel_Back";
            this.panel_Back.Size = new System.Drawing.Size(784, 562);
            this.panel_Back.TabIndex = 0;
            this.panel_Back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseMove);
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.Transparent;
            this.panel_body.Location = new System.Drawing.Point(0, 87);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(784, 475);
            this.panel_body.TabIndex = 4;
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_nav.Controls.Add(this.panel8);
            this.panel_nav.Controls.Add(this.panel9);
            this.panel_nav.Controls.Add(this.panel10);
            this.panel_nav.Controls.Add(this.panel11);
            this.panel_nav.Controls.Add(this.panel13);
            this.panel_nav.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_nav.Location = new System.Drawing.Point(0, 53);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(785, 35);
            this.panel_nav.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.label_trash);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(680, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(79, 28);
            this.panel8.TabIndex = 6;
            this.panel8.Click += new System.EventHandler(this.panel8_Click);
            // 
            // label_trash
            // 
            this.label_trash.AutoSize = true;
            this.label_trash.BackColor = System.Drawing.Color.Transparent;
            this.label_trash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trash.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_trash.Location = new System.Drawing.Point(9, 7);
            this.label_trash.Name = "label_trash";
            this.label_trash.Size = new System.Drawing.Size(43, 16);
            this.label_trash.TabIndex = 0;
            this.label_trash.Text = "Trash";
            this.label_trash.Click += new System.EventHandler(this.label_trash_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.label_sentItems);
            this.panel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel9.Location = new System.Drawing.Point(588, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(91, 28);
            this.panel9.TabIndex = 5;
            this.panel9.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label_sentItems
            // 
            this.label_sentItems.AutoSize = true;
            this.label_sentItems.BackColor = System.Drawing.Color.Transparent;
            this.label_sentItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sentItems.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_sentItems.Location = new System.Drawing.Point(4, 7);
            this.label_sentItems.Name = "label_sentItems";
            this.label_sentItems.Size = new System.Drawing.Size(70, 16);
            this.label_sentItems.TabIndex = 0;
            this.label_sentItems.Text = "Sent Items";
            this.label_sentItems.Click += new System.EventHandler(this.label_sentItems_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.panel_OutboxNotification);
            this.panel10.Controls.Add(this.label_Outbox);
            this.panel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel10.Location = new System.Drawing.Point(491, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(97, 28);
            this.panel10.TabIndex = 4;
            this.panel10.Click += new System.EventHandler(this.panel10_Click);
            // 
            // panel_OutboxNotification
            // 
            this.panel_OutboxNotification.BackColor = System.Drawing.Color.Transparent;
            this.panel_OutboxNotification.BackgroundImage = global::SMS_App.Properties.Resources.notification;
            this.panel_OutboxNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_OutboxNotification.Controls.Add(this.lbl_outboxNotificationCount);
            this.panel_OutboxNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_OutboxNotification.Location = new System.Drawing.Point(69, 5);
            this.panel_OutboxNotification.Name = "panel_OutboxNotification";
            this.panel_OutboxNotification.Size = new System.Drawing.Size(20, 20);
            this.panel_OutboxNotification.TabIndex = 7;
            this.panel_OutboxNotification.Visible = false;
            // 
            // lbl_outboxNotificationCount
            // 
            this.lbl_outboxNotificationCount.AutoSize = true;
            this.lbl_outboxNotificationCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_outboxNotificationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outboxNotificationCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_outboxNotificationCount.Location = new System.Drawing.Point(3, 4);
            this.lbl_outboxNotificationCount.Name = "lbl_outboxNotificationCount";
            this.lbl_outboxNotificationCount.Size = new System.Drawing.Size(13, 13);
            this.lbl_outboxNotificationCount.TabIndex = 1;
            this.lbl_outboxNotificationCount.Text = "1";
            // 
            // label_Outbox
            // 
            this.label_Outbox.AutoSize = true;
            this.label_Outbox.BackColor = System.Drawing.Color.Transparent;
            this.label_Outbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Outbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_Outbox.Location = new System.Drawing.Point(2, 7);
            this.label_Outbox.Name = "label_Outbox";
            this.label_Outbox.Size = new System.Drawing.Size(50, 16);
            this.label_Outbox.TabIndex = 0;
            this.label_Outbox.Text = "Outbox";
            this.label_Outbox.Click += new System.EventHandler(this.label_Outbox_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.label_newMessage);
            this.panel11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel11.Location = new System.Drawing.Point(373, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(120, 28);
            this.panel11.TabIndex = 3;
            this.panel11.Click += new System.EventHandler(this.panel11_Click);
            // 
            // label_newMessage
            // 
            this.label_newMessage.AutoSize = true;
            this.label_newMessage.BackColor = System.Drawing.Color.Transparent;
            this.label_newMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_newMessage.Location = new System.Drawing.Point(14, 7);
            this.label_newMessage.Name = "label_newMessage";
            this.label_newMessage.Size = new System.Drawing.Size(95, 16);
            this.label_newMessage.TabIndex = 0;
            this.label_newMessage.Text = "New Message";
            this.label_newMessage.Click += new System.EventHandler(this.label_newMessage_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.Controls.Add(this.label_home);
            this.panel13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel13.Location = new System.Drawing.Point(299, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(75, 28);
            this.panel13.TabIndex = 1;
            this.panel13.Click += new System.EventHandler(this.panel13_Click);
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.BackColor = System.Drawing.Color.Transparent;
            this.label_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_home.Location = new System.Drawing.Point(13, 7);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(45, 16);
            this.label_home.TabIndex = 0;
            this.label_home.Text = "Home";
            this.label_home.Click += new System.EventHandler(this.label10_Click);
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
            this.panel_head.Size = new System.Drawing.Size(785, 53);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "SMS App";
            // 
            // panel_close
            // 
            this.panel_close.BackColor = System.Drawing.Color.Transparent;
            this.panel_close.BackgroundImage = global::SMS_App.Properties.Resources.a947bd4c478b;
            this.panel_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_close.Location = new System.Drawing.Point(748, 9);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_Back.ResumeLayout(false);
            this.panel_nav.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel_OutboxNotification.ResumeLayout(false);
            this.panel_OutboxNotification.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
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
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label_trash;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label_sentItems;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label_Outbox;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label_newMessage;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel_OutboxNotification;
        private System.Windows.Forms.Label lbl_outboxNotificationCount;
        private System.Windows.Forms.Timer timer_outbooknotification;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Timer timer_SendSMS;
    }
}

