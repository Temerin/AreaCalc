﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class FigureExeption : Exception
    {
        public FigureExeption(string message)
            : base(message)
        {
        }
    }
}
