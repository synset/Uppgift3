using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class Person
    {
        //???: privata attribut, är det dessa variabler du undrar om vi kommer åt?
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        //???: skall koden i konstruktorn ändras till createPerson?
        public Person(int age, string fName, string lName, double height, double weight)
        {
            var person = new Person.CreatePerson(age, fName, lName, height, weight);
            //this.age = age;
            //this.fName = fName;
            //this.lName = lName;
            //this.height = height;
            //this.weight = weight;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
