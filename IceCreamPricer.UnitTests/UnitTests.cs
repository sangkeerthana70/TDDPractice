using IceCreamPriceServices;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamPricer.UnitTests
{
    [TestFixture]
    public class UnitTests
    {        
        Pricer pricer = new Pricer(new HolidayChecker());

        [Test]
        public void IfTempLessThan40ThrowExceptionIcecreamShopIsclosed()
        {
            DateTime date = new DateTime();
            var temperature = 37;
            //var actual = pricer.GetPrice(date, input);
            //Console.WriteLine(actual);
            Assert.Throws<System.ArgumentException>(() => pricer.GetPrice(date, temperature));

        }



        // NonHolidayBetween60And79Returns4Dollars

        //NonHolidayAbove80Returns5Dollars

        //HolidayBetween40And59Returns4Dollars

        //HolidayBetween60And79Returns5Dollars

        //HolidayAbove80Returns6Dollars
    }
}
