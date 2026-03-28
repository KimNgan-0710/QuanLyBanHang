using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL_XDCTQuanLyBanHang.Class;
using COMExcel = Microsoft.Office.Interop.Excel;


namespace BTL_XDCTQuanLyBanHang
{
    public partial class frmHoaDonBan : Form
    {
        DataTable tblCTHDB;
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnIn.Enabled = false;
            txtMaHD.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            mtbSdt.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtTongTien.Text = "0";
            Functions.FillCombo("SELECT MaK, TenK FROM tblKhachHang", cboMaKH, "MaK", "MaK");
            cboMaKH.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaNV, TenNV FROM tblNhanVien", cboMaNV, "MaNV", "MaNV");
            cboMaNV.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaH, TenH FROM tblHangHoa", cboMaH, "MaH", "MaH");
            cboMaH.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMaHD.Text != "")
            {
                LoadInfoHoaDon();
                btnHuy.Enabled = true;
                btnIn.Enabled = true;
            }
            LoadDataGridView();
        }
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayBan FROM tblHDBan WHERE MaHDBan = N'" + txtMaHD.Text + "'";
            dtpNgayBan.Value = DateTime.Parse(Functions.GetFieldValues(str));
            str = "SELECT MaNV FROM tblHDBan WHERE MaHDBan = N'" + txtMaHD.Text + "'";
            cboMaNV.SelectedValue = Functions.GetFieldValues(str);
            str = "SELECT MaK FROM tblHDBan WHERE MaHDBan = N'" + txtMaHD.Text + "'";
            cboMaKH.SelectedValue = Functions.GetFieldValues(str);
            str = "SELECT TongTien FROM tblHDBan WHERE MaHDBan = N'" + txtMaHD.Text + "'";
            txtTongTien.Text = Functions.GetFieldValues(str);
            lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(txtTongTien.Text));
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaH, b.TenH, a.SoLuong, b.DonGiaBan,a.ThanhTien FROM tblChiTietHDBan AS a, tblHangHoa AS b WHERE a.MaHDBan = N'" + txtMaHD.Text + "' AND a.MaH=b.MaH";
            tblCTHDB = Functions.GetDataToTable(sql);
            dgvHoaDon.DataSource = tblCTHDB;
            dgvHoaDon.Columns[0].HeaderText = "Mã hàng";
            dgvHoaDon.Columns[1].HeaderText = "Tên hàng";
            dgvHoaDon.Columns[2].HeaderText = "Số lượng";
            dgvHoaDon.Columns[3].HeaderText = "Đơn giá";
            dgvHoaDon.Columns[4].HeaderText = "Thành tiền";
            dgvHoaDon.Columns[0].Width = 80;
            dgvHoaDon.Columns[1].Width = 130;
            dgvHoaDon.Columns[2].Width = 80;
            dgvHoaDon.Columns[3].Width = 90;
            dgvHoaDon.Columns[4].Width = 90;
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = true;
            btnIn.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHD.Text = Functions.CreateKey("HDB");
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtMaHD.Text = "";
            dtpNgayBan.Value = DateTime.Now;
            cboMaNV.Text = "";
            cboMaKH.Text = "";
            txtTongTien.Text = "0";
            lblBangChu.Text = "Bằng chữ: ";
            cboMaH.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "0";
        }
        
       

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaHDBan FROM tblHDBan WHERE MaHDBan=N'" + txtMaHD.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                
                if (cboMaNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNV.Focus();
                    return;
                }
                if (cboMaKH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaKH.Focus();
                    return;
                }
                sql = "INSERT INTO tblHDBan(MaHDBan, MaNV, NgayBan, MaK, TongTien) VALUES (N'" + txtMaHD.Text.Trim() + "', N'" + cboMaNV.SelectedValue + "','" +
                        dtpNgayBan.Value + "',,N'" + cboMaKH.SelectedValue + "'," + txtTongTien.Text + ")";
                Functions.RunSQL(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cboMaH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaH.Focus();
                return;
            }
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            
            sql = "SELECT MaH FROM tblChiTietHDBan WHERE MaH=N'" + cboMaH.SelectedValue + "' AND MaHDBan = N'" + txtMaHD.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboMaH.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblHangHoa WHERE MaH = N'" + cboMaH.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            sql = "INSERT INTO tblChiTietHDBan(MaHDBan,MaH,SoLuong,DonGia,ThanhTien) VALUES(N'" + txtMaHD.Text.Trim() + "',N'" + cboMaH.SelectedValue + "'," + txtSoLuong.Text + "," + txtDonGia.Text + "," + txtThanhTien.Text + ")";
            Functions.RunSQL(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UPDATE tblHangHoa SET SoLuong =" + SLcon + " WHERE MaH= N'" + cboMaH.SelectedValue + "'";
            Functions.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán

            //LỖI LƯU HÓA ĐƠN TẠI ĐÂY
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM tblHDBan WHERE MaHDBan = N'" + txtMaHD.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
            sql = "UPDATE tblHDBan SET TongTien =" + Tongmoi + " WHERE MaHDBan = N'" + txtMaHD.Text + "'";
            Functions.RunSQL(sql);
            txtTongTien.Text = Tongmoi.ToString();
            lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(Tongmoi.ToString()));
            ResetValuesHang();
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnIn.Enabled = true;
            
            
        } 
        private void ResetValuesHang()
        {
            cboMaH.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "0";
        }

        private void cboMaH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaH.Text == "")
            {
                txtTenHang.Text = "";
                txtDonGia.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TenH FROM tblHangHoa WHERE MaH =N'" + cboMaH.SelectedValue + "'";
            txtTenHang.Text = Functions.GetFieldValues(str);
            str = "SELECT DonGiaBan FROM tblHangHoa WHERE MaH =N'" + cboMaH.SelectedValue + "'";
            txtDonGia.Text = Functions.GetFieldValues(str);
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaKH.Text == "")
            {
                txtTenKH.Text = "";
                txtDiaChi.Text = "";
                mtbSdt.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select TenK from tblKhachHang where MaK = N'" + cboMaKH.SelectedValue + "'";
            txtTenKH.Text = Functions.GetFieldValues(str);
            str = "Select DiaChi from tblKhachHang where MaK = N'" + cboMaKH.SelectedValue + "'";
            txtDiaChi.Text = Functions.GetFieldValues(str);
            str = "Select DienThoai from tblKhachHang where MaK= N'" + cboMaKH.SelectedValue + "'";
            mtbSdt.Text = Functions.GetFieldValues(str);
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNV.Text == "")
                txtTenNV.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select TenNV from tblNhanVien where MaNV =N'" + cboMaNV.SelectedValue + "'";
            txtTenNV.Text = Functions.GetFieldValues(str);
        }

        private void cboMaHDTK_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MaHDBan FROM tblHDBan", cboMaHDTK, "MaHDBan", "MaHDBan");
            cboMaHDTK.SelectedIndex = -1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaHDTK.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHDTK.Focus();
                return;
            }
            txtMaHD.Text = cboMaHDTK.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btnLuu.Enabled = true;
            btnLuu.Enabled = true;
            btnIn.Enabled = true;
            cboMaHDTK.SelectedIndex = -1;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet                                              
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop ...";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Thanh Xuân - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (09)72324969";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.MaHDBan, a.NgayBan, a.TongTien, b.TenK, b.DiaChi, b.DienThoai, c.TenNV FROM tblHDBan AS a, tblKhachHang AS b, tblNhanVien AS c WHERE a.MaHDBan = N'" + txtMaHD.Text + "' AND a.MaK = b.MaK AND a.MaNV = c.MaNV";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenH, a.SoLuong, b.DonGiaBan,  a.ThanhTien " +
                  "FROM tblChiTietHDBan AS a , tblHangHoa AS b WHERE a.MaHDBan = N'" +
                  txtMaHD.Text + "' AND a.MaH = b.MaH";
            tblThongtinHang = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(Double.Parse(tblThongtinHD.Rows[0][2].ToString()));
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn bán hàng";
            exApp.Visible = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaH,SoLuong FROM tblChiTietHDBan WHERE MaHDBan = N'" + txtMaHD.Text + "'";
                DataTable tblHang = Functions.GetDataToTable(sql);
                for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblHangHoa WHERE MaH = N'" + tblHang.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblHang.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE tblHangHoa SET SoLuong =" + slcon + " WHERE MaH= N'" + tblHang.Rows[hang][0].ToString() + "'";
                    Functions.RunSQL(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE tblChiTietHDBan WHERE MaHDBan=N'" + txtMaHD.Text + "'";
                Functions.RunSQL(sql);

                //Xóa hóa đơn
                sql = "DELETE tblHDBan WHERE MaHDBan=N'" + txtMaHD.Text + "'";
                Functions.RunSQL(sql);
                ResetValues();
                LoadDataGridView();
                btnHuy.Enabled = false;
                btnIn.Enabled = false;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoaDonBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void dgvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = dgvHoaDon.CurrentRow.Cells["MaH"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgvHoaDon.CurrentRow.Cells["SoLuong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvHoaDon.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql = "DELETE tblChiTietHDBan WHERE MaHDBan=N'" + txtMaHD.Text + "' AND MaH" +
                    "" +
                    "" +
                    " = N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblHangHoa WHERE MaH = N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE tblHangHoa SET SoLuong =" + slcon + " WHERE MaH= N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM tblHDBan WHERE MaHDBan = N'" + txtMaHD.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE tblHDBan SET TongTien =" + tongmoi + " WHERE MaHDBan = N'" + txtMaHD.Text + "'";
                Functions.RunSQL(sql);
                txtTongTien.Text = tongmoi.ToString();
                lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChuoi(tongmoi);
                LoadDataGridView();
            }
        }
    }
}
