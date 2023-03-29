using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_app.Classes
{
    internal class Item_Controller : DatabaseConnection
    {
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private SqlConnection con;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Item_Controller()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            DatabaseConnection database = new DatabaseConnection();
            con = database.Connection();
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public DataTable Display(String query)
        {
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            return dt;
        }
       
        public int SetData(String Query)
        {
            int cnt = 0;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            con.Close();
            return cnt;
        }
    }
}
