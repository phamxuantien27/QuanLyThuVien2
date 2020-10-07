using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLyThuVien
{
    public partial class MatKhau : UserControl
    {
        BUS_MatKhau tv = new BUS_MatKhau();
        private string tenTK;
        public MatKhau(string tdn)
        {
            InitializeComponent();
            tenTK = tdn;
        }

        private void btnThay_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != null && txtMK.Text != null && txtMk2.Text != null)
            {
                if (txtMK.Text == txtMk2.Text)
                {
                    ThanhVien t = new ThanhVien();
                    t.TenDangNhap = txtTaiKhoan.Text;
                    t.MatKhau = txtMK.Text;
                    tv.DoiMatKhau(t);
                    MessageBox.Show("Thay đổi thành công");
                }
                else
                {
                    MessageBox.Show("mật khẩu nhập lại không giống nhau!!!");
                }
            }
            else
            {
                MessageBox.Show("Thay đổi không thành công");
            }
        }

      
    }
}
