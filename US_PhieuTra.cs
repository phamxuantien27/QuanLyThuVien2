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
    public partial class US_PhieuTra : UserControl
    {
        BUS_PhieuTra phieuTra = new BUS_PhieuTra();
        public US_PhieuTra()
        {
            InitializeComponent();
        }

        private void US_PhieuTra_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = phieuTra.GetList();
            labelThongbao1.Visible = false;
            lbThongbao2.Visible = false;
            lbThongbao3.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lbThongbao2.Visible = false;
            if (phieuTra.CheckExist("DOCGIA", txtMaDocGia.Text) == true && phieuTra.CheckExist("SACH", txtMaSach.Text) == true)
            {
                PhieuTra _pt = new PhieuTra();
                _pt.MaDocGia = txtMaDocGia.Text;
                _pt.MaSach = txtMaSach.Text;

                Random rdm = new Random();
                _pt.MaPhieu = rdm.Next(0, 1000).ToString();

                if (dateMuon.Text == "")
                    _pt.NgayTra = DateTime.Now;
                else
                    _pt.NgayTra = dateMuon.Value.Date;

                int check = phieuTra.Them(_pt);
                if (check == -1)
                    lbThongbao3.Visible = true;
                else
                    US_PhieuTra_Load(sender, e);
            }
            else
            {
                lbThongbao2.Visible = false;
                labelThongbao1.Visible = true;
                lbThongbao3.Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txtMaDocGia.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtMaSach.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            dateMuon.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "")
            {
                if (phieuTra.CheckExist("DOCGIA", txtMaDocGia.Text) == true && phieuTra.CheckExist("SACH", txtMaSach.Text) == true)
                {
                    PhieuTra _pM = new PhieuTra();
                    _pM.MaDocGia = txtMaDocGia.Text;
                    _pM.MaSach = txtMaSach.Text;
                    _pM.MaPhieu = txtMa.Text;

                    if (dateMuon.Text == "")
                        _pM.NgayTra = DateTime.Now;
                    else
                        _pM.NgayTra = dateMuon.Value.Date;
                    

                    phieuTra.Sua(_pM);
                    US_PhieuTra_Load(sender, e);
                }
                else
                {
                    lbThongbao2.Visible = true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "")
            {
                phieuTra.Xoa(txtMa.Text);
                ResetGridview();
                US_PhieuTra_Load(sender, e);
            }
        }
        void ResetGridview()
        {
            txtMa.ResetText();
            txtMaDocGia.ResetText();
            txtMaSach.ResetText();
          
            dateMuon.ResetText();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                dataGridView1.DataSource = phieuTra.GetList();

            }
            else
            {
                if (rMaPhieu.Checked == true)
                    dataGridView1.DataSource = phieuTra.TimKiem(txtTim.Text, "MaSach");
                else if (rMaDocGia.Checked == true)
                    dataGridView1.DataSource = phieuTra.TimKiem(txtTim.Text, "MaDocGia");
                else if (rNgayMuon.Checked == true)
                    dataGridView1.DataSource = phieuTra.TimKiem(txtTim.Text, "NgayTra");
            }
        }
    }
}
