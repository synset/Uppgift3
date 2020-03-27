using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Dog : Animal
    {
        public string Breed;
        public Dog(string breed, string name, double weight, int age) : base(name, weight, age)
        {
            Breed = breed;
        }
        public override void Talk()
        {
            Console.WriteLine("Woof");
        }

        public override string Stats(Animal dog)
        {
            return $"{base.Stats(dog)} + Breed: {this.Breed}";
        }

        public void IAm()
        {
            Console.WriteLine("I am a dog");
        }



        
    }
}
