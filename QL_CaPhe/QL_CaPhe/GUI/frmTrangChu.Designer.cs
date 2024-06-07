namespace QL_CaPhe
{
    partial class frmTrangChu
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
            this.pn_TrangChu = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pn_TrangChu
            // 
            this.pn_TrangChu.Location = new System.Drawing.Point(228, 3);
            this.pn_TrangChu.Name = "pn_TrangChu";
            this.pn_TrangChu.Size = new System.Drawing.Size(1025, 590);
            this.pn_TrangChu.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(28, 330);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(169, 58);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(28, 480);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(169, 58);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lazy Coffee";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Location = new System.Drawing.Point(28, 401);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(169, 58);
            this.btnTinhLuong.TabIndex = 3;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // btnKho
            // 
            this.btnKho.Location = new System.Drawing.Point(28, 259);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(169, 58);
            this.btnKho.TabIndex = 1;
            this.btnKho.Text = "Kho";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Location = new System.Drawing.Point(28, 188);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(169, 58);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.Location = new System.Drawing.Point(28, 115);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(169, 58);
            this.btnChamCong.TabIndex = 4;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = true;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 592);
            this.Controls.Add(this.btnChamCong);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnKho);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.pn_TrangChu);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTrangChu";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_TrangChu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnChamCong;
    }
}

