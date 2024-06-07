namespace QL_CaPhe.GUI
{
    partial class frmNguyenLieu
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
            this.pn_NguyenLieu = new System.Windows.Forms.Panel();
            this.dgvNL = new System.Windows.Forms.DataGridView();
            this.MaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNguyenLieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pn_NguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNL)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_NguyenLieu
            // 
            this.pn_NguyenLieu.Controls.Add(this.btnUpdate);
            this.pn_NguyenLieu.Controls.Add(this.txtSoLuong);
            this.pn_NguyenLieu.Controls.Add(this.txtNguyenLieu);
            this.pn_NguyenLieu.Controls.Add(this.label2);
            this.pn_NguyenLieu.Controls.Add(this.label1);
            this.pn_NguyenLieu.Controls.Add(this.dgvNL);
            this.pn_NguyenLieu.Location = new System.Drawing.Point(8, 4);
            this.pn_NguyenLieu.Name = "pn_NguyenLieu";
            this.pn_NguyenLieu.Size = new System.Drawing.Size(1018, 564);
            this.pn_NguyenLieu.TabIndex = 0;
            // 
            // dgvNL
            // 
            this.dgvNL.AllowUserToAddRows = false;
            this.dgvNL.AllowUserToDeleteRows = false;
            this.dgvNL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNL,
            this.TenNL,
            this.XuatXu,
            this.SoLuongTon});
            this.dgvNL.Location = new System.Drawing.Point(22, 31);
            this.dgvNL.Name = "dgvNL";
            this.dgvNL.RowHeadersVisible = false;
            this.dgvNL.RowHeadersWidth = 62;
            this.dgvNL.RowTemplate.Height = 28;
            this.dgvNL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNL.Size = new System.Drawing.Size(981, 286);
            this.dgvNL.TabIndex = 0;
            this.dgvNL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNL_CellContentClick);
            // 
            // MaNL
            // 
            this.MaNL.DataPropertyName = "MaNguyenLieu";
            this.MaNL.HeaderText = "Mã nguyên liệu";
            this.MaNL.MinimumWidth = 8;
            this.MaNL.Name = "MaNL";
            this.MaNL.Visible = false;
            // 
            // TenNL
            // 
            this.TenNL.DataPropertyName = "TenNguyenLieu";
            this.TenNL.HeaderText = "Tên nguyên liệu";
            this.TenNL.MinimumWidth = 8;
            this.TenNL.Name = "TenNL";
            // 
            // XuatXu
            // 
            this.XuatXu.DataPropertyName = "XuatXu";
            this.XuatXu.HeaderText = "Xuất xứ";
            this.XuatXu.MinimumWidth = 8;
            this.XuatXu.Name = "XuatXu";
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số lượng tồn";
            this.SoLuongTon.MinimumWidth = 8;
            this.SoLuongTon.Name = "SoLuongTon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nguyên liệu";
            // 
            // txtNguyenLieu
            // 
            this.txtNguyenLieu.Enabled = false;
            this.txtNguyenLieu.Location = new System.Drawing.Point(156, 338);
            this.txtNguyenLieu.Name = "txtNguyenLieu";
            this.txtNguyenLieu.Size = new System.Drawing.Size(277, 37);
            this.txtNguyenLieu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(597, 340);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(213, 37);
            this.txtSoLuong.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(867, 331);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 52);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 576);
            this.Controls.Add(this.pn_NguyenLieu);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmNguyenLieu";
            this.Text = "Nguyên liệu";
            this.pn_NguyenLieu.ResumeLayout(false);
            this.pn_NguyenLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Panel pn_NguyenLieu;
        private System.Windows.Forms.DataGridView dgvNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtNguyenLieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}