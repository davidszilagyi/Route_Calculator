using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route_Calculator.dto;

namespace Route_Calculator.solver
{
    interface ISolver<T>
    {
        void AddRule(Route to, Route previous);

        List<Route> GetRoutes(Route from, bool sort);

        bool HasLoop(); 
    }
}
