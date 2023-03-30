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
        public DatabaseConnection() {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Filo's Study\Attendance app\Attendance app\Resources\Database.mdf"";Integrated Security=True;User ID=OMostafa;Connect Timeout=30");
        }

        public SqlConnection Connection() 
        {
            return con;
        }
    }
}
