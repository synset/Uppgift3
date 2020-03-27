using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Flamingo : Bird
    {
        public int LegLength;
        public Flamingo(int legLength, int tailLength, string name, double weight, int age) : base(tailLength, name, weight, age)
        {
            LegLength = legLength;
        }

        public override string Stats(Animal flamingo)
        {
            return $"{base.Stats(flamingo)} + LegLength: {this.LegLength}";
        }
    }
}
