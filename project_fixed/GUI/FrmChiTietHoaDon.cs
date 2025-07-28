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
    public partial class FrmChiTietHoaDon : Form
    {

        public FrmChiTietHoaDon()
        {
            InitializeComponent();
        }


        ChiTietHoaDon_BUS bus = new ChiTietHoaDon_BUS();
        string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";

        private void LoadComboMaHD()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaHD FROM HoaDon", connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaHD.DataSource = dt;
            cbMaHD.DisplayMember = "MaHD";
            cbMaHD.ValueMember = "MaHD";
        }

        private void LoadComboMaXe()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaXe, TenXe FROM XeMay", connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaXe.DataSource = dt;
            cbMaXe.DisplayMember = "TenXe";
            cbMaXe.ValueMember = "MaXe";
        }
        private void FrmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Xuong_QuanLyXeMayLiteDataSet5.ChucVu' table. You can move, or remove it, as needed.

            dgvChiTietHD.DataSource = bus.GetAllChiTietHoaDon();
            LoadComboMaHD();
            LoadComboMaXe();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon ct = new ChiTietHoaDon()
            {
                MaCTHD = txtMaCTHD.Text,
                MaHD = cbMaHD.SelectedValue.ToString(),
                MaXe = cbMaXe.SelectedValue.ToString(),
                GiaBan = decimal.Parse(txtGiaBan.Text),
                SoLuong = int.Parse(txtSoLuong.Text)
            };

            if (bus.AddChiTietHoaDon(ct))
            {
                MessageBox.Show("Thêm thành công!");
                dgvChiTietHD.DataSource = bus.GetAllChiTietHoaDon();
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon ct = new ChiTietHoaDon()
            {
                MaCTHD = txtMaCTHD.Text,
                MaHD = cbMaHD.SelectedValue.ToString(),
                MaXe = cbMaXe.SelectedValue.ToString(),
                GiaBan = decimal.Parse(txtGiaBan.Text),
                SoLuong = int.Parse(txtSoLuong.Text)
            };

            if (bus.UpdateChiTietHoaDon(ct))
            {
                MessageBox.Show("Cập nhật thành công!");
                dgvChiTietHD.DataSource = bus.GetAllChiTietHoaDon();
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (bus.DeleteChiTietHoaDon(txtMaCTHD.Text))
            {
                MessageBox.Show("Xóa thành công!");
                dgvChiTietHD.DataSource = bus.GetAllChiTietHoaDon();
            }
        }

        private void btnHienThiNhanVien_Click(object sender, EventArgs e)
        {
            dgvChiTietHD.DataSource = bus.GetAllChiTietHoaDon();
            LoadComboMaHD();
            LoadComboMaXe();
        }

        private void dgvHangXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvChiTietHD.Rows[e.RowIndex];
                txtMaCTHD.Text = row.Cells["MaCTHD"].Value.ToString();
                cbMaHD.SelectedValue = row.Cells["MaHD"].Value.ToString();
                cbMaXe.SelectedValue = row.Cells["MaXe"].Value.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            }
        }
    }

  
     

      

   
}
