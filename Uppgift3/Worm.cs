using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Worm : Animal
    {
        public int Circumference;
        public Worm(int circumference, string name, double weight, int age) : base(name, weight, age)
        {
            Circumference = circumference;
        }
        public override void Talk()
        {
            Console.WriteLine(" ");
        }

        public override string Stats(Animal worm)
        {
            return $"{base.Stats(worm)} + Circumference: {this.Circumference}";
        }
    }
}
