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
    public partial class FrmHangXe : Form
    {
      
        public FrmHangXe()
        {
            InitializeComponent();
        }


        HangXe_BUS bus = new HangXe_BUS();
        string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True"; // Set your SQL connection string here


        private void FrmHangXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Xuong_QuanLyXeMayLiteDataSet5.ChucVu' table. You can move, or remove it, as needed.

            dgvHangXe.DataSource = bus.GetAllHangXe();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            HangXe hx = new HangXe()
            {
                MaHang = txtMaHang.Text,
                TenHang = txtTenHang.Text,
                QuocGia = txtQuocGia.Text,
                NamThanhLap = int.Parse(txtNamThanhLap.Text)
            };

            if (bus.AddHangXe(hx))
            {
                MessageBox.Show("Thêm thành công");
                dgvHangXe.DataSource = bus.GetAllHangXe();
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            HangXe hx = new HangXe()
            {
                MaHang = txtMaHang.Text,
                TenHang = txtTenHang.Text,
                QuocGia = txtQuocGia.Text,
                NamThanhLap = int.Parse(txtNamThanhLap.Text)
            };

            if (bus.UpdateHangXe(hx))
            {
                MessageBox.Show("Cập nhật thành công");
                dgvHangXe.DataSource = bus.GetAllHangXe();
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (bus.DeleteHangXe(txtMaHang.Text))
            {
                MessageBox.Show("Xóa thành công");
                dgvHangXe.DataSource = bus.GetAllHangXe();
            }
        }

        private void btnHienThiNhanVien_Click(object sender, EventArgs e)
        {
            dgvHangXe.DataSource = bus.GetAllHangXe();
        }

        private void dgvHangXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaHang.Text = dgvHangXe.Rows[e.RowIndex].Cells["MaHang"].Value.ToString();
                txtTenHang.Text = dgvHangXe.Rows[e.RowIndex].Cells["TenHang"].Value.ToString();
                txtQuocGia.Text = dgvHangXe.Rows[e.RowIndex].Cells["QuocGia"].Value.ToString();
                txtNamThanhLap.Text = dgvHangXe.Rows[e.RowIndex].Cells["NamThanhLap"].Value.ToString();
            }
        }
    }

  
     

      

   
}
