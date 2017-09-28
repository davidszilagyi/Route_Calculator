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
        private List<Route> Rules;

        public void AddRule(string name, Route previous)
        {
            
        }

        public bool CheckCircularity()
        {
            throw new NotImplementedException();
        }

        public List<T> GetRoute(T from, T to, bool sort)
        {
            throw new NotImplementedException();
        }
    }
}
