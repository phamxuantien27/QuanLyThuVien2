using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO
{
    public class LichSuMuon:KetNoi
    {
        public DataTable loadSach(string _tdn)
        {
            string sqlString = string.Format("select * from PHIEUTRA, SACH, ACCOUNT where PHIEUTRA.MaDocGia = ACCOUNT.MaDocGia and SACH.MaSach = PHIEUTRA.MaSach and ACCOUNT.TenDangNhap = '{0}'", _tdn);
            return GetData(sqlString);
        }
        public DataTable Search(string _ts, string _tdn)
        {
            string sqlString = string.Format("select * from PHIEUTRA, SACH, ACCOUNT where PHIEUTRA.MaDocGia = ACCOUNT.MaDocGia and SACH.MaSach = PHIEUTRA.MaSach and ACCOUNT.TenDangNhap = '{0}' and SACH.TenSach like N'%{1}%'", _tdn, _ts);
            return GetData(sqlString);
        }
        /*
         *  public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        } public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }
         */
    }
}

