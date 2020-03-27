using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    public class Animal
    {
        protected string Name;
        protected double Weight;
        protected int Age;

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }

        public virtual void Talk()
        {
            Console.WriteLine("Sound");
        }

        public virtual string Stats(Animal animal)
        {
            return $"Name: { animal.Name} Weight: { animal.Weight} Age: { animal.Age}";
        }    
    }
}

