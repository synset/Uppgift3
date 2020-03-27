using System;
using System.Collections.Generic;

namespace Uppgift3
{
    class Program
    {

        /// <summary>
        /// 
        /// Mina frågor till dig har jag markerat med ???:
        /// Mina svar på dina frågor har jag markerat med SVAR:
        /// 
        /// </summary>
       
        static void Main(string[] args)
        {
            //Person person = new Person(43, "Synnöve", "Settman", 173, 76);
            //Console.WriteLine(person);
            //return person;

            //int personAge = PersonHandler.SetAge(person, person.age);

            PersonHandler person2 = new PersonHandler();
            person2.CreatePerson(42, "Pia", "Eriksson", 155, 60);

            Console.WriteLine(person2);
            return person;

            List<PersonHandler> people = new List<PersonHandler>();
            people.Add(new PersonHandler(people.CreatePerson { 42, "Pia", "Eriksson", 155, 60}));
           
            //testa metoder
            //???: skriva kod eller UnitTesting?

            var animals = new List<Animal>();
            animals.Add(new Bird()
            { TailLength = 4, Name = "Tweety", Weight = 0.022, Age = 1 });

            animals.Add(new Swan()
            { NeckLength = 40, TailLength = 4, Name = "Tweety", weight = 0.022, Age = 1 });

            animals.Add(new Dog()
            { Breed = "Amstaff", Name = "Rusty", Weight = 25, Age = 3  });

            //???: hur skall jag skriva ut?
            foreach (var ani in animals)
            {
                Console.WriteLine(ani.Stats);
            }

            var dogs = new List<Dog>();
            dogs.Add(new Horse()
            { 3, "WhiteKnight", 400, 5 });
            //SVAR: kan inte lägga till pga fel parameter

            var dogs = new List<Dog>();
            dogs.Add(new Horse()
            { "Mustang", "WhiteKnight", 400, 5 });
            //SVAR: kan inte lägga till Horse, för det är fel typ. Dog förväntas.
            //SVAR: listan måste vara av typ Animal för att lagra alla klasser tillsammans
           
            //ToDo: förklara vad som händer
           
            //???: skriv ut stats för hundar genom en foreach på animals
            foreach (var ani in animals)
            {
                if (ani == Dog)
                Console.WriteLine(ani.Stats);
            }

            //Kommer du åt metoden IAm (i klassen Dog) från Animal listan?
            //varför inte?
                //SVAR: en Animal kan inte behnadlas som en Dog

            //ToDo: hitta ett sett att skriva ut din nya metod för dog genom en foreach på Animals

            List<UserError> userErrors = new List<UserError>();

            userErrors.Add(new NumericInputError { "Number expected" },
                                                    { "Try with a number instead"});
            userErrors.Add(new TextInputError { "Text expected" },
                                                    { "Try with a text instead"});

            //???: skriv ut samtliga UserErrors UEMessage() genom foreach loop
            foreach (var userE in userErrors)
            {
                    Console.WriteLine(userE.UEMessage);
            }

            //ToDo: skapa tre egna klasser med tre egna definitoner på UEMessage()
            //testa


            //Varför är polymorfism så viktigt att behärska?
            //SVAR: olika klasser kan använda samma metod, men utföra den på olika sett.
            //Hur kan polymorfism förändra och förbättra kod via en bra struktur?
            //SVAR: det är flexibelt, samt förhindrar upprepande kod
            //vad är skillnaden på en abstract klass och ett interface?
            //SVAR: ett interface definierar endast signaturer av medlemmar, klassen som implementerar IF måste implementera alla medlemmarna
            //SVAR: du kan implementera flera interface, men endast ärva en klass.
            //3.2.8
            //SVAR: Om samtliga fåglar behöver ett nytt attribut bör man lägga den i Bird
            //3.2.9
            //SVAR: Nytt attribut till alla djur bör läggas i Animal
        }
    }
}
