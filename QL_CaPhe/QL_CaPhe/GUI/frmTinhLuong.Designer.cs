namespace QL_CaPhe.GUI
{
    partial class frmTinhLuong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTienLuong = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPhuCap = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.mtbDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.mtbTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTinhLuong = new System.Windows.Forms.DataGridView();
            this.MaBangLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGioLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCaLam = new System.Windows.Forms.DataGridView();
            this.NgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbTongGio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTienLuong);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbPhuCap);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.mtbDenNgay);
            this.panel1.Controls.Add(this.mtbTuNgay);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvTinhLuong);
            this.panel1.Controls.Add(this.dgvCaLam);
            this.panel1.Controls.Add(this.cboMaNV);
            this.panel1.Controls.Add(this.lbTenNV);
            this.panel1.Controls.Add(this.lbChucVu);
            this.panel1.Controls.Add(this.lbTongGio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 568);
            this.panel1.TabIndex = 0;
            // 
            // lbTienLuong
            // 
            this.lbTienLuong.AutoSize = true;
            this.lbTienLuong.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienLuong.Location = new System.Drawing.Point(653, 324);
            this.lbTienLuong.Name = "lbTienLuong";
            this.lbTienLuong.Size = new System.Drawing.Size(60, 22);
            this.lbTienLuong.TabIndex = 18;
            this.lbTienLuong.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(537, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tiền lương :";
            // 
            // lbPhuCap
            // 
            this.lbPhuCap.AutoSize = true;
            this.lbPhuCap.Location = new System.Drawing.Point(201, 231);
            this.lbPhuCap.Name = "lbPhuCap";
            this.lbPhuCap.Size = new System.Drawing.Size(51, 19);
            this.lbPhuCap.TabIndex = 16;
            this.lbPhuCap.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Phụ cấp";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(872, 314);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(129, 42);
            this.btnThanhToan.TabIndex = 14;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // mtbDenNgay
            // 
            this.mtbDenNgay.Location = new System.Drawing.Point(201, 324);
            this.mtbDenNgay.Name = "mtbDenNgay";
            this.mtbDenNgay.Size = new System.Drawing.Size(217, 27);
            this.mtbDenNgay.TabIndex = 13;
            // 
            // mtbTuNgay
            // 
            this.mtbTuNgay.Location = new System.Drawing.Point(201, 276);
            this.mtbTuNgay.Name = "mtbTuNgay";
            this.mtbTuNgay.Size = new System.Drawing.Size(217, 27);
            this.mtbTuNgay.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Từ ngày";
            // 
            // dgvTinhLuong
            // 
            this.dgvTinhLuong.AllowUserToAddRows = false;
            this.dgvTinhLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTinhLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBangLuong,
            this.TenNhanVien,
            this.SoGioLam,
            this.ChucVu,
            this.PhuCap,
            this.TienLuong});
            this.dgvTinhLuong.Location = new System.Drawing.Point(30, 396);
            this.dgvTinhLuong.Name = "dgvTinhLuong";
            this.dgvTinhLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTinhLuong.Size = new System.Drawing.Size(971, 150);
            this.dgvTinhLuong.TabIndex = 9;
            // 
            // MaBangLuong
            // 
            this.MaBangLuong.HeaderText = "Mã bảng lương";
            this.MaBangLuong.Name = "MaBangLuong";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // SoGioLam
            // 
            this.SoGioLam.HeaderText = "Số giờ làm";
            this.SoGioLam.Name = "SoGioLam";
            // 
            // ChucVu
            // 
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.Name = "ChucVu";
            // 
            // PhuCap
            // 
            this.PhuCap.HeaderText = "Tiền phụ cấp";
            this.PhuCap.Name = "PhuCap";
            // 
            // TienLuong
            // 
            this.TienLuong.HeaderText = "Tiền lương";
            this.TienLuong.Name = "TienLuong";
            // 
            // dgvCaLam
            // 
            this.dgvCaLam.AllowUserToAddRows = false;
            this.dgvCaLam.AllowUserToDeleteRows = false;
            this.dgvCaLam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaLam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayLam,
            this.CaLam});
            this.dgvCaLam.Location = new System.Drawing.Point(541, 24);
            this.dgvCaLam.Name = "dgvCaLam";
            this.dgvCaLam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaLam.Size = new System.Drawing.Size(460, 251);
            this.dgvCaLam.TabIndex = 8;
            // 
            // NgayLam
            // 
            this.NgayLam.HeaderText = "Ngày làm việc";
            this.NgayLam.Name = "NgayLam";
            // 
            // CaLam
            // 
            this.CaLam.HeaderText = "Ca Làm";
            this.CaLam.Name = "CaLam";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(201, 38);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(217, 27);
            this.cboMaNV.TabIndex = 7;
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(201, 138);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(51, 19);
            this.lbTenNV.TabIndex = 6;
            this.lbTenNV.Text = "label7";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(201, 92);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(51, 19);
            this.lbChucVu.TabIndex = 5;
            this.lbChucVu.Text = "label6";
            // 
            // lbTongGio
            // 
            this.lbTongGio.AutoSize = true;
            this.lbTongGio.Location = new System.Drawing.Point(201, 183);
            this.lbTongGio.Name = "lbTongGio";
            this.lbTongGio.Size = new System.Drawing.Size(51, 19);
            this.lbTongGio.TabIndex = 4;
            this.lbTongGio.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số giờ làm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // frmTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 591);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTinhLuong";
            this.Text = "frmTinhLuong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbTongGio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTinhLuong;
        private System.Windows.Forms.DataGridView dgvCaLam;
        private System.Windows.Forms.Label lbPhuCap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.MaskedTextBox mtbDenNgay;
        private System.Windows.Forms.MaskedTextBox mtbTuNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBangLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGioLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaLam;
        private System.Windows.Forms.Label lbTienLuong;
        private System.Windows.Forms.Label label8;
    }
}