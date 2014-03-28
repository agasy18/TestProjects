using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA6;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodX2()
        {
            double x1, x2;
            if (SquareEquation.Calc(1, -5, 6, out x1, out x2))
            {
                Assert.IsTrue(x1 == 2 && x2 == 3);
            }
            else
            {
                Assert.Fail();
            }
        }
        [TestMethod]

        public void TestMethodXE()
        {
            double x1, x2;
            if (SquareEquation.Calc(3, 6, 3, out x1, out x2))
            {
                Assert.IsTrue(x1 ==-1  && x2 == -1);
            }
            else
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestMethodXD()
        {
            double x1, x2;
            if (SquareEquation.Calc(1, -5, 8886, out x1, out x2))
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestMethodM()
        {
            double x1, x2;
            if (SquareEquation.Calc(0, -5, 8886, out x1, out x2))
            {
                Assert.Fail();
            }
        }
    }
}
