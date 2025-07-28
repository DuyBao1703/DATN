using BUS_DATN;
using DTO_DATN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI_DATN
{
    public partial class FrmHoaDon : Form
    {

        public FrmHoaDon()
        {
            InitializeComponent();
        }


      HoaDon_BUS bus = new HoaDon_BUS();
        string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";

        private void LoadComboNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaNV, TenNV FROM NhanVien", connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaNV.DataSource = dt;
            cbMaNV.DisplayMember = "TenNV";
            cbMaNV.ValueMember = "MaNV";
        }

        private void LoadComboKhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaKH, TenKhachHang FROM KhachHang", connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaKH.DataSource = dt;
            cbMaKH.DisplayMember = "TenKhachHang";
            cbMaKH.ValueMember = "MaKH";
        }
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Xuong_QuanLyXeMayLiteDataSet5.ChucVu' table. You can move, or remove it, as needed.

            dgvHoaDon.DataSource = bus.GetAllHoaDon();
            LoadComboNhanVien();
            LoadComboKhachHang();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon()
            {
                MaHD = txtMaHD.Text,
                MaNV = cbMaNV.SelectedValue.ToString(),
                MaKH = cbMaKH.SelectedValue.ToString(),
                NgayBan = dtpNgayBan.Value,
                NgayTao = dtpNgayTao.Value
            };

            if (bus.AddHoaDon(hd))
            {
                MessageBox.Show("Thêm thành công!");
                dgvHoaDon.DataSource = bus.GetAllHoaDon();
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon()
            {
                MaHD = txtMaHD.Text,
                MaNV = cbMaNV.SelectedValue.ToString(),
                MaKH = cbMaKH.SelectedValue.ToString(),
                NgayBan = dtpNgayBan.Value,
                NgayTao = dtpNgayTao.Value
            };

            if (bus.UpdateHoaDon(hd))
            {
                MessageBox.Show("Cập nhật thành công!");
                dgvHoaDon.DataSource = bus.GetAllHoaDon();
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (bus.DeleteHoaDon(txtMaHD.Text))
            {
                MessageBox.Show("Xóa thành công!");
                dgvHoaDon.DataSource = bus.GetAllHoaDon();
            }
        }

        private void btnHienThiNhanVien_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = bus.GetAllHoaDon();
            LoadComboNhanVien();
            LoadComboKhachHang();
        }

        private void dgvHangXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells["MaHD"].Value.ToString();
                cbMaNV.SelectedValue = row.Cells["MaNV"].Value.ToString();
                cbMaKH.SelectedValue = row.Cells["MaKH"].Value.ToString();
                dtpNgayBan.Value = Convert.ToDateTime(row.Cells["NgayBan"].Value);
                dtpNgayTao.Value = Convert.ToDateTime(row.Cells["NgayTao"].Value);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            FrmChiTietHoaDon a = new FrmChiTietHoaDon();
            a.ShowDialog();
        }
    }

  
     

      

   
}
