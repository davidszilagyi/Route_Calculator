using System;
using System.Collections.Generic;
using NUnit.Framework;
using Route_Calculator.solver;
using Route_Calculator.dto;

namespace Route_Calculator
{
    [TestFixture]
    class Test
    {
        private Solver<string> solver;

        private Route AddRoute(string name)
        {
            Route temp = new Route(name);
            solver.Rules.Add(temp);
            return temp;
        }

        private void Initialize()
        {
            solver = new Solver<string>();
        }

        [Test]
        public void TestGetRoutes()
        {
            Initialize();
            Route x = AddRoute("x");
            Assert.AreEqual(new List<Route> { x }, solver.GetRoutes(x, false));
            Route y = AddRoute("y");
            Route z = AddRoute("z");
            Assert.AreEqual(new List<Route> { x, y, z }, solver.GetRoutes(x, false));
            solver.AddRule(y, z);
            Assert.AreEqual(new List<Route> { x, z, y }, solver.GetRoutes(x, true));
            Route w = AddRoute("w");
            Route v = AddRoute("v");
            Route u = AddRoute("u");
            solver.AddRule(x, u);
            solver.AddRule(y, v);
            solver.AddRule(v, w);
            solver.AddRule(w, z);
            Assert.AreEqual(new List<Route> { u, x, z, w, v, y }, solver.GetRoutes(u, true));
        }
    }
}
