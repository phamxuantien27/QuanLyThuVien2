using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_MatKhau
    {
        MatKhau mkDao = new MatKhau();
        public void DoiMatKhau(ThanhVien _tv)
        {
            mkDao.ChangePassWord(_tv);
        }
        public bool CheckExist(string _tdn, string _mkc)
        {
            return mkDao.CheckExist(_tdn, _mkc);

        }
    }
}
