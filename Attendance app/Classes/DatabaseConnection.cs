using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_app.Classes
{
    class DatabaseConnection
    {
        private SqlConnection con;
        private DatabaseConnection() {
            con = new SqlConnection("");
        }

        public SqlConnection Connection() 
        {
            return con;
        }
    }
}
