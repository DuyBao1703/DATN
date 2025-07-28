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
    public partial class FrmXeMay : Form
    {
      
        public FrmXeMay()
        {
            InitializeComponent();
        }
        private void LoadComboMaLoai()
        {
            string query = "SELECT MaLoaiXe, TenLoaiXe FROM LoaiXeMay";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaLoai.DataSource = dt;
            cbMaLoai.DisplayMember = "TenLoaiXe";
            cbMaLoai.ValueMember = "MaLoaiXe";
        }
        private void LoadComboMaPhanKhoi()
        {
            string query = "SELECT MaPhanKhoi, DungTichCC FROM PhanKhoiXe";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaPhanKhoi.DataSource = dt;
            cbMaPhanKhoi.DisplayMember = "DungTichCC"; // Có thể là MoTa nếu bạn muốn
            cbMaPhanKhoi.ValueMember = "MaPhanKhoi";
        }

        private void LoadComboMaHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaHang, TenHang FROM HangXe";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbMaHang.DataSource = dt;
                cbMaHang.DisplayMember = "TenHang";       // Hiển thị lên cho người dùng
                cbMaHang.ValueMember = "MaHang";          // Lưu giá trị thực sự
            }
        }


        XeMay_BUS bus = new XeMay_BUS();
        string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";  // Set your SQL connection string here

        private void LoadComboMaTrangThai()
        {
            string query = "SELECT MaTrangThaiXe, TenTrangThaiXe FROM TrangThaiXe";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaTrangThai.DataSource = dt;
            cbMaTrangThai.DisplayMember = "TenTrangThaiXe";
            cbMaTrangThai.ValueMember = "MaTrangThaiXe";
        }

        private void FrmXeMay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Xuong_QuanLyXeMayLiteDataSet5.ChucVu' table. You can move, or remove it, as needed.

            dgvXeMay.DataSource = bus.GetAllXeMay();
            LoadComboMaHang();
            LoadComboMaLoai();
            LoadComboMaPhanKhoi();
            LoadComboMaTrangThai();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            XeMay xm = new XeMay()
            {
                MaXe = txtMaXe.Text,
                TenXe = txtTenXe.Text,
                Mau = txtMau.Text,
                MaHang = cbMaHang.SelectedValue.ToString(),
                MaLoaiXe = cbMaLoai.SelectedValue.ToString(),
                GiaNhap = decimal.Parse(txtGiaNhap.Text),
                GiaBan = decimal.Parse(txtGiaBan.Text),
                SoKhung = txtSoKhung.Text,
                SoMay = txtSoMay.Text,
                HinhAnh = txtHinhAnh.Text,
                MaTrangThaiXe = cbMaTrangThai.SelectedValue.ToString(),
                MaPhanKhoi = cbMaPhanKhoi.SelectedValue.ToString()
            };

            if (bus.AddXeMay(xm))
            {
                MessageBox.Show("Thêm thành công");
                dgvXeMay.DataSource = bus.GetAllXeMay();
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            XeMay xm = new XeMay()
            {
                MaXe = txtMaXe.Text,
                TenXe = txtTenXe.Text,
                Mau = txtMau.Text,
                MaHang = cbMaHang.SelectedValue.ToString(),
                MaLoaiXe = cbMaLoai.SelectedValue.ToString(),
                GiaNhap = decimal.Parse(txtGiaNhap.Text),
                GiaBan = decimal.Parse(txtGiaBan.Text),
                SoKhung = txtSoKhung.Text,
                SoMay = txtSoMay.Text,
                HinhAnh = txtHinhAnh.Text,
                MaTrangThaiXe = cbMaTrangThai.SelectedValue.ToString(),
                MaPhanKhoi = cbMaPhanKhoi.SelectedValue.ToString()
            };

            if (bus.UpdateXeMay(xm))
            {
                MessageBox.Show("Cập nhật thành công");
                dgvXeMay.DataSource = bus.GetAllXeMay();
            }
        }
     
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (bus.DeleteXeMay(txtMaXe.Text))
            {
                MessageBox.Show("Xóa thành công");
                dgvXeMay.DataSource = bus.GetAllXeMay();
            }
        }

        private void btnHienThiNhanVien_Click(object sender, EventArgs e)
        {
            dgvXeMay.DataSource = bus.GetAllXeMay();
            LoadComboMaHang();
            LoadComboMaLoai();
            LoadComboMaPhanKhoi();
            LoadComboMaTrangThai();
        }

      

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvXeMay.Rows[e.RowIndex];
                txtMaXe.Text = row.Cells["MaXe"].Value.ToString();
                txtTenXe.Text = row.Cells["TenXe"].Value.ToString();
                txtMau.Text = row.Cells["Mau"].Value.ToString();
                cbMaHang.SelectedValue = row.Cells["MaHang"].Value.ToString();
                cbMaLoai.SelectedValue = row.Cells["MaLoaiXe"].Value.ToString();
                txtGiaNhap.Text = row.Cells["GiaNhap"].Value.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                txtSoKhung.Text = row.Cells["SoKhung"].Value.ToString();
                txtSoMay.Text = row.Cells["SoMay"].Value.ToString();
                cbMaTrangThai.SelectedValue = row.Cells["MaTrangThaiXe"].Value.ToString();
                cbMaPhanKhoi.SelectedValue = row.Cells["MaPhanKhoi"].Value.ToString();
                txtHinhAnh.Text = row.Cells["HinhAnh"].Value?.ToString();

                string path = Path.Combine(Application.StartupPath, "AnhXeMay", txtHinhAnh.Text);
                picAnh.Image = File.Exists(path) ? Image.FromFile(path) : null;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(ofd.FileName);
                txtHinhAnh.Text = fileName;

                string destPath = Path.Combine(Application.StartupPath, "AnhXeMay", fileName);
                Directory.CreateDirectory(Path.GetDirectoryName(destPath));
                File.Copy(ofd.FileName, destPath, true);
                picAnh.Image = Image.FromFile(destPath);
            }
        }
    }
}
