using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class DAO_ThanhVien:KetNoi
    {
        public bool login(string us, string pw)
        {
            if (GetData("select* from ACCOUNT where TenDangNhap = '" + us + "' and MatKhau = '" + pw + "'").Rows.Count > 0)
                return true;
            return false;
        }
       
        public List<ThanhVien> getTaiKhoan()
        {
            string truyvan = "SELECT * FROM ACCOUNT";
            List<ThanhVien> l = new List<ThanhVien>();
            ThanhVien a = new ThanhVien();
            DataTable dt = GetData(truyvan);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                a.TenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                a.MatKhau = dt.Rows[i]["MatKhau"].ToString();
                a.MaDocGia = dt.Rows[i]["MaDocGia"].ToString();
                a.Quyen = Convert.ToInt32(dt.Rows[i]["Quyen"].ToString());
                l.Add(a);
            }
            return l;
        }
        public bool signup(ThanhVien tv)
        {
            if (GetData("select* from ACCOUNT where TenDangNhap = '" + tv.TenDangNhap + "'").Rows.Count > 0)
                return false;
            Random rdm = new Random();
            tv.MaDocGia = rdm.Next(0, 1000).ToString();
            while (GetData("select* from ACCOUNT where MaDocGia = '" + tv.TenDangNhap + "'").Rows.Count > 0)
            {
                tv.MaDocGia = rdm.Next(0, 1000).ToString();
            }
            string sql = string.Format("Insert Into ACCOUNT values('{0}','{1}','{2}','{3}')",
                 tv.MaDocGia, tv.TenDangNhap, tv.MatKhau, 1);
            Excute(sql);
            sql = string.Format("Insert Into DOCGIA(MaDocGia, TenDangNhap) values('{0}', '{1}')", tv.MaDocGia, tv.TenDangNhap);
            Excute(sql);
            return true;
        }
        public void Update(DocGia dg)
        {
            string sql = string.Format("update DOCGIA set HoTen = N'{0}', GioiTinh = N'{1}', NamSinh = '{2}', DiaChi = N'{3}' where MaDocGia = '{4}'",
                dg.HoTen, dg.GioiTinh, dg.NamSinh, dg.DiaChi, dg.MaDocGia);
            Excute(sql);
        }
        public string QuyenDN(string tk)
        {
      
            DataTable dt = GetData("select * from ACCOUNT where ACCOUNT.TenDangNhap = '" + tk + "'");
            string gt = dt.Rows[0]["Quyen"].ToString();
            return gt;
        }
        public DataTable getThanhVien(string tdn)
        {
            string sqlString = string.Format("select * from ACCOUNT, DOCGIA where ACCOUNT.MaDocGia = DOCGIA.MaDocGia and ACCOUNT.TenDangNhap = '" + tdn + "'");
            DataTable dt = GetData(sqlString);
            return dt;
        }
    }
}

