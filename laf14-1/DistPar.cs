﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laf14_1
{
    class DistPar
    {
        public int distance;
        public int parentVert;
        public DistPar(int pv, int dis)
        {
            parentVert = pv;
            distance = dis;
        }
    }
}
