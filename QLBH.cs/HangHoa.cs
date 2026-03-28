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
    public partial class frmHangHoa : Form
    {
        DataTable tblHH;
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from tblChatLieu";
            txtMaH.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo(sql, cboMaCL, "MaCL", "TenCL");
            cboMaCL.SelectedIndex = -1;
            ResetValues();
        }
        private void ResetValues()
        {
            txtMaH.Text = "";
            txtTenH.Text = "";
            cboMaCL.Text = "";
            txtSL.Text = "0";
            txtDonGiaNhap.Text = "0";
            txtDonGiaBan.Text = "0";
            txtSL.Enabled = true;
            txtDonGiaNhap.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtGhiChu.Text = "";
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from tblHangHoa";
            tblHH = Functions.GetDataToTable(sql);
            dgvHangHoa.DataSource = tblHH;
            dgvHangHoa.Columns[0].HeaderText = "Mã hàng";
            dgvHangHoa.Columns[1].HeaderText = "Tên hàng";
            dgvHangHoa.Columns[2].HeaderText = "Chất liệu";
            dgvHangHoa.Columns[3].HeaderText = "Số lượng";
            dgvHangHoa.Columns[4].HeaderText = "Đơn giá nhập";
            dgvHangHoa.Columns[5].HeaderText = "Đơn giá bán";
            dgvHangHoa.Columns[6].HeaderText = "Ghi chú";
            dgvHangHoa.Columns[0].Width = 80;
            dgvHangHoa.Columns[1].Width = 140;
            dgvHangHoa.Columns[2].Width = 80;
            dgvHangHoa.Columns[3].Width = 80;
            dgvHangHoa.Columns[4].Width = 100;
            dgvHangHoa.Columns[5].Width = 100;
            dgvHangHoa.Columns[6].Width = 195;
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaChatLieu;
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaH.Focus();
                return;
            }
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaH.Text = dgvHangHoa.CurrentRow.Cells["MaH"].Value.ToString();
            txtTenH.Text = dgvHangHoa.CurrentRow.Cells["TenH"].Value.ToString();
            MaChatLieu = dgvHangHoa.CurrentRow.Cells["MaCL"].Value.ToString();
            sql = "SELECT TenCL FROM tblChatLieu WHERE MaCL=N'" + MaChatLieu + "'";
            cboMaCL.Text = Functions.GetFieldValues(sql);
            txtSL.Text = dgvHangHoa.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDonGiaNhap.Text = dgvHangHoa.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtDonGiaBan.Text = dgvHangHoa.CurrentRow.Cells["DonGiaBan"].Value.ToString();     
            sql = "SELECT GhiChu FROM tblHangHoa WHERE MaH = N'" + txtMaH.Text + "'";
            txtGhiChu.Text = Functions.GetFieldValues(sql);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaH.Enabled = true;
            txtMaH.Focus();
            txtSL.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaH.Focus();
                return;
            }
            if (txtTenH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenH.Focus();
                return;
            }
            if (cboMaCL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaCL.Focus();
                return;
            }
            sql = "SELECT MaH FROM tblHangHoa WHERE MaH=N'" + txtMaH.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaH.Focus();
                return;
            }
            sql = "INSERT INTO tblHangHoa(MaH,TenH,MaCL,SoLuong,DonGiaNhap, DonGiaBan,GhiChu) VALUES(N'"
                + txtMaH.Text.Trim() + "',N'" + txtTenH.Text.Trim() +
                "',N'" + cboMaCL.SelectedValue.ToString() +
                "'," + txtSL.Text.Trim() + "," + txtDonGiaNhap.Text +
                "," + txtDonGiaBan.Text + ",N'" + txtGhiChu.Text.Trim() + "')";

            Functions.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaH.Focus();
                return;
            }
            if (txtTenH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenH.Focus();
                return;
            }
            if (cboMaCL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaCL.Focus();
                return;
            }
            
            sql = "UPDATE tblHangHoa SET TenH=N'" + txtTenH.Text.Trim().ToString() +
                "',MaCL=N'" + cboMaCL.SelectedValue.ToString() +
                "',SoLuong=" + txtSL.Text +
                ",GhiChu=N'" + txtGhiChu.Text + "' WHERE MaH=N'" + txtMaH.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblHangHoa WHERE MaH=N'" + txtMaH.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaH.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaH.Text == "") && (txtTenH.Text == "") && (cboMaCL.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from tblHangHoa WHERE 1=1";
            if (txtMaH.Text != "")
                sql += " AND MaH LIKE N'%" + txtMaH.Text + "%'";
            if (txtTenH.Text != "")
                sql += " AND TenH LIKE N'%" + txtTenH.Text + "%'";
            if (cboMaCL.Text != "")
                sql += " AND MaCL LIKE N'%" + cboMaCL.SelectedValue + "%'";
            tblHH = Functions.GetDataToTable(sql);
            if (tblHH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else 
                MessageBox.Show("Có " + tblHH.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvHangHoa.DataSource = tblHH;
            ResetValues();
        
        }

        private void btnHienDS_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaH,TenH,MaCL,SoLuong,DonGiaNhap,DonGiaBan,GhiChu FROM tblHangHoa";
            tblHH = Functions.GetDataToTable(sql);
            dgvHangHoa.DataSource = tblHH;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
