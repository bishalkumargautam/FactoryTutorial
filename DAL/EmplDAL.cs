using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL
{
    public  class EmplDAL:IEmplDAL
    {
        public int CheckEmployee(IEmplBO obj)
        {
            string str = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(str);
            sqlConnection.Open();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_checkUser";
            com.Parameters.AddWithValue("@Username", obj.Username);
            com.Parameters.AddWithValue("@Password", obj.Password);
            com.Connection = sqlConnection;
            int reader = Convert.ToInt32(com.ExecuteScalar());
            if (reader > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
