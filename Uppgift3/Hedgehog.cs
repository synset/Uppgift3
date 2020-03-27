using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Hedgehog : Animal
    {
        public int SpikeLength;
        
        public Hedgehog(int spikeLength, string name, double weight, int age) : base(name, weight, age)
        {
            SpikeLength = spikeLength;
        }
        public override void Talk()
        {
            Console.WriteLine("Snuffle");
        }

        public override string Stats(Animal hedgehog)
        {
            return $"{base.Stats(hedgehog)} + Spikelength: {this.SpikeLength}";
        }
    }
}
