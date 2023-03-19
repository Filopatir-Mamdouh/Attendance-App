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
        protected DatabaseConnection() {
            SqlConnection con = new SqlConnection("");
            con.Open();
        }
    }
}
