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
        public void IfTempLessThan40ThrowExceptionIcecreamShopIsclosed(){
           
        }
    }
}
