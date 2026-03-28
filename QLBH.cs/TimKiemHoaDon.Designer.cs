namespace BTL_XDCTQuanLyBanHang
{
    partial class frmTimHDBan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTimHDBan = new System.Windows.Forms.DataGridView();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimHDBan)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnTimLai);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 43);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.txtMakh);
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.txtNam);
            this.panel2.Controls.Add(this.txtThang);
            this.panel2.Controls.Add(this.txtMaHD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 139);
            this.panel2.TabIndex = 2;
            // 
            // dgvTimHDBan
            // 
            this.dgvTimHDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimHDBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimHDBan.Location = new System.Drawing.Point(0, 139);
            this.dgvTimHDBan.Name = "dgvTimHDBan";
            this.dgvTimHDBan.Size = new System.Drawing.Size(761, 304);
            this.dgvTimHDBan.TabIndex = 3;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(125, 30);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(220, 20);
            this.txtMaHD.TabIndex = 0;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(125, 62);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(66, 20);
            this.txtThang.TabIndex = 1;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(264, 62);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(81, 20);
            this.txtNam.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(125, 99);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(220, 20);
            this.txtMaNV.TabIndex = 3;
            // 
            // txtMakh
            // 
            this.txtMakh.Location = new System.Drawing.Point(503, 30);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(210, 20);
            this.txtMakh.TabIndex = 4;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(503, 62);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(210, 20);
            this.txtTongTien.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nháy đúp vào hóa đơn để hiển thị thông tin chi tiết";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 41);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(23, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(23, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(212, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Năm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(391, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mã khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(391, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tổng tiền";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTimKiem.Location = new System.Drawing.Point(125, 6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 33);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnTimLai
            // 
            this.btnTimLai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimLai.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTimLai.Location = new System.Drawing.Point(319, 6);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(100, 33);
            this.btnTimLai.TabIndex = 29;
            this.btnTimLai.Text = "&Tìm lại";
            this.btnTimLai.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Location = new System.Drawing.Point(503, 6);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 33);
            this.btnDong.TabIndex = 30;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // frmTimHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 486);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvTimHDBan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimHDBan";
            this.Text = "Tìm kiếm hóa đơn";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimHDBan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTimHDBan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDong;
    }
}