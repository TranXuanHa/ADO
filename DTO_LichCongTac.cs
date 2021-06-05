using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLLichCongTac
{
    public class DTO_LichCongTac
    {
        private int _LICHCONGTAC_STT;
        private string _LICHCONGTAC_TU;
        private string _LICHCONGTAC_DEN;
        private string _LICHCONGTAC_LYDO;
        private string _LICHCONGTAC_NGUOIDANGKY;
        private string _LICHCONGTAC_DIENDAI;

        /* ======== GETTER/SETTER ======== */
        public int LICHCONGTAC_STT
        {
            get
            {
                return _LICHCONGTAC_STT;
            }

            set
            {
                _LICHCONGTAC_STT = value;
            }
        }

        public string LICHCONGTAC_TU
        {
            get
            {
                return _LICHCONGTAC_TU;
            }

            set
            {
                _LICHCONGTAC_TU = value;
            }
        }

        public string LICHCONGTAC_DEN
        {
            get
            {
                return _LICHCONGTAC_DEN;
            }

            set
            {
                _LICHCONGTAC_DEN = value;
            }
        }

        public string LICHCONGTAC_LYDO
        {
            get
            {
                return _LICHCONGTAC_LYDO;
            }

            set
            {
                _LICHCONGTAC_LYDO = value;
            }
        }

        public string LICHCONGTAC_NGUOIDANGKY
        {
            get
            {
                return _LICHCONGTAC_NGUOIDANGKY;
            }

            set
            {
                _LICHCONGTAC_NGUOIDANGKY = value;
            }
        }

        public string LICHCONGTAC_DIENDAI
        {
            get
            {
                return _LICHCONGTAC_DIENDAI;
            }

            set
            {
                _LICHCONGTAC_DIENDAI = value;
            }
        }
        /* === Constructor === */
        public DTO_LichCongTac()
        {

        }

        public DTO_LichCongTac(int stt, string tu, string den, string lydo, string nguoidangky, string diendai)
        {
            this.LICHCONGTAC_STT = stt;
            this.LICHCONGTAC_TU = tu;
            this._LICHCONGTAC_DEN = den;
            this._LICHCONGTAC_LYDO = lydo;
            this._LICHCONGTAC_NGUOIDANGKY = nguoidangky;
            this._LICHCONGTAC_DIENDAI = diendai;
        }
    }
}
