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
    public partial class QuanLyThanhVien : UserControl
    {
        BUS_DocGia docgia = new BUS_DocGia();
        public QuanLyThanhVien()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            txtMa.Visible = true;
            Random rdm = new Random();
            dg.MaDocGia = rdm.Next(0, 1000).ToString();
            dg.TenDangNhap = txtTenDN.Text;
            dg.HoTen = txtHoTen.Text;
            dg.DiaChi = txtDiaChi.Text;
            if (rNam.Checked == true)
                dg.GioiTinh = "Nam  ";
            else if (rNu.Checked == true)
                dg.GioiTinh = "Nữ   ";
            dg.NamSinh = dateTimePicker1.Value.Date;
            if (docgia.Them(dg) == true)

            {
                MessageBox.Show("Thêm thành công");
                QuanLyThanhVien_Load(sender, e);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }


        }
        void loadDtgvGV2()
        {
            dataGridView1.DataSource = docgia.GetList();
            dataGridView1.Columns[0].HeaderText = "Mã độc giả";
            dataGridView1.Columns[1].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns[2].HeaderText = "Họ tên";
            dataGridView1.Columns[3].HeaderText = "Giới tính";
            dataGridView1.Columns[4].HeaderText = "Ngày sinh";
            dataGridView1.Columns[5].HeaderText = "Địa chỉ";
        }

        private void QuanLyThanhVien_Load(object sender, EventArgs e)
        {
            loadDtgvGV2();
        }
        private void ResetGridview()
        {
            txtMa.ResetText();
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            rNam.Checked = false;
            rNu.Checked = false;
            dateTimePicker1.ResetText();
            txtTenDN.ResetText();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txtTenDN.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtHoTen.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            if (Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value) == "Nam  ")
            {
                rNam.Checked = true;
            }
            else
            {
                rNu.Checked = true;
            }
            dateTimePicker1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            txtDiaChi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            dg.MaDocGia = txtMa.Text;
            dg.TenDangNhap = txtTenDN.Text;
            dg.HoTen = txtHoTen.Text;
            dg.DiaChi = txtDiaChi.Text;
            if (rNam.Checked == true)
                dg.GioiTinh = "Nam  ";
            else if (rNu.Checked == true)
                dg.GioiTinh = "Nữ   ";
            dg.NamSinh = dateTimePicker1.Value.Date;
            if (docgia.Sua(dg) == true)

            {
                MessageBox.Show("Sửa thành công");
                QuanLyThanhVien_Load(sender, e);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMa.Text != "")
            {
                docgia.Xoa(txtMa.Text);
                ResetGridview();
                QuanLyThanhVien_Load(sender, e);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                loadDtgvGV2();
            }
            else
            {
                dataGridView1.DataSource = docgia.TimKiem(txtTimKiem.Text);

                dataGridView1.Columns[0].HeaderText = "Mã độc giả";
                dataGridView1.Columns[1].HeaderText = "Tên đăng nhập";
                dataGridView1.Columns[2].HeaderText = "Họ tên";
                dataGridView1.Columns[3].HeaderText = "Giới tính";
                dataGridView1.Columns[4].HeaderText = "Ngày sinh";
                dataGridView1.Columns[5].HeaderText = "Địa chỉ";
            }
        }

    }
}
