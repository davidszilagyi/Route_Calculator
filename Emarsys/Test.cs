using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Route_Calculator.Solver;

namespace Route_Calculator
{
    [TestFixture]
    class Test
    {
        private Solver<string> solver = new Solver<string>();

        [Test]
        public void TestGetRoute()
        {
            Assert.AreEqual(new List<string> { "x" }, solver.GetRoute("x", "x", false));
            Assert.AreEqual(new List<string> { "x", "y", "z" }, solver.GetRoute("x", "z", false));
            Assert.AreEqual(new List<string> { "x", "z", "y" }, solver.GetRoute("x", "y", true));
            Assert.AreEqual(new List<string> { "uxzwvy", }, solver.GetRoute("u", "y", true));
        }

        [Test]
        public void TestCircularity()
        {
            throw new NotImplementedException();
        }
    }
}
