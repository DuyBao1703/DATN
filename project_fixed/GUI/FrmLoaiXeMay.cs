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
    public partial class FrmLoaiXeMay : Form
    {
      
        public FrmLoaiXeMay()
        {
            InitializeComponent();
        }


        LoaiXeMay_BUS bus = new LoaiXeMay_BUS();

        string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";  // Set your SQL connection string here
      
    
        private void FrmLoaiXeMay_Load(object sender, EventArgs e)
        {
      
            dgvLoaiXe.DataSource = bus.GetAllLoaiXeMay();
        }

        private void btnThemLoaiXe_Click(object sender, EventArgs e)
        {
            LoaiXeMay lx = new LoaiXeMay()
            {
                MaLoaiXe = txtMaLoaiXe.Text,
                TenLoaiXe = txtTenLoaiXe.Text,
                MoTa = txtMoTa.Text
            };

            if (bus.AddLoaiXeMay(lx))
            {
                MessageBox.Show("Thêm thành công");
                dgvLoaiXe.DataSource = bus.GetAllLoaiXeMay();
            }
        }

        private void btnSuaLoaiXe_Click(object sender, EventArgs e)
        {
            LoaiXeMay lx = new LoaiXeMay()
            {
                MaLoaiXe = txtMaLoaiXe.Text,
                TenLoaiXe = txtTenLoaiXe.Text,
                MoTa = txtMoTa.Text
            };

            if (bus.UpdateLoaiXeMay(lx))
            {
                MessageBox.Show("Cập nhật thành công");
                dgvLoaiXe.DataSource = bus.GetAllLoaiXeMay();
            }
        }

        private void btnXoaLoaiXe_Click(object sender, EventArgs e)
        {
            if (bus.DeleteLoaiXeMay(txtMaLoaiXe.Text))
            {
                MessageBox.Show("Xóa thành công");
                dgvLoaiXe.DataSource = bus.GetAllLoaiXeMay();
            }
        }

        private void btnHienThiLoaiXe_Click(object sender, EventArgs e)
        {
            dgvLoaiXe.DataSource = bus.GetAllLoaiXeMay();
        }

        private void dgvHangXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaLoaiXe.Text = dgvLoaiXe.Rows[e.RowIndex].Cells["MaLoaiXe"].Value.ToString();
                txtTenLoaiXe.Text = dgvLoaiXe.Rows[e.RowIndex].Cells["TenLoaiXe"].Value.ToString();
                txtMoTa.Text = dgvLoaiXe.Rows[e.RowIndex].Cells["MoTa"].Value?.ToString();
            }
        }
    }

  
     

      

   
}
