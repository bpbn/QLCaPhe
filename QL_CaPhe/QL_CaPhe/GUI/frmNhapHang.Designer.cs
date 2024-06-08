namespace QL_CaPhe.GUI
{
    partial class frmNhapHang
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
            this.pnNhapHang = new System.Windows.Forms.Panel();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lbTongSoLuong = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.MANL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChon = new System.Windows.Forms.Button();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.MaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimNL = new System.Windows.Forms.Button();
            this.txtNguyenLieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNhanVienKho = new System.Windows.Forms.ComboBox();
            this.pnNhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnNhapHang
            // 
            this.pnNhapHang.Controls.Add(this.cboNhanVienKho);
            this.pnNhapHang.Controls.Add(this.cboNCC);
            this.pnNhapHang.Controls.Add(this.label6);
            this.pnNhapHang.Controls.Add(this.label5);
            this.pnNhapHang.Controls.Add(this.btnThanhToan);
            this.pnNhapHang.Controls.Add(this.btnHuy);
            this.pnNhapHang.Controls.Add(this.lbTongSoLuong);
            this.pnNhapHang.Controls.Add(this.lbTongTien);
            this.pnNhapHang.Controls.Add(this.label4);
            this.pnNhapHang.Controls.Add(this.label3);
            this.pnNhapHang.Controls.Add(this.dgvCTPN);
            this.pnNhapHang.Controls.Add(this.btnChon);
            this.pnNhapHang.Controls.Add(this.txtGiaNhap);
            this.pnNhapHang.Controls.Add(this.txtSoLuong);
            this.pnNhapHang.Controls.Add(this.label1);
            this.pnNhapHang.Controls.Add(this.label2);
            this.pnNhapHang.Controls.Add(this.dgvNguyenLieu);
            this.pnNhapHang.Controls.Add(this.btnTimNL);
            this.pnNhapHang.Controls.Add(this.txtNguyenLieu);
            this.pnNhapHang.Location = new System.Drawing.Point(2, 7);
            this.pnNhapHang.Name = "pnNhapHang";
            this.pnNhapHang.Size = new System.Drawing.Size(1018, 564);
            this.pnNhapHang.TabIndex = 0;
            // 
            // cboNCC
            // 
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(153, 9);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(334, 37);
            this.cboNCC.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nhà cung cấp";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(854, 441);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(148, 50);
            this.btnThanhToan.TabIndex = 27;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(521, 441);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 50);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbTongSoLuong
            // 
            this.lbTongSoLuong.AutoSize = true;
            this.lbTongSoLuong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lbTongSoLuong.Location = new System.Drawing.Point(690, 393);
            this.lbTongSoLuong.Name = "lbTongSoLuong";
            this.lbTongSoLuong.Size = new System.Drawing.Size(29, 33);
            this.lbTongSoLuong.TabIndex = 25;
            this.lbTongSoLuong.Text = "0";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.Red;
            this.lbTongTien.Location = new System.Drawing.Point(690, 350);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(29, 33);
            this.lbTongTien.TabIndex = 24;
            this.lbTongTien.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 33);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tổng số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 33);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tổng tiền:";
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AllowUserToAddRows = false;
            this.dgvCTPN.AllowUserToDeleteRows = false;
            this.dgvCTPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANL,
            this.TenNL,
            this.Gia,
            this.SoLuong,
            this.ThanhTien});
            this.dgvCTPN.Location = new System.Drawing.Point(520, 52);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.RowHeadersVisible = false;
            this.dgvCTPN.RowHeadersWidth = 62;
            this.dgvCTPN.RowTemplate.Height = 28;
            this.dgvCTPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPN.Size = new System.Drawing.Size(482, 284);
            this.dgvCTPN.TabIndex = 21;
            // 
            // MANL
            // 
            this.MANL.HeaderText = "Mã nguyên liệu";
            this.MANL.MinimumWidth = 8;
            this.MANL.Name = "MANL";
            this.MANL.Visible = false;
            // 
            // TenNL
            // 
            this.TenNL.HeaderText = "Tên nguyên liệu";
            this.TenNL.MinimumWidth = 8;
            this.TenNL.Name = "TenNL";
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá nhập";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(362, 442);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(125, 49);
            this.btnChon.TabIndex = 20;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(106, 400);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(156, 37);
            this.txtGiaNhap.TabIndex = 19;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(400, 401);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(87, 37);
            this.txtSoLuong.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số lượng";
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.AllowUserToAddRows = false;
            this.dgvNguyenLieu.AllowUserToDeleteRows = false;
            this.dgvNguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNguyenLieu,
            this.TenNguyenLieu,
            this.XuatXu,
            this.TonKho});
            this.dgvNguyenLieu.Location = new System.Drawing.Point(32, 93);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.RowHeadersVisible = false;
            this.dgvNguyenLieu.RowHeadersWidth = 62;
            this.dgvNguyenLieu.RowTemplate.Height = 28;
            this.dgvNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(455, 300);
            this.dgvNguyenLieu.TabIndex = 17;
            // 
            // MaNguyenLieu
            // 
            this.MaNguyenLieu.DataPropertyName = "MaNguyenLieu";
            this.MaNguyenLieu.HeaderText = "Mã nguyên liệu";
            this.MaNguyenLieu.MinimumWidth = 8;
            this.MaNguyenLieu.Name = "MaNguyenLieu";
            this.MaNguyenLieu.ReadOnly = true;
            this.MaNguyenLieu.Visible = false;
            // 
            // TenNguyenLieu
            // 
            this.TenNguyenLieu.DataPropertyName = "TenNguyenLieu";
            this.TenNguyenLieu.HeaderText = "Tên nguyên liệu";
            this.TenNguyenLieu.MinimumWidth = 8;
            this.TenNguyenLieu.Name = "TenNguyenLieu";
            this.TenNguyenLieu.ReadOnly = true;
            // 
            // XuatXu
            // 
            this.XuatXu.DataPropertyName = "XuatXu";
            this.XuatXu.HeaderText = "Xuất xứ";
            this.XuatXu.MinimumWidth = 8;
            this.XuatXu.Name = "XuatXu";
            this.XuatXu.ReadOnly = true;
            // 
            // TonKho
            // 
            this.TonKho.DataPropertyName = "SoLuongTon";
            this.TonKho.HeaderText = "Tồn kho";
            this.TonKho.MinimumWidth = 8;
            this.TonKho.Name = "TonKho";
            this.TonKho.Visible = false;
            // 
            // btnTimNL
            // 
            this.btnTimNL.Location = new System.Drawing.Point(368, 45);
            this.btnTimNL.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimNL.Name = "btnTimNL";
            this.btnTimNL.Size = new System.Drawing.Size(119, 41);
            this.btnTimNL.TabIndex = 16;
            this.btnTimNL.Text = "Tìm";
            this.btnTimNL.UseVisualStyleBackColor = true;
            this.btnTimNL.Click += new System.EventHandler(this.btnTimNL_Click);
            // 
            // txtNguyenLieu
            // 
            this.txtNguyenLieu.Location = new System.Drawing.Point(32, 52);
            this.txtNguyenLieu.Margin = new System.Windows.Forms.Padding(5);
            this.txtNguyenLieu.Name = "txtNguyenLieu";
            this.txtNguyenLieu.Size = new System.Drawing.Size(326, 37);
            this.txtNguyenLieu.TabIndex = 15;
            this.txtNguyenLieu.TextChanged += new System.EventHandler(this.txtNguyenLieu_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nhân viên";
            // 
            // cboNhanVienKho
            // 
            this.cboNhanVienKho.FormattingEnabled = true;
            this.cboNhanVienKho.Location = new System.Drawing.Point(628, 12);
            this.cboNhanVienKho.Name = "cboNhanVienKho";
            this.cboNhanVienKho.Size = new System.Drawing.Size(374, 37);
            this.cboNhanVienKho.TabIndex = 29;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 576);
            this.Controls.Add(this.pnNhapHang);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmNhapHang";
            this.Text = "Nhập hàng";
            this.pnNhapHang.ResumeLayout(false);
            this.pnNhapHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Panel pnNhapHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbTongSoLuong;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.Button btnTimNL;
        private System.Windows.Forms.TextBox txtNguyenLieu;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonKho;
        private System.Windows.Forms.ComboBox cboNhanVienKho;
        private System.Windows.Forms.Label label6;
    }
}