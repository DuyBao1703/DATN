using BUS_DATN;
using DTO_DATN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GUI_DATN
{
    public partial class FrmQuanLyNhanVien : Form
    {
      
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
        }


        NhanVien_BUS bus = new NhanVien_BUS();
        string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";  // Set your SQL connection string here
      
    
        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Xuong_QuanLyXeMayLiteDataSet5.ChucVu' table. You can move, or remove it, as needed.

            dgvNhanVien.DataSource = bus.GetAllNhanVien();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nv = GetNhanVienFromForm();
            if (bus.AddNhanVien(nv))
            {
                MessageBox.Show("Thêm thành công");
                dgvNhanVien.DataSource = bus.GetAllNhanVien();
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nv = GetNhanVienFromForm();
            if (bus.UpdateNhanVien(nv))
            {
                MessageBox.Show("Sửa thành công");
                dgvNhanVien.DataSource = bus.GetAllNhanVien();
            }
        }
        private NhanVien GetNhanVienFromForm()
        {
            string matKhauInput = txtMatKhau.Text.Trim();
            string matKhauHash;

            // Nếu độ dài < 64 hoặc có ký tự không phải hex → chưa phải SHA256
            if (IsSha256Hash(matKhauInput))
                matKhauHash = matKhauInput;  // Đã hash rồi
            else
                matKhauHash = HashPassword(matKhauInput); // Hash nếu chưa

            return new NhanVien()
            {
                MaNV = txtMaNV.Text,
                TenNV = txtTenNV.Text,
                TenTK = txtTenTK.Text,
                MatKhauHash = matKhauHash,
                GioiTinh = cbGioiTinh.Text,
                SoDienThoai = txtSDT.Text,
                DiaChi = txtDiaChi.Text,
                VaiTro = chkVaiTro.Checked,
                Email = txtEmail.Text,
                HinhAnh = txtHinhAnh.Text
            };
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return string.Concat(bytes.Select(b => b.ToString("x2")));
            }
        }

        private bool IsSha256Hash(string input)
        {
            // SHA256 = 64 ký tự hexa
            if (input.Length != 64) return false;

            foreach (char c in input)
            {
                if (!Uri.IsHexDigit(c)) return false;
            }
            return true;
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (bus.DeleteNhanVien(txtMaNV.Text))
            {
                MessageBox.Show("Xóa thành công");
                dgvNhanVien.DataSource = bus.GetAllNhanVien();
            }
        }

        private void btnHienThiNhanVien_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = bus.GetAllNhanVien();
        }

      

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                txtTenTK.Text = row.Cells["TenTK"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhauHash"].Value.ToString();
                cbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                chkVaiTro.Checked = Convert.ToBoolean(row.Cells["VaiTro"].Value);
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtHinhAnh.Text = row.Cells["HinhAnh"].Value?.ToString();

                string tenFile = txtHinhAnh.Text;
                string path = Path.Combine(Application.StartupPath, "AnhNhanVien", tenFile);
                picAnh.Image = File.Exists(path) ? Image.FromFile(path) : null;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg;*.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string tenFile = Path.GetFileName(ofd.FileName);
                txtHinhAnh.Text = tenFile;

                string destFolder = Path.Combine(Application.StartupPath, "AnhNhanVien");
                if (!Directory.Exists(destFolder)) Directory.CreateDirectory(destFolder);

                File.Copy(ofd.FileName, Path.Combine(destFolder, tenFile), true);
                picAnh.Image = Image.FromFile(Path.Combine(destFolder, tenFile));
            }
        }
    }
}
