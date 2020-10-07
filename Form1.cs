using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace QuanLyThuVien
{
    public partial class Form1 : Form
    {
        BUS_ThanhVien tvBus = new BUS_ThanhVien();
        string quyen;
        public Form1()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            btnDangKi.Visible = false;
            //paneDangKy.Visible = true;

            if (tvBus.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == true)
            {
               
                FormMain f = new FormMain();
                f.Tdn = txtTaiKhoan.Text;
              
                //txtTaiKhoan.ResetText();
                txtMatKhau.ResetText();
                this.Hide();
                f.ShowDialog();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
