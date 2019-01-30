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

            //Console.WriteLine("    Inside HolidayChecker.IsHoliday");
            //Console.WriteLine("    d = " + d);
            //Console.WriteLine("    d.DayOfWeek = "  + d.DayOfWeek);
            Console.WriteLine("     " + d.DayOfWeek);
            Console.WriteLine("     " + d.DayOfWeek.ToString().Equals("Saturday"));
            Console.WriteLine("     " + d.DayOfWeek.ToString().Equals("Sunday"));


            if ((d.DayOfWeek.ToString().Equals("Saturday") || (d.DayOfWeek.ToString().Equals("Sunday"))))
            {
                return true;
            }
           
            return false;
            
            
            
        }
    }
}
