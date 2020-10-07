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
namespace QuanLyThuVien
{
    public partial class TimSach : UserControl
    {
        BUS_Sach bs = new BUS_Sach();
        public TimSach()
        {
            InitializeComponent();
        }

        private void TimSach_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bs.GetList();
        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
            if (txtTimSach.Text == "")
            {
                dataGridView1.DataSource = bs.GetList();

            }
            else
            {
                if (rMa.Checked == true)
                    dataGridView1.DataSource = bs.TimKiem(txtTimSach.Text, "MaSach");
                else if (rNXB.Checked == true)
                    dataGridView1.DataSource = bs.TimKiem(txtTimSach.Text, "NhaXuatBan");
                else if (rTacGia.Checked == true)
                    dataGridView1.DataSource = bs.TimKiem(txtTimSach.Text, "TacGia");
                else if (rTenSach.Checked == true)
                    dataGridView1.DataSource = bs.TimKiem(txtTimSach.Text, "TenSach");
                else if (rTheLoai.Checked == true)
                    dataGridView1.DataSource = bs.TimKiem(txtTimSach.Text, "TheLoai");
                else if (rTinhtrang.Checked == true)
                    dataGridView1.DataSource = bs.TimKiem(txtTimSach.Text, "TinhTrang");
            }
        }
    }
}
