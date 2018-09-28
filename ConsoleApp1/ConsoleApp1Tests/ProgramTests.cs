using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        Program p = new Program();

        [TestMethod()]
        public void PlusTest()
        {
            
            Assert.AreEqual(p.Plus(1, 1), 2);
        }

        [TestMethod()]
        public void MinusTest()
        {
            Assert.AreEqual(p.Minus(1, 1), 0);
            Assert.AreEqual(p.Minus(100, 1), 99);
        }
    }
}