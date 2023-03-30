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
        private DataGridViewCheckBoxCell checkBox;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Item_Controller()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            DatabaseConnection database = new DatabaseConnection();
            con = database.Connection();
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public DataTable Display()
        {
            dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("dayid", typeof(int));
            dt.Columns.Add("التاريخ", typeof(string));
            dt.Columns.Add("المحاضر", typeof(string));
            dt.Columns.Add("البرنامج", typeof(string));
            dt.Columns.Add("الشعبة", typeof(string));
            dt.Columns.Add("السنة", typeof(string));
            dt.Columns.Add("الحضور", typeof(DataGridViewCheckBoxCell));
            dt.Columns.Add("x", typeof(bool));
            for (DateTime t = Global.StartDate.Date; t <= Global.EndDate.Date; t = t.AddDays(1))
            {
                DataTable databaseTable = new DataTable();
                string query1 = "SELECT * FROM InsertedData WHERE Day = '" + t.DayOfWeek.ToString() + "'" ;
                string query2 = "SELECT * FROM Attendance WHERE Date = '" + t.Date.ToString() + "'";
                sda = new SqlDataAdapter(query1, con);
                sda.Fill(databaseTable);
                dynamic[] row = new dynamic[8];
                row[2]=t.ToLongDateString();
                sda = new SqlDataAdapter(query2,con);
                DataTable AttendanceTb = new DataTable();
                sda.Fill(AttendanceTb);
#pragma warning disable CS8601 // Possible null reference assignment.
                foreach (DataRow dbRow in databaseTable.Rows)
                {
                    row[1] = dbRow[0].ToString();
                    row[3] = dbRow[2].ToString();
                    row[4] = dbRow[3].ToString();
                    row[5] = dbRow[4].ToString();
                    row[6] = dbRow[5].ToString();
                    checkBox = new DataGridViewCheckBoxCell
                    {
                        ThreeState = true,

                    };
                    foreach (DataRow AtbRow in AttendanceTb.Rows)
                    {
                        /*if (AtbRow[7].ToString() == "")
                        {
                            checkBox;
                        }
                        else if (Convert.ToInt32(AtbRow[7].ToString()) == 1)
                        {
                            checkBox.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkBox.CheckState = CheckState.Unchecked;
                        }*/
                        row[0] = AtbRow[0].ToString();
                    }
                    row[7] = checkBox;
                    dt.Rows.Add(row);
                }
#pragma warning restore CS8601 // Possible null reference assignment.
            }
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
            try
            {
                cnt = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return cnt;
        }
    }
}
