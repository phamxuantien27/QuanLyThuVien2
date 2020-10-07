﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO
{
   public  class DangMuon:KetNoi
    {
        public DataTable loadSach()
        {
            string sqlString = @"select DOCGIA.HoTen, SACH.TenSach, PHIEUMUON.NgayMuon, PHIEUMUON.NgayPhaiTra from SACH, DOCGIA, PHIEUMUON where SACH.MaSach = PHIEUMUON.MaSach and PHIEUMUON.MaDocGia = DOCGIA.MaDocGia and PHIEUMUON.TinhTrang = 0";
            return GetData(sqlString);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string table = "";
            if (_loaitk == "HoTen")
                table = "DOCGIA";
            else
                table = "SACH";
            string sqlString = string.Format("select DOCGIA.HoTen, SACH.TenSach, PHIEUMUON.NgayMuon from SACH, DOCGIA, PHIEUMUON where SACH.MaSach = PHIEUMUON.MaSach and PHIEUMUON.MaDocGia = DOCGIA.MaDocGia and {0}.{1} like N'%{2}%' and PHIEUMUON.TinhTrang = 0", table, _loaitk, _timkiem);
            return GetData(sqlString);
        }
    }
}

