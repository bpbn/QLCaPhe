
namespace QL_CaPhe.GUI
{
    partial class frmDN_DK
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ck_RememberMe = new System.Windows.Forms.CheckBox();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Submit.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Submit.Location = new System.Drawing.Point(139, 568);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(200, 42);
            this.btn_Submit.TabIndex = 28;
            this.btn_Submit.Text = "OK";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btn_DangNhap.FlatAppearance.BorderSize = 3;
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_DangNhap.Location = new System.Drawing.Point(40, 251);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(411, 42);
            this.btn_DangNhap.TabIndex = 29;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_Password.Location = new System.Drawing.Point(22, 98);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(411, 30);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_TenTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTK.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_TenTK.Location = new System.Drawing.Point(22, 34);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(411, 30);
            this.txt_TenTK.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên tài khoản";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.txt_TenTK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 136);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(399, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // ck_RememberMe
            // 
            this.ck_RememberMe.AutoSize = true;
            this.ck_RememberMe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_RememberMe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ck_RememberMe.Location = new System.Drawing.Point(40, 475);
            this.ck_RememberMe.Name = "ck_RememberMe";
            this.ck_RememberMe.Size = new System.Drawing.Size(148, 26);
            this.ck_RememberMe.TabIndex = 32;
            this.ck_RememberMe.Text = "Remember Me";
            this.ck_RememberMe.UseVisualStyleBackColor = true;
            this.ck_RememberMe.CheckedChanged += new System.EventHandler(this.ck_RememberMe_CheckedChanged);
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(22, 28);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(411, 30);
            this.txt_ConfirmPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(18, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Confirm password";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_ConfirmPassword);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(18, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 75);
            this.panel2.TabIndex = 31;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(40, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(411, 286);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // frmDN_DK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 635);
            this.Controls.Add(this.ck_RememberMe);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmDN_DK";
            this.Text = "frmDN_DK";
            this.Load += new System.EventHandler(this.From_DN_DK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ck_RememberMe;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
    }
}