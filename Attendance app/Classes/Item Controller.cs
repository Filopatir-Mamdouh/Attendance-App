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
        private string query;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string constr;
        private SqlConnection DatabaseConnection()
        {
            throw new NotImplementedException();
        }
        public DataTable display()
        {
            query = "Select * From table";
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(query, DatabaseConnection());
            return dt;
        }
       
        public void setData(Dictionary<String,String> inputData)
        {

        }
    }
}
