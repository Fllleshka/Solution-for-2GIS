using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution_for_2GIS;

namespace UnitTestProject1
{
    [TestClass]
    public class Myprogramtests
    {
        [TestMethod]
        public void InsertDates_0and4_4returned()
        {
            //arrange
            int i = 0;
            float expected = 4;

            //act
            equation test = new equation();
            float actual = test.InsertDates(i);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
