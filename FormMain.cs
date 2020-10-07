using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using BUS;
namespace QuanLyThuVien
{

    public partial class FormMain : Form
    {
        private Form1 fLg;
        private string tdn;
        private string quyen;
        BUS_ThanhVien tv = new BUS_ThanhVien();
        public FormMain()
        {
            InitializeComponent();
        }
       

        public string Tdn { get => tdn; set => tdn = value; }
        public string Quyen { get => quyen; set => quyen = value; }

        private void FormMain_Load(object sender, EventArgs e)
        {
            txtTentk.Text ="xin chao:"+ tdn;
            quyen = tv.Quyen(tdn);
            if(quyen=="0")
            {
                thôngTinToolStripMenuItem.Visible = false;
                lịchSửMượnSáchToolStripMenuItem.Visible = false;
                sáchĐangMượnToolStripMenuItem.Visible = false;
            }
            else
            {
                quảnLýSáchToolStripMenuItem.Visible = false;
                quảnLýThànhViênToolStripMenuItem.Visible = false;
                quảnLýPhiếuMượnToolStripMenuItem.Visible = false;
                quảnLýPhiếuTrảToolStripMenuItem.Visible = false;
                đangMượnToolStripMenuItem.Visible = false;
                đãTrảToolStripMenuItem.Visible = false;
            }
            
        }

        private void tìmKiếmSácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TimSach f = new TimSach();
            panel1.Controls.Add(f);
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ThongTin thongTin = new ThongTin(tdn);
            panel1.Controls.Add(thongTin);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MatKhau f = new MatKhau(tdn);
            panel1.Controls.Add(f);        
        }

        private void quảnLýThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QuanLyThanhVien f = new QuanLyThanhVien();
            panel1.Controls.Add(f);
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QuanLySach f = new QuanLySach();
            panel1.Controls.Add(f);
        }

        private void quảnLýPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            US_PhieuMuoc f = new US_PhieuMuoc();
            panel1.Controls.Add(f);
        }

        private void quảnLýPhiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            US_PhieuTra f = new US_PhieuTra();
            panel1.Controls.Add(f);
        }

        private void đangMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_DangMuon f = new UC_DangMuon();
            panel1.Controls.Add(f);
        }

        private void đãTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_DaTra f = new UC_DaTra();
            panel1.Controls.Add(f);
        }

        private void sáchĐangMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UC_SachDangMuon thongTin = new UC_SachDangMuon(tdn);
            panel1.Controls.Add(thongTin);
        }

        private void lịchSửMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            US_LSMuon thongTin = new US_LSMuon(tdn);
            panel1.Controls.Add(thongTin);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }
    }
}
