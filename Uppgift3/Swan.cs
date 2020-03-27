using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Swan : Bird
    {
        public int NeckLength;
        public Swan(int neckLength, int tailLength, string name, double weight, int age) : base(tailLength, name, weight, age)
        {
            NeckLength = neckLength;
        }

        public override string Stats(Animal bird)
        {
            return $"{base.Stats(bird)} + NeckLenght: {this.NeckLength}";
        }
    }
}
