namespace QL_CaPhe.GUI
{
    partial class frmKho
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
            this.pn_Kho = new System.Windows.Forms.Panel();
            this.pnKho = new System.Windows.Forms.Panel();
            this.btnUpdateNL = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.pn_Kho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Kho
            // 
            this.pn_Kho.Controls.Add(this.pnKho);
            this.pn_Kho.Controls.Add(this.btnUpdateNL);
            this.pn_Kho.Controls.Add(this.btnNhapHang);
            this.pn_Kho.Location = new System.Drawing.Point(2, 8);
            this.pn_Kho.Name = "pn_Kho";
            this.pn_Kho.Size = new System.Drawing.Size(1052, 564);
            this.pn_Kho.TabIndex = 0;
            // 
            // pnKho
            // 
            this.pnKho.Location = new System.Drawing.Point(3, 64);
            this.pnKho.Name = "pnKho";
            this.pnKho.Size = new System.Drawing.Size(1046, 497);
            this.pnKho.TabIndex = 1;
            // 
            // btnUpdateNL
            // 
            this.btnUpdateNL.Location = new System.Drawing.Point(515, 5);
            this.btnUpdateNL.Name = "btnUpdateNL";
            this.btnUpdateNL.Size = new System.Drawing.Size(149, 53);
            this.btnUpdateNL.TabIndex = 0;
            this.btnUpdateNL.Text = "Nguyên liệu";
            this.btnUpdateNL.UseVisualStyleBackColor = true;
            this.btnUpdateNL.Click += new System.EventHandler(this.btnUpdateNL_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Location = new System.Drawing.Point(335, 5);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(149, 53);
            this.btnNhapHang.TabIndex = 0;
            this.btnNhapHang.Text = "Nhập kho";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 576);
            this.Controls.Add(this.pn_Kho);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmKho";
            this.Text = "Kho";
            this.pn_Kho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Panel pn_Kho;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnUpdateNL;
        private System.Windows.Forms.Panel pnKho;
    }
}