using BUS_DATN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_DATN
{
    public partial class Login : Form
    {
        //Connect cn = new Connect();
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
      
        string connectionString = "Data Source=DUYBAO;Initial Catalog=Xuong_QuanLyXeMayLite;Integrated Security=True";
        NhanVien_BUS bus = new NhanVien_BUS();
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string tenTK = txtTK.Text.Trim();
            string matKhau = txtMK.Text.Trim();

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!");
                return;
            }

            var nv = bus.DangNhap(tenTK, matKhau);
            if (nv != null)
            {
                MessageBox.Show("Đăng nhập thành công! Xin chào: " + nv.TenNV);
                this.Hide();
                frmMain f = new frmMain();
                f.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.PasswordChar = gunaCheckBox1.Checked ? '\0' : '●';
        }
    }
}