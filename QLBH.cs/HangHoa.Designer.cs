namespace BTL_XDCTQuanLyBanHang
{
    partial class frmHangHoa
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHienDS = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboMaCL = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenH = new System.Windows.Forms.TextBox();
            this.txtMaH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnHienDS);
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTimKiem.Location = new System.Drawing.Point(512, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(83, 33);
            this.btnTimKiem.TabIndex = 29;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Location = new System.Drawing.Point(723, 18);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(83, 33);
            this.btnDong.TabIndex = 28;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHienDS
            // 
            this.btnHienDS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienDS.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnHienDS.Location = new System.Drawing.Point(614, 18);
            this.btnHienDS.Name = "btnHienDS";
            this.btnHienDS.Size = new System.Drawing.Size(92, 33);
            this.btnHienDS.TabIndex = 27;
            this.btnHienDS.Text = "&Hiển thị DS";
            this.btnHienDS.UseVisualStyleBackColor = true;
            this.btnHienDS.Click += new System.EventHandler(this.btnHienDS_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBoQua.Location = new System.Drawing.Point(412, 18);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(83, 33);
            this.btnBoQua.TabIndex = 9;
            this.btnBoQua.Text = "&Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnLuu.Location = new System.Drawing.Point(311, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(83, 33);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSua.Location = new System.Drawing.Point(214, 18);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 33);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.Location = new System.Drawing.Point(113, 18);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 33);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnThem.Location = new System.Drawing.Point(12, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 33);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboMaCL);
            this.panel2.Controls.Add(this.txtGhiChu);
            this.panel2.Controls.Add(this.txtDonGiaBan);
            this.panel2.Controls.Add(this.txtDonGiaNhap);
            this.panel2.Controls.Add(this.txtSL);
            this.panel2.Controls.Add(this.txtTenH);
            this.panel2.Controls.Add(this.txtMaH);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 174);
            this.panel2.TabIndex = 1;
            // 
            // cboMaCL
            // 
            this.cboMaCL.FormattingEnabled = true;
            this.cboMaCL.Location = new System.Drawing.Point(126, 112);
            this.cboMaCL.Name = "cboMaCL";
            this.cboMaCL.Size = new System.Drawing.Size(179, 21);
            this.cboMaCL.TabIndex = 27;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(509, 116);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(179, 45);
            this.txtGhiChu.TabIndex = 25;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(509, 87);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(179, 20);
            this.txtDonGiaBan.TabIndex = 24;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(509, 61);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(179, 20);
            this.txtDonGiaNhap.TabIndex = 23;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(126, 139);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(179, 20);
            this.txtSL.TabIndex = 22;
            // 
            // txtTenH
            // 
            this.txtTenH.Location = new System.Drawing.Point(126, 87);
            this.txtTenH.Name = "txtTenH";
            this.txtTenH.Size = new System.Drawing.Size(179, 20);
            this.txtTenH.TabIndex = 21;
            // 
            // txtMaH
            // 
            this.txtMaH.Location = new System.Drawing.Point(126, 61);
            this.txtMaH.Name = "txtMaH";
            this.txtMaH.Size = new System.Drawing.Size(179, 20);
            this.txtMaH.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(376, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(11, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(376, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Đơn giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(376, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Đơn giá nhập ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(11, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã chất liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(197, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH MỤC HÀNG HÓA";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangHoa.Location = new System.Drawing.Point(0, 174);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(818, 247);
            this.dgvHangHoa.TabIndex = 2;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 491);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHangHoa";
            this.Text = "Danh mục hàng hóa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTenH;
        private System.Windows.Forms.TextBox txtMaH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnHienDS;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cboMaCL;
        private System.Windows.Forms.Button btnTimKiem;
    }
}