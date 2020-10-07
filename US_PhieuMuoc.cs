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
    public partial class US_PhieuMuoc : UserControl
    {
        BUS_PhieuMuon BUS_PhieuMuon = new BUS_PhieuMuon();
   
        
        public US_PhieuMuoc()
        {
            InitializeComponent();
        }

        void load()
        {
            dataGridView1.DataSource = BUS_PhieuMuon.GetList();

        }
        private void US_PhieuMuon_Load(object sender, EventArgs e)
        {
            load();
            labelThongbao1.Visible = false;
            lbThongbao2.Visible = false;
            lbThongbao3.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lbThongbao2.Visible = false;
            if (BUS_PhieuMuon.CheckExist("DOCGIA", txtMaDocGia.Text) == true && BUS_PhieuMuon.CheckExist("SACH", txtMaSach.Text) == true)
            {

                PhieuMuon _pM = new PhieuMuon();

                Random rdm = new Random();
                _pM.MaPhieu = rdm.Next(0, 1000).ToString();

                _pM.MaDocGia = txtMaDocGia.Text;
                _pM.MaSach = txtMaSach.Text;

                if (dateMuon.Text == "")
                    _pM.NgayMuon = DateTime.Now;
                else
                    _pM.NgayMuon = dateMuon.Value.Date;
                if (dateTra.Text == "")
                    _pM.NgayPhaiTra = DateTime.Now;
                else
                    _pM.NgayPhaiTra = dateTra.Value.Date;

                int check = BUS_PhieuMuon.Them(_pM);
                if (check == -1)
                    lbThongbao3.Visible = true;
                else
                    US_PhieuMuon_Load(sender, e);
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
            dateTra.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "")
            {
                if (BUS_PhieuMuon.CheckExist("DOCGIA", txtMaDocGia.Text) == true && BUS_PhieuMuon.CheckExist("SACH", txtMaSach.Text) == true)
                {
                    PhieuMuon _pM = new PhieuMuon();
                    _pM.MaDocGia = txtMaDocGia.Text;
                    _pM.MaSach = txtMaSach.Text;
                    _pM.MaPhieu = txtMa.Text;

                    if (dateMuon.Text == "")
                        _pM.NgayMuon = DateTime.Now;
                    else
                        _pM.NgayMuon = dateMuon.Value.Date;
                    if (dateTra.Text == "")
                        _pM.NgayPhaiTra = DateTime.Now;
                    else
                        _pM.NgayPhaiTra = dateTra.Value.Date;

                    BUS_PhieuMuon.Sua(_pM);
                    US_PhieuMuon_Load(sender, e);
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
                BUS_PhieuMuon.Xoa(txtMa.Text);
                ResetGridview();
                US_PhieuMuon_Load(sender, e);
            }
        }
        void ResetGridview()
        {
            txtMa.ResetText();
            txtMaDocGia.ResetText();
            txtMaSach.ResetText();
            dateTra.ResetText();
            dateMuon.ResetText();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                dataGridView1.DataSource = BUS_PhieuMuon.GetList();

            }
            else
            {
                if (rMaPhieu.Checked == true)
                    dataGridView1.DataSource = BUS_PhieuMuon.TimKiem(txtTim.Text, "MaSach");
                else if (rMaDocGia.Checked == true)
                    dataGridView1.DataSource = BUS_PhieuMuon.TimKiem(txtTim.Text, "MaDocGia");
                else if (rNgayMuon.Checked == true)
                    dataGridView1.DataSource = BUS_PhieuMuon.TimKiem(txtTim.Text, "NgayMuon");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetGridview();
        }
    }
}
