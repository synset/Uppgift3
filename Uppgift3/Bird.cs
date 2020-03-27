using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Bird : Animal
    {
        public int TailLength;
        public Bird(int tailLength, string name, double weight, int age) : base(name, weight, age)
        {
            this.TailLength = tailLength;
        }
        public override void Talk()
        {
            Console.WriteLine("Tweet tweet");
        }
        
        public override string Stats(Animal bird)
        {
            return $"{base.Stats(bird)} + TailLength: {this.TailLength}"; 
        }
    }
}
