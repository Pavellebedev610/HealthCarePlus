﻿namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.logout_btn = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.appointmentBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.patientsBtn = new System.Windows.Forms.Button();
            this.doctorsBtn = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.app_name_label = new System.Windows.Forms.Label();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.username_label = new System.Windows.Forms.Label();
            this.avatarImage = new System.Windows.Forms.PictureBox();
            this.welcome_text = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.navigationPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(0, 573);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(200, 38);
            this.logout_btn.TabIndex = 14;
            this.logout_btn.Text = "Выйти из аккаунта";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.navigationPanel.Controls.Add(this.reportsBtn);
            this.navigationPanel.Controls.Add(this.logout_btn);
            this.navigationPanel.Controls.Add(this.appointmentBtn);
            this.navigationPanel.Controls.Add(this.staffBtn);
            this.navigationPanel.Controls.Add(this.patientsBtn);
            this.navigationPanel.Controls.Add(this.doctorsBtn);
            this.navigationPanel.Controls.Add(this.logoPanel);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(200, 611);
            this.navigationPanel.TabIndex = 15;
            // 
            // reportsBtn
            // 
            this.reportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.reportsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsBtn.FlatAppearance.BorderSize = 0;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.ForeColor = System.Drawing.Color.White;
            this.reportsBtn.Image = ((System.Drawing.Image)(resources.GetObject("reportsBtn.Image")));
            this.reportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsBtn.Location = new System.Drawing.Point(0, 368);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.reportsBtn.Size = new System.Drawing.Size(200, 60);
            this.reportsBtn.TabIndex = 5;
            this.reportsBtn.Text = "Отчёты";
            this.reportsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportsBtn.UseVisualStyleBackColor = false;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // appointmentBtn
            // 
            this.appointmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.appointmentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appointmentBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointmentBtn.FlatAppearance.BorderSize = 0;
            this.appointmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentBtn.ForeColor = System.Drawing.Color.White;
            this.appointmentBtn.Image = ((System.Drawing.Image)(resources.GetObject("appointmentBtn.Image")));
            this.appointmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointmentBtn.Location = new System.Drawing.Point(0, 308);
            this.appointmentBtn.Name = "appointmentBtn";
            this.appointmentBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.appointmentBtn.Size = new System.Drawing.Size(200, 60);
            this.appointmentBtn.TabIndex = 4;
            this.appointmentBtn.Text = "Назначения";
            this.appointmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appointmentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.appointmentBtn.UseVisualStyleBackColor = false;
            this.appointmentBtn.Click += new System.EventHandler(this.appoinmentsBtn_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.staffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.staffBtn.FlatAppearance.BorderSize = 0;
            this.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.ForeColor = System.Drawing.Color.White;
            this.staffBtn.Image = global::HealthCare_Plus.Properties.Resources.staff_icon;
            this.staffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.Location = new System.Drawing.Point(0, 248);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.staffBtn.Size = new System.Drawing.Size(200, 60);
            this.staffBtn.TabIndex = 3;
            this.staffBtn.Text = "Персонал";
            this.staffBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.staffBtn.UseVisualStyleBackColor = false;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // patientsBtn
            // 
            this.patientsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.patientsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientsBtn.FlatAppearance.BorderSize = 0;
            this.patientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsBtn.ForeColor = System.Drawing.Color.White;
            this.patientsBtn.Image = global::HealthCare_Plus.Properties.Resources.patient_icon;
            this.patientsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsBtn.Location = new System.Drawing.Point(0, 188);
            this.patientsBtn.Name = "patientsBtn";
            this.patientsBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.patientsBtn.Size = new System.Drawing.Size(200, 60);
            this.patientsBtn.TabIndex = 2;
            this.patientsBtn.Text = "Пациенты";
            this.patientsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientsBtn.UseVisualStyleBackColor = false;
            this.patientsBtn.Click += new System.EventHandler(this.patientsBtn_Click);
            // 
            // doctorsBtn
            // 
            this.doctorsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.doctorsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.doctorsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doctorsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorsBtn.FlatAppearance.BorderSize = 0;
            this.doctorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsBtn.ForeColor = System.Drawing.Color.White;
            this.doctorsBtn.Image = ((System.Drawing.Image)(resources.GetObject("doctorsBtn.Image")));
            this.doctorsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorsBtn.Location = new System.Drawing.Point(0, 128);
            this.doctorsBtn.Name = "doctorsBtn";
            this.doctorsBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.doctorsBtn.Size = new System.Drawing.Size(200, 60);
            this.doctorsBtn.TabIndex = 1;
            this.doctorsBtn.Text = "Доктора";
            this.doctorsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.doctorsBtn.UseVisualStyleBackColor = false;
            this.doctorsBtn.Click += new System.EventHandler(this.doctorsBtn_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.logoPanel.Controls.Add(this.app_name_label);
            this.logoPanel.Controls.Add(this.logoImage);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 128);
            this.logoPanel.TabIndex = 0;
            // 
            // app_name_label
            // 
            this.app_name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.app_name_label.AutoSize = true;
            this.app_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_name_label.ForeColor = System.Drawing.Color.White;
            this.app_name_label.Location = new System.Drawing.Point(27, 83);
            this.app_name_label.Name = "app_name_label";
            this.app_name_label.Size = new System.Drawing.Size(130, 18);
            this.app_name_label.TabIndex = 17;
            this.app_name_label.Text = "HealthCare Plus";
            // 
            // logoImage
            // 
            this.logoImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoImage.Image = global::HealthCare_Plus.Properties.Resources.medicine;
            this.logoImage.Location = new System.Drawing.Point(48, 19);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(100, 50);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(200, 69);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(884, 542);
            this.bodyPanel.TabIndex = 0;
            this.bodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyPanel_Paint);
            // 
            // username_label
            // 
            this.username_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(816, 48);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(58, 16);
            this.username_label.TabIndex = 13;
            this.username_label.Text = "System";
            // 
            // avatarImage
            // 
            this.avatarImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarImage.Image = global::HealthCare_Plus.Properties.Resources.user;
            this.avatarImage.Location = new System.Drawing.Point(822, 3);
            this.avatarImage.Name = "avatarImage";
            this.avatarImage.Size = new System.Drawing.Size(50, 42);
            this.avatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarImage.TabIndex = 12;
            this.avatarImage.TabStop = false;
            // 
            // welcome_text
            // 
            this.welcome_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcome_text.AutoSize = true;
            this.welcome_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcome_text.ForeColor = System.Drawing.Color.White;
            this.welcome_text.Location = new System.Drawing.Point(293, 20);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(299, 29);
            this.welcome_text.TabIndex = 14;
            this.welcome_text.Text = "Меню администратора";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(90)))));
            this.headerPanel.Controls.Add(this.welcome_text);
            this.headerPanel.Controls.Add(this.avatarImage);
            this.headerPanel.Controls.Add(this.username_label);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(200, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(884, 69);
            this.headerPanel.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.navigationPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.Text = "Здравствуй админ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.navigationPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Button doctorsBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button appointmentBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button patientsBtn;
        private System.Windows.Forms.Label app_name_label;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.PictureBox avatarImage;
        private System.Windows.Forms.Label welcome_text;
        private System.Windows.Forms.Panel headerPanel;
    }
}