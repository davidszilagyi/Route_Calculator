using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route_Calculator.dto;

namespace Route_Calculator.solver
{
    class Solver<T> : ISolver<T>
    {
        public List<Route> Rules = new List<Route>();

        public void AddRule(Route to, Route previous)
        {
            foreach(Route route in Rules)
            {
                if(route.Equals(to))
                {
                    to.SetRoute(previous);
                    break;
                }
            }
        }

        public bool HasLoop()
        {
            Route fast = Rules[0];
            Route slow = Rules[0];
            while(true)
            {
                slow = slow.GetRoute();
                if (slow.GetRoute() != null)
                {
                    fast = fast.GetRoute().GetRoute();
                }
                if (slow == null || fast == null)
                {
                    return false;
                }
                if (slow == fast)
                {
                    return true;
                }
            }
        }

        public List<T> GetRoute(T from, T to, bool sort)
        {
            throw new NotImplementedException();
        }
    }
}
