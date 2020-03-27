using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.IEnumerable;

namespace Uppgift3
{
    class Horse : Animal
    {
        public int NumberOfRaces;
        public Horse(int numberOfRaces, string name, double weight, int age) : base(name, weight, age)
        {
            NumberOfRaces = numberOfRaces;
        }

        public override void Talk()
        {
            Console.WriteLine("Neigh");
        }

        public override string Stats(Animal horse)
        {
            return $"{base.Stats(horse)} + NumberOfRaces: {this.NumberOfRaces}";
        }
    }

    
}
