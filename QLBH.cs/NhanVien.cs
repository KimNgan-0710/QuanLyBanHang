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

namespace BTL_XDCTQuanLyBanHang
{
    public partial class frmNhanVien : Form
    {
        private DataTable tblNV;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblNhanVien";
            tblNV = Functions.GetDataToTable(sql); 
            dgvNhanVien.DataSource = tblNV;
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[4].HeaderText = "Điện thoại";
            dgvNhanVien.Columns[5].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[0].Width = 100;
            dgvNhanVien.Columns[1].Width = 150;
            dgvNhanVien.Columns[2].Width = 100;
            dgvNhanVien.Columns[3].Width = 150;
            dgvNhanVien.Columns[4].Width = 100;
            dgvNhanVien.Columns[5].Width = 100;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            if (dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam") cbGioiTinh.Checked = true;
            else cbGioiTinh.Checked = false;
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtbSdt.Text = dgvNhanVien.CurrentRow.Cells["DienThoai"].Value.ToString();
            dtpNgaySinh.Value = (DateTime)dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
        }
        private void ResetValues()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cbGioiTinh.Checked = false;
            txtDiaChi.Text = "";
            mtbSdt.Text = "";
            dtpNgaySinh.Text = "";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mtbSdt.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbSdt.Focus();
                return;
            }

            if (cbGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaNV FROM tblNhanVien WHERE MaNV=N'" + txtMaNV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                txtMaNV.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhanVien(MaNV,TenNV,GioiTinh, DiaChi,DienThoai, NgaySinh) VALUES (N'" + txtMaNV.Text.Trim() + "',N'" + txtTenNV.Text.Trim() + "',N'" + gt + "',N'" + txtDiaChi.Text.Trim() + "','" + mtbSdt.Text + "','" + dtpNgaySinh.Value + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mtbSdt.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbSdt.Focus();
                return;
            }
            if (cbGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            //UPDATE [tenbang] SET [tencot]
            sql = "UPDATE tblNhanVien SET  TenNV=N'" + txtTenNV.Text.Trim().ToString() +
                    "',DiaChi=N'" + txtDiaChi.Text.Trim().ToString() +
                    "',DienThoai='" + mtbSdt.Text.ToString() + "',GioiTinh=N'" + gt +
                    "',NgaySinh='" + dtpNgaySinh.Value +
                    "' WHERE MaNV=N'" + txtMaNV.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanVien WHERE MaNV=N'" + txtMaNV.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
