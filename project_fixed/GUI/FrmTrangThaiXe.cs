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
    public partial class FrmTrangThaiXe : Form
    {
        TrangThaiXe_BUS bus = new TrangThaiXe_BUS();

        public FrmTrangThaiXe()
        {
            InitializeComponent();
        }


        string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True"; // Set your SQL connection string here


        private void FrmTrangThaiXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Xuong_QuanLyXeMayLiteDataSet5.ChucVu' table. You can move, or remove it, as needed.

            dgvTrangThaiXe.DataSource = bus.GetAllTrangThaiXe();
        }

        private void btnThemTrangThai_Click(object sender, EventArgs e)
        {
            TrangThaiXe tt = new TrangThaiXe()
            {
                MaTrangThaiXe = txtMaTrangThai.Text,
                TenTrangThaiXe = txtTenTrangThai.Text,
                GhiChu = txtGhiChu.Text
            };

            if (bus.AddTrangThaiXe(tt))
            {
                MessageBox.Show("Thêm thành công");
                dgvTrangThaiXe.DataSource = bus.GetAllTrangThaiXe();
            }
        }

        private void btnSuaTrangThai_Click(object sender, EventArgs e)
        {
            TrangThaiXe tt = new TrangThaiXe()
            {
                MaTrangThaiXe = txtMaTrangThai.Text,
                TenTrangThaiXe = txtTenTrangThai.Text,
                GhiChu = txtGhiChu.Text
            };

            if (bus.UpdateTrangThaiXe(tt))
            {
                MessageBox.Show("Cập nhật thành công");
                dgvTrangThaiXe.DataSource = bus.GetAllTrangThaiXe();
            }
        }

        private void btnXoaTrangThai_Click(object sender, EventArgs e)
        {
            if (bus.DeleteTrangThaiXe(txtMaTrangThai.Text))
            {
                MessageBox.Show("Xóa thành công");
                dgvTrangThaiXe.DataSource = bus.GetAllTrangThaiXe();
            }
        }

        private void btnHienThiTrangThai_Click(object sender, EventArgs e)
        {
            dgvTrangThaiXe.DataSource = bus.GetAllTrangThaiXe();
        }

        private void dgvHangXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaTrangThai.Text = dgvTrangThaiXe.Rows[e.RowIndex].Cells["MaTrangThaiXe"].Value.ToString();
                txtTenTrangThai.Text = dgvTrangThaiXe.Rows[e.RowIndex].Cells["TenTrangThaiXe"].Value.ToString();
                txtGhiChu.Text = dgvTrangThaiXe.Rows[e.RowIndex].Cells["GhiChu"].Value?.ToString();
            }
        }
    }

  
     

      

   
}
