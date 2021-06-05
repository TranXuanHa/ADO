using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLLichCongTac;

namespace DAL_QLLichCongTac
{
    public class DAL_LichCongTac : DBConnect
    {
        /// <summary>
        /// Get toàn bộ LICH CONG TAC
        /// </summary>
        /// <returns></returns>
        public DataTable GetLichCongTac()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LICHCONGTAC", _conn);
            DataTable dtLichCongTac = new DataTable();
            da.Fill(dtLichCongTac);
            return dtLichCongTac;
        }

        /// <summary>
        /// Thêm thành viên
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public bool ThemLichCongTac(DTO_LichCongTac ct)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì  để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO LICHCONGTAC(TU, DEN, LYDO, NGUOIDANGKY, DIENDAI) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", ct.LICHCONGTAC_TU, ct.LICHCONGTAC_DEN, ct.LICHCONGTAC_LYDO, ct.LICHCONGTAC_NGUOIDANGKY, ct.LICHCONGTAC_DIENDAI);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /// <summary>
        /// Sửa Lich cong tac
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public bool SuaLichCongTac(DTO_LichCongTac ct)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE LICHCONGTAC SET  TU = '{0}', DEN = '{1}', LYDO = '{2}', NGUOIDANGKY = '{3}', DIENDAI = '{4}'  WHERE STT = {5}", ct.LICHCONGTAC_TU, ct.LICHCONGTAC_DEN, ct.LICHCONGTAC_LYDO, ct.LICHCONGTAC_NGUOIDANGKY, ct.LICHCONGTAC_DIENDAI, ct.LICHCONGTAC_STT );

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /// <summary>
        /// Xóa lich cong tac
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public bool XoaLichCongTac(int STT)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM LICHCONGTAC WHERE STT = {0}", STT);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
    }
}
