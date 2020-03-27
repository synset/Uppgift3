using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    class PersonHandler
    {
        //???private???   attribut vs properties
        private Person Pers;
        private int Age { get; set; }


        //???: Vad menar du?: "i stället för att enbart använda en property har vi nu abstraherat i två lager"
        public void SetAge(Person pers, int age)
        {
            Person Pers = pers; //???: rätt kod?
            Age = age;
        }

        //???: vad missar jag? CreatePerson
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            var person = new Person(age, fName, lName, height, weight);
        }

        //???: Är detta metoder du menar jag skall skapa för operationer på objektet Person?
        //name set get
        //height set get
        //weight set get



    }
}
