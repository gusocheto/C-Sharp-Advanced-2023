using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    internal class Tyre
    {
        public Tyre(double preasure, int age) 
        {
            Preasure = preasure;
            Age = age;
        }
        public double Preasure { get; set; }

        public int Age { get; set;}
    }
}
