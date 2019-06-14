using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MewsSystemCurrencyRateLibrary
{
    public class Util
    {
        public static readonly Util i= new Util();

        public string GetAbbrMonthString(int monthIndex)
        {
            var months = new[]
            {
                "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"
            };

            return months[monthIndex - 1];
        }
    }
}
