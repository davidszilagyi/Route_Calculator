using System.Collections.Generic;
using Route_Calculator.dto;

namespace Route_Calculator.solver
{
    class Solver<T> : ISolver<T>
    {
        public List<Route> Rules = new List<Route>();

        public void AddRule(Route to, Route previous)
        {
            foreach (Route route in Rules)
            {
                if (route.Equals(to))
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
            while (true)
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

        public List<Route> GetRoutes(Route from, bool sort)
        {
            if (!sort)
            {
                return Rules;
            }
            else
            {
                List<Route> result = new List<Route> { from };
                for (int i = 0; i < Rules.Count; i++)
                {
                    for (int k = 0; k < Rules.Count; k++)
                    {
                        if (Rules[k].GetRoute() != null && Rules[k].GetRoute().Equals(Rules[i]))
                        {
                            result.Insert(result.IndexOf(Rules[i]) + 1, Rules[k]);
                            break;
                        }
                        else if (Rules[k].GetRoute() == null && !result.Contains(Rules[k]))
                        {
                            result.Add(Rules[k]);
                        }

                    }
                }
                return result;
            }
        }
    }
}
