﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    internal class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;

        }
        public int Weight { get; set; }

        public string Type { get; set; }
    }
}
