using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QuanLyThuVien
{
  
    public partial class QuanLySach : UserControl
    {
        BUS_Sach s = new BUS_Sach();
        public QuanLySach()
        {
            InitializeComponent();
        }

        void loadDtgvGV2()
        {
            dataGridView1.DataSource = s.GetList();
            dataGridView1.Columns[0].HeaderText = "Mã sách";
            dataGridView1.Columns[1].HeaderText = "Tên sách";
            dataGridView1.Columns[2].HeaderText = "Tác giả";
            dataGridView1.Columns[3].HeaderText = "Thể loại";
            dataGridView1.Columns[4].HeaderText = "Nhà xuất bản";
            dataGridView1.Columns[5].HeaderText = "Giá";
            dataGridView1.Columns[5].HeaderText = "Số lượng";
        }
        private void QuanLySach_Load(object sender, EventArgs e)
        {
            loadDtgvGV2();
        }
        private void ResetGridview()
        {
            txtMa.ResetText();
            txtNxb.ResetText();
            txtTacGia.ResetText();
            txtGia.ResetText();
            txtTheLoai.ResetText();
            numericUpDown1.ResetText();
            txtTen.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Sach _s = new Sach();
            Random rdm = new Random();
            _s.MaSach = rdm.Next(0, 1000).ToString();
            _s.TenSach = txtTen.Text;
            _s.TacGia = txtTacGia.Text;
            _s.NhaXuatBan = txtNxb.Text;
            _s.TheLoai = txtTheLoai.Text;
            if (txtGia.Text != "")
                _s.GiaSach = int.Parse(txtGia.Text);
            _s.SoLuong = Convert.ToInt32(numericUpDown1.Value);

            //kiem tra loi madocgia
            
            if (s.Them(_s) == true)
            {
                MessageBox.Show("Thêm thành công!!!");
                QuanLySach_Load(sender, e);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!!!");
            }
            //load lai
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sach _s = new Sach();
            _s.MaSach = txtMa.Text;
            _s.TenSach = txtTen.Text;
            _s.TacGia = txtTacGia.Text;
            _s.NhaXuatBan = txtNxb.Text;
            _s.TheLoai = txtTheLoai.Text;
            if (txtGia.Text != "")
                _s.GiaSach = int.Parse(txtGia.Text);
            _s.SoLuong = Convert.ToInt32(numericUpDown1.Value);

            if (s.Sua(_s) == true)

            {
                MessageBox.Show("Sửa thành công");
                QuanLySach_Load(sender, e);
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
                s.Xoa(txtMa.Text);
                ResetGridview();
                QuanLySach_Load(sender, e);
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                loadDtgvGV2();
            }
            else
            {
                dataGridView1.DataSource = s.TimKiem(txtTimkiem.Text,"MaSach");

                dataGridView1.Columns[0].HeaderText = "Mã sách";
                dataGridView1.Columns[1].HeaderText = "Tên sách";
                dataGridView1.Columns[2].HeaderText = "Tác giả";
                dataGridView1.Columns[3].HeaderText = "Thể loại";
                dataGridView1.Columns[4].HeaderText = "Nhà xuất bản";
                dataGridView1.Columns[5].HeaderText = "Giá";
                dataGridView1.Columns[5].HeaderText = "Số lượng";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txtTen.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtTacGia.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txtTheLoai.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            txtNxb.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            txtGia.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            numericUpDown1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
        }
    }
}
