using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRHF.Codes
{
    public class MySettings
    {
        public static string MonthName(int month)
        {
            string m = null;
            switch (month)
            {
                case 1:
                    m= "January";
                    break;
                case 2:
                    m = "February";
                    break;
                case 3:
                    m = "March";
                    break;
                case 4:
                    m = "April";
                    break;
                case 5:
                    m = "May";
                    break;
                case 6:
                    m = "June";
                    break;
                case 7:
                    m = "July";
                    break;
                case 8:
                    m = "August";
                    break;
                case 9:
                    m = "September";
                    break;
                case 10:
                    m = "October";
                    break;
                case 11:
                    m = "November";
                    break;
                case 12:
                    m = "December";
                    break;
            }
            return m;
        }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Dept { get; set; }


    }
}
