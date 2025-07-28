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
    public partial class FrmPhanKhoiXe : Form
    {
      
        public FrmPhanKhoiXe()
        {
            InitializeComponent();
        }


        PhanKhoiXe_BUS bus = new PhanKhoiXe_BUS();
        string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";  // Set your SQL connection string here
      
    
        private void FrmPhanKhoiXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Xuong_QuanLyXeMayLiteDataSet5.ChucVu' table. You can move, or remove it, as needed.


            dgvPhanKhoiXe.DataSource = bus.GetAllPhanKhoiXe();
        }

        private void btnThemPhanKhoi_Click(object sender, EventArgs e)
        {
            PhanKhoiXe pk = new PhanKhoiXe()
            {
                MaPhanKhoi = txtMaPhanKhoi.Text,
                DungTichCC = int.Parse(txtDungTich.Text),
                MoTa = txtMoTa.Text
            };

            if (bus.AddPhanKhoiXe(pk))
            {
                MessageBox.Show("Thêm thành công");
                dgvPhanKhoiXe.DataSource = bus.GetAllPhanKhoiXe();
            }
        }

        private void btnSuaPhanKhoi_Click(object sender, EventArgs e)
        {
            PhanKhoiXe pk = new PhanKhoiXe()
            {
                MaPhanKhoi = txtMaPhanKhoi.Text,
                DungTichCC = int.Parse(txtDungTich.Text),
                MoTa = txtMoTa.Text
            };

            if (bus.UpdatePhanKhoiXe(pk))
            {
                MessageBox.Show("Cập nhật thành công");
                dgvPhanKhoiXe.DataSource = bus.GetAllPhanKhoiXe();
            }
        }

        private void btnXoaPhanKhoi_Click(object sender, EventArgs e)
        {
            if (bus.DeletePhanKhoiXe(txtMaPhanKhoi.Text))
            {
                MessageBox.Show("Xóa thành công");
                dgvPhanKhoiXe.DataSource = bus.GetAllPhanKhoiXe();
            }
        }

        private void btnHienThiPhanKhoi_Click(object sender, EventArgs e)
        {
            dgvPhanKhoiXe.DataSource = bus.GetAllPhanKhoiXe();
        }

        private void dgvHangXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaPhanKhoi.Text = dgvPhanKhoiXe.Rows[e.RowIndex].Cells["MaPhanKhoi"].Value.ToString();
                txtDungTich.Text = dgvPhanKhoiXe.Rows[e.RowIndex].Cells["DungTichCC"].Value.ToString();
                txtMoTa.Text = dgvPhanKhoiXe.Rows[e.RowIndex].Cells["MoTa"].Value.ToString();
            }
        }

        private void dgvPhanKhoiXe_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }
    }

  
     

      

   
}
