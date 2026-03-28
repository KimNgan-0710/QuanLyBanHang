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
    public partial class frmChatLieu : Form
    {
         DataTable tblCL;
        /*
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\winform (C#)\\BTL-XDCTQuanLyBanHang\\BTL-XDCTQuanLyBanHang\\BTL-QLBH.mdf\";Integrated Security=True ";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from tbtChatLieu";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvChatLieu.DataSource = table;
        }
        */
        public frmChatLieu()
        {
            InitializeComponent();
        }

        private void frmChatLieu_Load(object sender, EventArgs e)
        {
          //connection = new SqlConnection(str);
          //connection.Open();
          //loaddata();
            txtMaCL.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }
        
        private void LoadDataGridView()
        {
            string sql;
            sql = "select * from tblChatLieu";
            tblCL = Functions.GetDataToTable(sql);//doc du lieu tu bang
            dgvChatLieu.DataSource = tblCL;//nguon du lieu
            dgvChatLieu.Columns[0].HeaderText = "Mã chất liệu";
            dgvChatLieu.Columns[1].HeaderText = "Tên chất liệu";
            dgvChatLieu.Columns[0].Width = 100;
            dgvChatLieu.Columns[1].Width = 300;
            dgvChatLieu.AllowUserToAddRows = false;//khong cho nguoi dung them du lieu truc tiep
            dgvChatLieu.EditMode = DataGridViewEditMode.EditProgrammatically;//khong cho sua du lieu truc tiep
        }

        private void dgvChatLieu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCL.Focus();
                return;
            }
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaCL.Text = dgvChatLieu.CurrentRow.Cells["MaCL"].Value.ToString();
            txtTenCL.Text = dgvChatLieu.CurrentRow.Cells["TenCL"].Value.ToString();
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
            ResetValue(); 
            txtMaCL.Enabled = true; 
        }

        private void ResetValue()
        {
            txtMaCL.Text = "";
            txtTenCL.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; 
            if (txtMaCL.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCL.Focus();
                return;
            }
            if (txtMaCL.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCL.Focus();
                return;
            }
            sql = "Select MaCL From tblChatLieu where MaCL=N'" + txtMaCL.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCL.Focus();
                return;
            }

            sql = "INSERT INTO tblChatLieu VALUES(N'" +
               txtMaCL.Text + "',N'" + txtTenCL.Text + "')";
            Functions.RunSQL(sql); 
            LoadDataGridView(); 
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaCL.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaCL.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenCL.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblChatLieu SET TenCL=N'" +
                txtTenCL.Text.ToString() +
                "' WHERE MaCL=N'" + txtMaCL.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();

            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaCL.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblChatLieu WHERE MaCL=N'" + txtMaCL.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaCL.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
