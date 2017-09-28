using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emarsys.Solver
{
    interface ISolver<T>
    {
        T[] GetRoute();

        bool CheckCircularity();
    }
}
