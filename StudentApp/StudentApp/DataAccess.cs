using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace StudentApp
{
    class DataAccess
    {

       static string connectStr = "server=CLONE-PC\\SQLEXPRESS2;integrated security=true;database=StDb2SQL";

        public static object GetSingleAnswer(string sql)
        {
            object obj = null;
            SqlConnection conn = new SqlConnection(connectStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                obj = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return obj;
        }

        public static int InsUpDel(string sql)
        {
            int rows = 0;
            SqlConnection conn = new SqlConnection(connectStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return rows;
        }

        public static DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectStr);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
