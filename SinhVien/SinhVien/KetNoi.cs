using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace SinhVien
{
    static class KetNoi
    {
        static SqlConnection conn;
        static SqlDataAdapter da;
        static SqlCommand cmd;

        static public void moKetNoi()
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["kn"].ConnectionString.ToString();
            try
            {
                conn.Open();
            }
            catch
            {

            }
        }
        static public void dongKetNoi()
        {
            conn.Close();
        }
        #region
        static public int ktraMaNV(string ma)
        {
            string sql = string.Format("select count(*) from NhanVien where MaNV= '{0}'", ma);
            cmd = new SqlCommand(sql, conn);
            int soluong = (int)cmd.ExecuteScalar();
            return soluong;
        }
        #endregion
        static public DataTable getData(string sql)
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        static public void updateData(string sql, object[] value, string[] name, int slthamso)
        {
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            for(int i = 0; i < slthamso; i++)
                cmd.Parameters.AddWithValue(name[i], value[i]);
                
            cmd.ExecuteNonQuery();
            
        }
    }
}
