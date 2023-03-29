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
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""Resources\Database.mdf"";Integrated Security=True;User ID=OMostafa;Password=***********;Connect Timeout=30");
            MessageBox.Show(con.ToString());
        }

        public SqlConnection Connection() 
        {
            return con;
        }
    }
}
