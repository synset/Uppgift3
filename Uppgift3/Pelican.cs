using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Pelican : Bird
    {
        public int BeakLength;
        public Pelican(int beakLength, int tailLength, string name, double weight, int age) : base(tailLength, name, weight, age)
        {
            BeakLength = beakLength;
        }

        public override string Stats(Animal pelican)
        {
            return $"{base.Stats(pelican)} + BeakLenght: {this.BeakLength}";
        }
    }
}
