﻿using NumSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace PandasNET
{
    public class Series<T> : NDArray<T>
    {
        public String Name { get; set; }
    }
}
