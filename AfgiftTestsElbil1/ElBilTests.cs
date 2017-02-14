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
    public class ElBilTests
    {
        [TestMethod()]
        public void GetRegistreringsAfgiftTest_Elbil2014_5000kr()
        {
            //arrange
            ElBil elbil = new ElBil("Nissan Leaf", 5000, 2014, "EL201401", 8, 30);

            //act
            int afgiftElbil = elbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(1050, afgiftElbil);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_Elbil2014_80499kr()
        {
            //arrange
            ElBil elbil = new ElBil("Nissan Leaf", 80499, 2014, "EL201402", 8, 30);

            //act
            int afgiftElbil = elbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(16904, afgiftElbil);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_Elbil2014_80500kr()
        {
            //arrange
            ElBil elbil = new ElBil("Nissan Leaf", 80500, 2014, "EL201402", 8, 30);

            //act
            int afgiftElbil = elbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(16905, afgiftElbil);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_Elbil2014_80501kr()
        {
            //arrange
            ElBil elbil = new ElBil("Nissan Leaf", 80501, 2014, "EL201402", 8, 30);

            //act
            int afgiftElbil = elbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(16905, afgiftElbil);
        }

        public void GetRegistreringsAfgiftTest_Elbil2014_100000kr()
        {
            //arrange
            ElBil elbil = new ElBil("Nissan Leaf", 100000, 2014, "EL201402", 8, 30);

            //act
            int afgiftElbil = elbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(23925, afgiftElbil);
        }

        // Mangler at teste elbiler årgang 2015
    }
}