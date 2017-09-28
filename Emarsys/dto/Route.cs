using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_Calculator.dto
{
    class Route
    {
        string name;
        Route route;

        public Route(string name)
        {
            this.name = name;
        }

        public Route GetRoute()
        {
            return route;
        }

        public string GetName()
        {
            return name;
        }

        public void SetRoute(Route route)
        {
            this.route = route;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
