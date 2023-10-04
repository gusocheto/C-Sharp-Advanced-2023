using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    internal class Car
    {
        public Car(string model, int speed, int power, int weight, string type, double tyre1preasure, int age1, double tyre2preasure, int age2, double tyre3preasure, int age3, double tyre4preasure, int age4)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
            Tyres = new Tyre[4];
            Tyres[0] = new Tyre(tyre1preasure, age1);
            Tyres[1] = new Tyre(tyre2preasure, age2);
            Tyres[2] = new Tyre(tyre3preasure, age3);
            Tyres[3] = new Tyre(tyre4preasure, age4);
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tyre[] Tyres { get; set; }
    }
}
