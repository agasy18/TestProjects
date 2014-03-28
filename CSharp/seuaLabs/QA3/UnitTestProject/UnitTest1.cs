using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA3;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]

        public void TestMethod1()
        {
            Triangle t = new Triangle(1, 2, 3);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Triangle t = new Triangle(2, 2, 3);
            Assert.IsTrue(t.IsHavasarasrun);
            Assert.IsFalse(t.IsHavasarakoxm);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Triangle t = new Triangle(3, 3, 3);
            Assert.IsTrue(t.IsHavasarakoxm);
            Assert.IsTrue(t.IsHavasarasrun, "havasarakoxm");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod4()
        {
            Triangle t = new Triangle(0, 0, 0);
    
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        
        public void TestMethod5()
        {
            Triangle t = new Triangle(-1, 5, 6);
        }
    }
}
