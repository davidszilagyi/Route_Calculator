using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_Calculator.Route
{
    class Route
    {
        Route route;

        public Route(Route previous)
        {
            this.route = previous;
        }

        public Route GetRoute()
        {
            return route;
        }

        public void SetRoute(Route route)
        {
            this.route = route;
        }
    }
}
