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
        /// <summary>
        /// Test af Registreringsafgift på Dieselbiler, Årgang 2014
        /// </summary>
        [TestMethod()]
        //[ExpectedException(typeof(ArgumentException))]
        public void GetRegistreringsAfgiftTest_DieselBil2014_5000cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 5000, 2014, "DD77380", 60, true, 10);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(5250, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2014_80499cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 80499, 2014, "DD77380", 60, true, 10);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(84523, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2014_80500cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 80500, 2014, "DD77380", 60, true, 10);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(84525, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2014_80501cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 80501, 2014, "DD77380", 60, true, 10);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(84526, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2014_100000cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 100000, 2014, "DD77380", 60, true, 10);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(119625,afgift);
        }

        /// <summary>
        /// Test af Registreringsafgift på Dieselbiler, Årgang 2015
        /// </summary>
        /// 
        [TestMethod()]
        //[ExpectedException(typeof(ArgumentException))]
        public void GetRegistreringsAfgiftTest_DieselBil2015_5000cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 5000, 2015, "DD77380", 60, true, 10);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(5250, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2015_81699cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 81699, 2015, "DD77380", 60, true, 10);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(85783, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2015_81700cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 81700, 2015, "DD77380", 60, true, 10);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(85785, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2015_81701cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 81701, 2015, "DD77380", 60, true, 10);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(85786, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2015_100000cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 100000, 2015, "DD77380", 60, true, 10);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(118725, afgift);
        }

        /// <summary>
        /// Mangler at teste Registreringsafgift på Benzinbiler, Årgang 2014 og 2015
        /// </summary>
    }
}