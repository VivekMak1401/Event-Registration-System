namespace RegistrationAndLogin
{
    partial class Home
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_stdname = new System.Windows.Forms.Label();
            this.lbl_stdid = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.txt_sem = new System.Windows.Forms.TextBox();
            this.lbl_sem = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.lbl_course = new System.Windows.Forms.Label();
            this.txt_course = new System.Windows.Forms.TextBox();
            this.txt_stdname = new System.Windows.Forms.TextBox();
            this.txt_stdid = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_logout.Location = new System.Drawing.Point(1055, 35);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(128, 49);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_stdname);
            this.groupBox1.Controls.Add(this.lbl_stdid);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.lbl_mobile);
            this.groupBox1.Controls.Add(this.txt_sem);
            this.groupBox1.Controls.Add(this.lbl_sem);
            this.groupBox1.Controls.Add(this.txt_mobile);
            this.groupBox1.Controls.Add(this.lbl_course);
            this.groupBox1.Controls.Add(this.txt_course);
            this.groupBox1.Controls.Add(this.txt_stdname);
            this.groupBox1.Controls.Add(this.txt_stdid);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(33, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 318);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // lbl_stdname
            // 
            this.lbl_stdname.AutoSize = true;
            this.lbl_stdname.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_stdname.Location = new System.Drawing.Point(30, 51);
            this.lbl_stdname.Name = "lbl_stdname";
            this.lbl_stdname.Size = new System.Drawing.Size(118, 20);
            this.lbl_stdname.TabIndex = 1;
            this.lbl_stdname.Text = "Student Name";
            // 
            // lbl_stdid
            // 
            this.lbl_stdid.AutoSize = true;
            this.lbl_stdid.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_stdid.Location = new System.Drawing.Point(30, 92);
            this.lbl_stdid.Name = "lbl_stdid";
            this.lbl_stdid.Size = new System.Drawing.Size(95, 20);
            this.lbl_stdid.TabIndex = 1;
            this.lbl_stdid.Text = "Student ID";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_clear.Location = new System.Drawing.Point(437, 205);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(111, 47);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_email.Location = new System.Drawing.Point(484, 47);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(63, 20);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email ";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_save.Location = new System.Drawing.Point(303, 205);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 47);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Submit";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_mobile.Location = new System.Drawing.Point(484, 87);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(91, 20);
            this.lbl_mobile.TabIndex = 1;
            this.lbl_mobile.Text = "Mobile No";
            // 
            // txt_sem
            // 
            this.txt_sem.Location = new System.Drawing.Point(625, 123);
            this.txt_sem.Name = "txt_sem";
            this.txt_sem.Size = new System.Drawing.Size(171, 26);
            this.txt_sem.TabIndex = 2;
            // 
            // lbl_sem
            // 
            this.lbl_sem.AutoSize = true;
            this.lbl_sem.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_sem.Location = new System.Drawing.Point(483, 123);
            this.lbl_sem.Name = "lbl_sem";
            this.lbl_sem.Size = new System.Drawing.Size(78, 20);
            this.lbl_sem.TabIndex = 1;
            this.lbl_sem.Text = "Semester";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(625, 87);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(171, 26);
            this.txt_mobile.TabIndex = 2;
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_course.Location = new System.Drawing.Point(30, 131);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(61, 20);
            this.lbl_course.TabIndex = 1;
            this.lbl_course.Text = "Course";
            // 
            // txt_course
            // 
            this.txt_course.Location = new System.Drawing.Point(171, 125);
            this.txt_course.Name = "txt_course";
            this.txt_course.Size = new System.Drawing.Size(171, 26);
            this.txt_course.TabIndex = 2;
            // 
            // txt_stdname
            // 
            this.txt_stdname.Location = new System.Drawing.Point(171, 44);
            this.txt_stdname.Name = "txt_stdname";
            this.txt_stdname.Size = new System.Drawing.Size(171, 26);
            this.txt_stdname.TabIndex = 2;
            // 
            // txt_stdid
            // 
            this.txt_stdid.Location = new System.Drawing.Point(171, 86);
            this.txt_stdid.Name = "txt_stdid";
            this.txt_stdid.Size = new System.Drawing.Size(171, 26);
            this.txt_stdid.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(625, 41);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(171, 26);
            this.txt_email.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PRIMETIME", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(498, 50);
            this.label4.TabIndex = 9;
            this.label4.Text = "Student registration";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RegistrationAndLogin.Properties.Resources.WhatsApp_Image_2022_10_31_at_17_39_30;
            this.pictureBox3.Location = new System.Drawing.Point(976, 411);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(244, 307);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::RegistrationAndLogin.Properties.Resources.IMG_20221031_WA0045;
            this.pictureBox7.Location = new System.Drawing.Point(748, 178);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(250, 137);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::RegistrationAndLogin.Properties.Resources.IMG_20221031_WA0041;
            this.pictureBox5.Location = new System.Drawing.Point(492, 178);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(250, 137);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::RegistrationAndLogin.Properties.Resources.IMG_20221031_WA0037;
            this.pictureBox6.Location = new System.Drawing.Point(748, 35);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(250, 137);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RegistrationAndLogin.Properties.Resources.WhatsApp_Image_2022_10_31_at_17_39_58;
            this.pictureBox2.Location = new System.Drawing.Point(492, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RegistrationAndLogin.Properties.Resources.IMG_20221031_WA0038;
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1232, 748);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_logout);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_stdname;
        private System.Windows.Forms.Label lbl_stdid;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.TextBox txt_sem;
        private System.Windows.Forms.Label lbl_sem;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.TextBox txt_course;
        private System.Windows.Forms.TextBox txt_stdname;
        private System.Windows.Forms.TextBox txt_stdid;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}