﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_Calculator.Solver
{
    interface ISolver<T>
    {
        T[] GetRoute();

        bool CheckCircularity();
    }
}
