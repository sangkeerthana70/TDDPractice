using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamPriceServices
{
    public class HolidayChecker
    {
       
        

        public bool IsHoliday(DateTime d)
        {
            if((d.DayOfWeek.Equals("Saturday") || (d.DayOfWeek.Equals("Sunday"))))
            {
                //Console.WriteLine(d.DayOfWeek);
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
    }
}
