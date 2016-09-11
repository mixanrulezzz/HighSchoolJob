using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatDateLibrary
{
    public static class FormatDate
    {
        public static string GetNowDate()
        {
            var dd = DateTime.Now.Day.ToString();
            if (dd.Length == 1) dd = '0' + dd;

            var mm = DateTime.Now.Month.ToString();
            if (mm.Length == 1) mm = '0' + mm;

            var yy = DateTime.Now.Year.ToString();

            return dd + '.' + mm + '.' + yy;
        }

        public static string GetDate(int Day, int Month, int Year)
        {
            var dd = Day.ToString();
            if (dd.Length == 1) dd = '0' + dd;

            var mm = Month.ToString();
            if (mm.Length == 1) mm = '0' + mm;

            var yy = Year.ToString();

            return dd + '.' + mm + '.' + yy;
        }
    }
}
