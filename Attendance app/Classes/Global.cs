using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_app.Classes
{
    static class Global
    {
        private static DateTime _startDate;
        private static DateTime _endDate;

        public static DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public static DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
    }
}
