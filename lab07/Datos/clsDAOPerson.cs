using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class clsDAOPerson : clsDAO
    {
        public DataTable GeAll()
        {
            DataTable dt = new DataTable();

            con.Open();
            String sql = "select * from Person";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);

            con.Close();

            return dt;
        }

        public DataTable GetUsuario(int id)
        {
            DataTable dt = new DataTable();

            con.Open();
            String sql = "SELECT * FROM Person Where PersonID ='" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);
            con.Close();
            return dt;

        }
    }
}
