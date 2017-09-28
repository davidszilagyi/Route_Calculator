using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_Calculator.Solver
{
    interface ISolver<T>
    {
        void AddRule();

        T[] GetRoute(T from, T to, bool sort);

        bool CheckCircularity();
    }
}
