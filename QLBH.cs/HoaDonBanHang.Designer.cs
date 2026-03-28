namespace BTL_XDCTQuanLyBanHang
{
    partial class frmHoaDonBan
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
            this.label18 = new System.Windows.Forms.Label();
            this.cboMaHDTK = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbSdt = new System.Windows.Forms.MaskedTextBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboMaH = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.cboMaHDTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 33);
            this.panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTimKiem.Location = new System.Drawing.Point(323, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(83, 25);
            this.btnTimKiem.TabIndex = 26;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.OrangeRed;
            this.label18.Location = new System.Drawing.Point(12, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 17);
            this.label18.TabIndex = 26;
            this.label18.Text = "Mã hóa đơn";
            // 
            // cboMaHDTK
            // 
            this.cboMaHDTK.FormattingEnabled = true;
            this.cboMaHDTK.Location = new System.Drawing.Point(98, 6);
            this.cboMaHDTK.Name = "cboMaHDTK";
            this.cboMaHDTK.Size = new System.Drawing.Size(207, 21);
            this.cboMaHDTK.TabIndex = 3;
            this.cboMaHDTK.DropDown += new System.EventHandler(this.cboMaHDTK_DropDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 176);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(213, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbSdt);
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboMaKH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // mtbSdt
            // 
            this.mtbSdt.Location = new System.Drawing.Point(497, 98);
            this.mtbSdt.Name = "mtbSdt";
            this.mtbSdt.Size = new System.Drawing.Size(200, 20);
            this.mtbSdt.TabIndex = 21;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(112, 45);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayBan.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(375, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Điện thoại";
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(497, 19);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(200, 21);
            this.cboMaKH.TabIndex = 2;
            this.cboMaKH.SelectedIndexChanged += new System.EventHandler(this.cboMaKH_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(375, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Địa chỉ";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(112, 71);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(200, 21);
            this.cboMaNV.TabIndex = 1;
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(375, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(375, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ngày bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã hóa đơn";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(497, 71);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(497, 45);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(200, 20);
            this.txtTenKH.TabIndex = 5;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(112, 98);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(200, 20);
            this.txtTenNV.TabIndex = 2;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(112, 19);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(200, 20);
            this.txtMaHD.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 345);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHoaDon);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 345);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 89);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(745, 168);
            this.dgvHoaDon.TabIndex = 3;
            this.dgvHoaDon.DoubleClick += new System.EventHandler(this.dgvHoaDon_DoubleClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblBangChu);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.txtTongTien);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 257);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(745, 47);
            this.panel6.TabIndex = 2;
            // 
            // lblBangChu
            // 
            this.lblBangChu.AutoSize = true;
            this.lblBangChu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangChu.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblBangChu.Location = new System.Drawing.Point(9, 25);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(69, 17);
            this.lblBangChu.TabIndex = 24;
            this.lblBangChu.Text = "Bằng chữ :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.OrangeRed;
            this.label17.Location = new System.Drawing.Point(491, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 17);
            this.label17.TabIndex = 25;
            this.label17.Text = "Tổng tiền";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.OrangeRed;
            this.label15.Location = new System.Drawing.Point(9, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Nháy đúp một dòng để xóa";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(574, 6);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(131, 20);
            this.txtTongTien.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.cboMaH);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtThanhTien);
            this.panel5.Controls.Add(this.txtTenHang);
            this.panel5.Controls.Add(this.txtDonGia);
            this.panel5.Controls.Add(this.txtSoLuong);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(745, 73);
            this.panel5.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.OrangeRed;
            this.label14.Location = new System.Drawing.Point(248, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Tên hàng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.OrangeRed;
            this.label13.Location = new System.Drawing.Point(491, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Thành tiền";
            // 
            // cboMaH
            // 
            this.cboMaH.FormattingEnabled = true;
            this.cboMaH.Location = new System.Drawing.Point(79, 8);
            this.cboMaH.Name = "cboMaH";
            this.cboMaH.Size = new System.Drawing.Size(143, 21);
            this.cboMaH.TabIndex = 0;
            this.cboMaH.SelectedIndexChanged += new System.EventHandler(this.cboMaH_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(248, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Đơn giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(9, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(9, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Mã hàng";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(574, 12);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(131, 20);
            this.txtThanhTien.TabIndex = 15;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(320, 11);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(143, 20);
            this.txtTenHang.TabIndex = 14;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(320, 38);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(143, 20);
            this.txtDonGia.TabIndex = 13;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(80, 38);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(142, 20);
            this.txtSoLuong.TabIndex = 12;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDong);
            this.panel4.Controls.Add(this.btnLuu);
            this.panel4.Controls.Add(this.btnHuy);
            this.panel4.Controls.Add(this.btnIn);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 304);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(745, 38);
            this.panel4.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Location = new System.Drawing.Point(607, 7);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(116, 24);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnLuu.Location = new System.Drawing.Point(155, 7);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 24);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "&Lưu hóa đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnHuy.Location = new System.Drawing.Point(306, 7);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(116, 24);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "&Hủy hóa đơn";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnIn.Location = new System.Drawing.Point(452, 7);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(116, 24);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "&In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnThem.Location = new System.Drawing.Point(12, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 24);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "&Thêm hóa đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDonBan";
            this.Text = "Hóa đơn bán";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoaDonBan_FormClosing);
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.ComboBox cboMaHDTK;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.ComboBox cboMaH;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBangChu;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox mtbSdt;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
    }
}