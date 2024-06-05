namespace QLCaPhe.POJO
{
    partial class frmBanHang
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
            pnBanHang = new Panel();
            lbTongSL = new Label();
            lbTongTien = new Label();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            Ten = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnChon = new Button();
            txtSoLuong = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            TenSP = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnTim = new Button();
            txtSanPham = new TextBox();
            pnBanHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnBanHang
            // 
            pnBanHang.Controls.Add(lbTongSL);
            pnBanHang.Controls.Add(lbTongTien);
            pnBanHang.Controls.Add(button2);
            pnBanHang.Controls.Add(button1);
            pnBanHang.Controls.Add(label4);
            pnBanHang.Controls.Add(label3);
            pnBanHang.Controls.Add(dataGridView2);
            pnBanHang.Controls.Add(btnChon);
            pnBanHang.Controls.Add(txtSoLuong);
            pnBanHang.Controls.Add(label2);
            pnBanHang.Controls.Add(dataGridView1);
            pnBanHang.Controls.Add(comboBox1);
            pnBanHang.Controls.Add(label1);
            pnBanHang.Controls.Add(btnTim);
            pnBanHang.Controls.Add(txtSanPham);
            pnBanHang.Location = new Point(18, 14);
            pnBanHang.Name = "pnBanHang";
            pnBanHang.Size = new Size(1314, 676);
            pnBanHang.TabIndex = 0;
            // 
            // lbTongSL
            // 
            lbTongSL.AutoSize = true;
            lbTongSL.Location = new Point(966, 539);
            lbTongSL.Name = "lbTongSL";
            lbTongSL.Size = new Size(0, 29);
            lbTongSL.TabIndex = 43;
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Location = new Point(966, 477);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(0, 29);
            lbTongTien.TabIndex = 42;
            // 
            // button2
            // 
            button2.Location = new Point(1158, 611);
            button2.Name = "button2";
            button2.Size = new Size(148, 50);
            button2.TabIndex = 40;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(755, 611);
            button1.Name = "button1";
            button1.Size = new Size(112, 50);
            button1.TabIndex = 41;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(755, 539);
            label4.Name = "label4";
            label4.Size = new Size(169, 29);
            label4.TabIndex = 39;
            label4.Text = "Tổng số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(755, 477);
            label3.Name = "label3";
            label3.Size = new Size(118, 29);
            label3.TabIndex = 38;
            label3.Text = "Tổng tiền:";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Ten, Gia, SoLuong, ThanhTien });
            dataGridView2.Location = new Point(755, 11);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(551, 429);
            dataGridView2.TabIndex = 37;
            // 
            // Ten
            // 
            Ten.HeaderText = "Tên SP";
            Ten.MinimumWidth = 8;
            Ten.Name = "Ten";
            // 
            // Gia
            // 
            Gia.HeaderText = "Giá";
            Gia.MinimumWidth = 8;
            Gia.Name = "Gia";
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            // 
            // btnChon
            // 
            btnChon.Location = new Point(565, 616);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(125, 49);
            btnChon.TabIndex = 36;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = true;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(140, 628);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(150, 37);
            txtSoLuong.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 632);
            label2.Name = "label2";
            label2.Size = new Size(106, 29);
            label2.TabIndex = 34;
            label2.Text = "Số lượng";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TenSP, DonGia });
            dataGridView1.Location = new Point(8, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(682, 441);
            dataGridView1.TabIndex = 33;
            // 
            // TenSP
            // 
            TenSP.HeaderText = "Tên sản phẩm";
            TenSP.MinimumWidth = 8;
            TenSP.Name = "TenSP";
            // 
            // DonGia
            // 
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 8;
            DonGia.Name = "DonGia";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(203, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(487, 37);
            comboBox1.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 29);
            label1.TabIndex = 31;
            label1.Text = "Nhà cung cấp";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(533, 11);
            btnTim.Margin = new Padding(4, 3, 4, 3);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(157, 41);
            btnTim.TabIndex = 30;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // txtSanPham
            // 
            txtSanPham.Location = new Point(8, 11);
            txtSanPham.Margin = new Padding(4, 3, 4, 3);
            txtSanPham.Name = "txtSanPham";
            txtSanPham.Size = new Size(499, 37);
            txtSanPham.TabIndex = 29;
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 702);
            Controls.Add(pnBanHang);
            Font = new Font("Times New Roman", 13F);
            Location = new Point(12, 12);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmBanHang";
            Text = "Bán hàng";
            pnBanHang.ResumeLayout(false);
            pnBanHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        //private Panel pnBanHang;
        private Label lbTongSL;
        private Label lbTongTien;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn ThanhTien;
        private Button btnChon;
        private TextBox txtSoLuong;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn DonGia;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnTim;
        private TextBox txtSanPham;
    }
}