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
        void AddRule(string name, Route previous);

        List<T> GetRoute(T from, T to, bool sort);

        bool CheckCircularity();
    }
}
