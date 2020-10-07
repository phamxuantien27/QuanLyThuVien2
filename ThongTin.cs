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
    public partial class ThongTin : UserControl
    {
        private string tdn;
        BUS_ThanhVien tvBUS = new BUS_ThanhVien();
        public ThongTin(string tdn2)
        {
            InitializeComponent();
            tdn = tdn2;
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            DocGia _dg = new DocGia();
            _dg.HoTen = txtHoTen.Text;
            _dg.MaDocGia = txtMa.Text;
            _dg.TenDangNhap = txtTdn.Text;
            if (rNam.Checked == true)
                _dg.GioiTinh = "Nam  ";
            else if (rNu.Checked == true)
                _dg.GioiTinh = "Nữ   ";

            _dg.NamSinh = DateTime.Parse(dateTimePicker1.Text);

            _dg.DiaChi = txtDiaChi.Text;
            tvBUS.sua(_dg);
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            DataTable dt = tvBUS.GetThanhVien(tdn);
            txtHoTen.DataBindings.Add("Text", dt, "HoTen", true);
            txtMa.DataBindings.Add("Text", dt, "MaDocGia", true);
            txtTdn.DataBindings.Add("Text", dt, "TenDangNhap", true);
            string gt = dt.Rows[0]["GioiTinh"].ToString();
            //txt_GioiTinh.DataBindings.Add("Text", dt, "GioiTinh", true);
            if (gt == "Nữ   ")
                rNu.Checked = true;
            else if (gt == "Nam  ")
                rNam.Checked = true;
            dateTimePicker1.DataBindings.Add("Text", dt, "NamSinh", true);
            txtDiaChi.DataBindings.Add("Text", dt, "DiaChi", true);
        }

        
    }
}
