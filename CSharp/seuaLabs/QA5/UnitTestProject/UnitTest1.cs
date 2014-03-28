using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA5;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SinTestMethod()
        {
            Assert.AreEqual(Expression.Calc("sin(0)"), 0, 0.001);
        }


        [TestMethod]
        public void AddTestMethod()
        {
            Assert.AreEqual(Expression.Calc("5+3+3-3"), 8, 0.001);
        }
        [TestMethod]
        public void SpaceTestMethod()
        {
            Assert.AreEqual(Expression.Calc("5+1+3   +       3"), 12, 0.001);
        }
        [TestMethod]
        public void OperatorPriorityTestMethod()
        {
            Assert.AreEqual(Expression.Calc("3+5*10"), 53, 0.001);
        }
        [TestMethod]
        public void ScopeTestMethod()
        {
            Assert.AreEqual(Expression.Calc("5*(1+2) / 15"), 1, 0.001);
        }
        [TestMethod]
        public void EmptyTestMethod()
        {
            Assert.AreEqual(Expression.Calc(""), 0, 0.001);
        }
        [TestMethod]
        public void SymbolTestMethod()
        {
            Assert.AreEqual(Expression.Calc("+"), 0, 0.001);
        }
    }
}
