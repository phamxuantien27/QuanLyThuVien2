﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class MatKhau:KetNoi
    {
        public void ChangePassWord(ThanhVien _tv)
        {
            string sql = string.Format("update ACCOUNT set MatKhau = '{0}' where TenDangNhap = '{1}'", _tv.MatKhau, _tv.TenDangNhap);
            Excute(sql);
        }
        public bool CheckExist(string _tdn, string _mkc)
        {
            string sql = string.Format("select* from ACCOUNT where MatKhau = '{0}' and TenDangNhap = '{1}'", _mkc, _tdn);
            if (GetData(sql).Rows.Count > 0)
                return true;
            return false;
        }
    }
}
