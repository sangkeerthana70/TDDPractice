using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamPriceServices
{
    public class Pricer
    {
        HolidayChecker hc;

        public Pricer(HolidayChecker hc)
        {
            this.hc = hc;
        }

        public int GetPrice(DateTime d, float Temp)
        {

            Console.WriteLine("Inside Pricer.GetPrice");
            Console.WriteLine("d = " + d);
            Console.WriteLine("Temp = " + Temp);
            //Console.WriteLine("hc.IsHoliday(d) = " + hc.IsHoliday(d));

            if (Temp < 40)
            {
                throw new System.ArgumentException("Ice cream shop is closed");
            }
            Console.WriteLine(Temp >= 40);
            Console.WriteLine(Temp <= 59);
            Console.WriteLine(hc.IsHoliday(d));

            if ((Temp >= 40) && (Temp <= 59) && (!(hc.IsHoliday(d))))
            {
                Console.WriteLine("In If 2");
                
                return 3;
            }

            if((Temp >= 60) && (Temp <= 79) && (!(hc.IsHoliday(d))))
            {
                Console.WriteLine("In If 3");
                return 4;
            }

            if((Temp > 80) && (!(hc.IsHoliday(d))))
            {
                Console.WriteLine("In If 4");
                return 5;
            }
            if ((Temp >= 40) && (Temp <= 59) && (hc.IsHoliday(d)))
            {
                Console.WriteLine("In If 5");
                return 4;
            }
            if((Temp >= 60) && (Temp <= 79) && (hc.IsHoliday(d)))
            {
                Console.WriteLine("In If 6");
                return 5;
            }
            if((Temp > 80) && (hc.IsHoliday(d)))
            {
                Console.WriteLine("In If 7");
                return 6;
            }
            return 0;

        }
    }
}
