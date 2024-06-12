namespace QL_CaPhe.GUI
{
    partial class frmDM_NhanVien
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
            this.pnNhanVien = new System.Windows.Forms.Panel();
            this.cbNghiLam = new System.Windows.Forms.CheckBox();
            this.pnNghiLam = new System.Windows.Forms.Panel();
            this.dtpNgayNghiLam = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnNhanVien.SuspendLayout();
            this.pnNghiLam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnNhanVien
            // 
            this.pnNhanVien.Controls.Add(this.cbNghiLam);
            this.pnNhanVien.Controls.Add(this.pnNghiLam);
            this.pnNhanVien.Controls.Add(this.rdoNu);
            this.pnNhanVien.Controls.Add(this.rdoNam);
            this.pnNhanVien.Controls.Add(this.dtpNgayVaoLam);
            this.pnNhanVien.Controls.Add(this.dtpNgaySinh);
            this.pnNhanVien.Controls.Add(this.dgvNhanVien);
            this.pnNhanVien.Controls.Add(this.btnLamMoi);
            this.pnNhanVien.Controls.Add(this.btnXoa);
            this.pnNhanVien.Controls.Add(this.btnSua);
            this.pnNhanVien.Controls.Add(this.btnThem);
            this.pnNhanVien.Controls.Add(this.cboChucVu);
            this.pnNhanVien.Controls.Add(this.txtDiaChi);
            this.pnNhanVien.Controls.Add(this.txtTimKiem);
            this.pnNhanVien.Controls.Add(this.txtTenNV);
            this.pnNhanVien.Controls.Add(this.txtMaNV);
            this.pnNhanVien.Controls.Add(this.label4);
            this.pnNhanVien.Controls.Add(this.label5);
            this.pnNhanVien.Controls.Add(this.label6);
            this.pnNhanVien.Controls.Add(this.label8);
            this.pnNhanVien.Controls.Add(this.label2);
            this.pnNhanVien.Controls.Add(this.label3);
            this.pnNhanVien.Controls.Add(this.label1);
            this.pnNhanVien.Location = new System.Drawing.Point(10, 10);
            this.pnNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnNhanVien.Name = "pnNhanVien";
            this.pnNhanVien.Size = new System.Drawing.Size(922, 578);
            this.pnNhanVien.TabIndex = 1;
            // 
            // cbNghiLam
            // 
            this.cbNghiLam.AutoSize = true;
            this.cbNghiLam.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNghiLam.Location = new System.Drawing.Point(730, 60);
            this.cbNghiLam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbNghiLam.Name = "cbNghiLam";
            this.cbNghiLam.Size = new System.Drawing.Size(115, 24);
            this.cbNghiLam.TabIndex = 10;
            this.cbNghiLam.Text = "Đã nghỉ làm";
            this.cbNghiLam.UseVisualStyleBackColor = true;
            this.cbNghiLam.CheckedChanged += new System.EventHandler(this.cbNghiLam_CheckedChanged);
            // 
            // pnNghiLam
            // 
            this.pnNghiLam.Controls.Add(this.dtpNgayNghiLam);
            this.pnNghiLam.Controls.Add(this.label7);
            this.pnNghiLam.Location = new System.Drawing.Point(628, 88);
            this.pnNghiLam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnNghiLam.Name = "pnNghiLam";
            this.pnNghiLam.Size = new System.Drawing.Size(260, 50);
            this.pnNghiLam.TabIndex = 9;
            this.pnNghiLam.Visible = false;
            // 
            // dtpNgayNghiLam
            // 
            this.dtpNgayNghiLam.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNghiLam.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNghiLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNghiLam.Location = new System.Drawing.Point(122, 12);
            this.dtpNgayNghiLam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayNghiLam.Name = "dtpNgayNghiLam";
            this.dtpNgayNghiLam.Size = new System.Drawing.Size(120, 28);
            this.dtpNgayNghiLam.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày nghỉ làm";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNu.Location = new System.Drawing.Point(730, 12);
            this.rdoNu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(50, 24);
            this.rdoNu.TabIndex = 8;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNam.Location = new System.Drawing.Point(657, 12);
            this.rdoNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(62, 24);
            this.rdoNam.TabIndex = 8;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayVaoLam.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(487, 100);
            this.dtpNgayVaoLam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(122, 28);
            this.dtpNgayVaoLam.TabIndex = 7;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(91, 54);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(148, 28);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(13, 195);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(894, 381);
            this.dgvNhanVien.TabIndex = 6;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(306, 150);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(93, 40);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(208, 150);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 40);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(111, 150);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 40);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(14, 150);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboChucVu
            // 
            this.cboChucVu.DisplayMember = "Đang bán";
            this.cboChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(84, 99);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(259, 28);
            this.cboChucVu.TabIndex = 4;
            this.cboChucVu.ValueMember = "Đang bán";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(341, 58);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(350, 27);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(570, 157);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(306, 27);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(397, 11);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(213, 27);
            this.txtTenNV.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(120, 11);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(114, 27);
            this.txtMaNV.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày vào làm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(490, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tìm kiếm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên";
            // 
            // frmDM_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 599);
            this.Controls.Add(this.pnNhanVien);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDM_NhanVien";
            this.Text = "Danh sách Nhân viên";
            this.Load += new System.EventHandler(this.frmDM_NhanVien_Load);
            this.pnNhanVien.ResumeLayout(false);
            this.pnNhanVien.PerformLayout();
            this.pnNghiLam.ResumeLayout(false);
            this.pnNghiLam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //public System.Windows.Forms.Panel pnNhanVien;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnNghiLam;
        private System.Windows.Forms.DateTimePicker dtpNgayNghiLam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbNghiLam;
    }
}