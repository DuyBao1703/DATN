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
    public partial class FrmKhachHang : Form
    {
      
        public FrmKhachHang()
        {
            InitializeComponent();
        }


        KhachHang_BUS bus = new KhachHang_BUS();

        string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";  // Set your SQL connection string here
      
    
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = bus.GetAllKhachHang();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang()
            {
                MaKH = txtMaKH.Text,
                TenKhachHang = txtTenKH.Text,
                SoDienThoai = txtSoDT.Text,
                DiaChi = txtDiaChi.Text,
                CCCD = txtCCCD.Text,
                GioiTinh = cbGioiTinh.Text
            };

            if (bus.AddKhachHang(kh))
            {
                MessageBox.Show("Thêm thành công");
                dgvKhachHang.DataSource = bus.GetAllKhachHang();
            }
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang()
            {
                MaKH = txtMaKH.Text,
                TenKhachHang = txtTenKH.Text,
                SoDienThoai = txtSoDT.Text,
                DiaChi = txtDiaChi.Text,
                CCCD = txtCCCD.Text,
                GioiTinh = cbGioiTinh.Text
            };

            if (bus.UpdateKhachHang(kh))
            {
                MessageBox.Show("Cập nhật thành công");
                dgvKhachHang.DataSource = bus.GetAllKhachHang();
            }
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            if (bus.DeleteKhachHang(txtMaKH.Text))
            {
                MessageBox.Show("Xóa thành công");
                dgvKhachHang.DataSource = bus.GetAllKhachHang();
            }
        }

        private void btnHienThiKhachHang_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = bus.GetAllKhachHang();
        }

        private void dgvHangXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtSoDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
                cbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
            }
        }
    }

  
     

      

   
}
