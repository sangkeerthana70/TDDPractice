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

        [Test]
        //Test1
        public void NonHolidayAndTempBetween40And59Returns3Dollars()
        {
            DateTime date = new DateTime(2019, 1, 29);
            var temp = 53;
            var expected = 3;
            var actual = pricer.GetPrice(date, temp);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        // test2
        public void NonHolidayAndTempBetween60And79Returns4Dollars()
        {
            DateTime date = new DateTime(2019, 1, 30);
            var temp = 71;
            var expected = 4;
            var actual = pricer.GetPrice(date, temp);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        // Test3
        public void NonHolidayAndTempAbove80Returns5Dollars()
        {
            DateTime date = new DateTime(2019, 1, 31);
            var temp = 85;
            var expected = 5;
            var actual = pricer.GetPrice(date, temp);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        // Test4
        public void HolidayAndTempBetween40And59Returns4Dollars()
        {
            DateTime date = new DateTime(2019, 2, 2);
            var temp = 55;
            var expected = 4;
            var actual = pricer.GetPrice(date, temp);
            //Console.WriteLine(date.DayOfWeek);
            //Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        // Test5
        public void HolidayAndTempBetween60And79Returns5Dollars()
        {
            DateTime date = new DateTime(2019, 2, 3);
            var temp = 79;
            var expected = 5;
            var actual = pricer.GetPrice(date, temp);
            
            //Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);


        }

        [Test]
        // Test6
        public void HolidayAndTempAbove80Returns6Dollars()
        {
            DateTime date = new DateTime(2019, 2, 9);
            var temp = 89;
            var expected = 6;
            var actual = pricer.GetPrice(date, temp);           
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);

        }
    }
}
