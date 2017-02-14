using Microsoft.VisualStudio.TestTools.UnitTesting;
using NedarvingBil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingBil.Tests
{
    [TestClass()]

    public class BilTests
    {
        [TestMethod()]
        //[ExpectedException(typeof(ArgumentException))]
        public void GetRegistreringsAfgiftTest_DieselBil2015_100000cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 100000, 2015, "DD77380", 60, true, 10);

            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(118725,afgift);

           // Assert.Fail();
        }
    }
}