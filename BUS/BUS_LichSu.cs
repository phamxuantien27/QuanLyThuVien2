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
    public class BUS_LichSu
    {
        LichSuMuon lsmDao = new LichSuMuon();
        public DataTable GetList(string _tdn)
        {
            return lsmDao.loadSach(_tdn);
        }
        public DataTable TimKiem(string _ts, string _tdn)
        {
            return lsmDao.Search(_ts, _tdn);
        }
    }
}
