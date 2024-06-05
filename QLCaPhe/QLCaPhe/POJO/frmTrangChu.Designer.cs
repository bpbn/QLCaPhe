namespace QLCaPhe
{
    partial class frmTrangChu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pn_TrangChu = new Panel();
            btnBanHang = new Button();
            btnNhapHang = new Button();
            btnThongKe = new Button();
            btnThoat = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // pn_TrangChu
            // 
            pn_TrangChu.Location = new Point(267, 1);
            pn_TrangChu.Name = "pn_TrangChu";
            pn_TrangChu.Size = new Size(1335, 708);
            pn_TrangChu.TabIndex = 0;
            // 
            // btnBanHang
            // 
            btnBanHang.Location = new Point(8, 179);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(249, 84);
            btnBanHang.TabIndex = 1;
            btnBanHang.Text = "Bán hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // btnNhapHang
            // 
            btnNhapHang.Location = new Point(8, 287);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Size = new Size(249, 84);
            btnNhapHang.TabIndex = 1;
            btnNhapHang.Text = "Nhập hàng";
            btnNhapHang.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(8, 398);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(249, 84);
            btnThongKe.TabIndex = 1;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(8, 505);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(249, 84);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Đăng xuất";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F);
            label1.Location = new Point(23, 58);
            label1.Name = "label1";
            label1.Size = new Size(209, 46);
            label1.TabIndex = 2;
            label1.Text = "Lazy Coffee";
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1606, 721);
            Controls.Add(label1);
            Controls.Add(btnThongKe);
            Controls.Add(btnThoat);
            Controls.Add(btnNhapHang);
            Controls.Add(btnBanHang);
            Controls.Add(pn_TrangChu);
            Name = "frmTrangChu";
            Text = "Trang chủ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn_TrangChu;
        private Button btnBanHang;
        private Button btnNhapHang;
        private Button btnThongKe;
        private Button btnThoat;
        private Label label1;
    }
}
