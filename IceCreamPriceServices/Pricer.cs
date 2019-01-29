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
            if(Temp < 40)
            {
                throw new System.ArgumentException("Ice cream shop is closed");
            }

            if(Temp >= 40 && Temp <= 59 && !hc.IsHoliday(d))
            {
                return 3;
            }

            if(Temp >= 60 && Temp <= 79)
            {
                return 4;
            }
            
            return 0;

        }
    }
}
