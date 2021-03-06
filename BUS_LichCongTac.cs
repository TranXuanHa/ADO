using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLLichCongTac;
using DTO_QLLichCongTac;

namespace BUS_QLLichCongTac
{
    public class BUS_LichCongTac
    {
        
            DAL_LichCongTac dalLichCongTac = new DAL_LichCongTac();

            public DataTable GetLichCongTac()
            {
                return dalLichCongTac.GetLichCongTac();
            }

            public bool ThemLichCongTac(DTO_LichCongTac ct)
            {
                return dalLichCongTac.ThemLichCongTac(ct);
            }

            public bool SuaLichCongTac(DTO_LichCongTac ct)
            {
                return dalLichCongTac.SuaLichCongTac(ct);
            }

            public bool XoaLichCongTac(int STT)
            {
                return dalLichCongTac.XoaLichCongTac(STT);
            }
        }
    }

