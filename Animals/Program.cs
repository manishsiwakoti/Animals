using System;
using System.Collections.Generic;
using AnimalLibrary; // added using new statement because it didn't had same namespace in class.

namespace Animals
    {
    class Program
        {
        static void Main(string[] args)
            {
            var boxer1 = new Boxer();
            var pug2 = new Pug("Deadly");
            var gs1 = new GermanShepherd("Killer");
            var germanSheperd = new GermanShepherd("Fred");
            var pug = new Pug();
            var pug1 = new Pug()

            
            
           
            

                {

                };
            var dogs = new List<Dog>();
            dogs.Add(pug);
            dogs.Add(germanSheperd);
            dogs.Add(gs1);
            dogs.Add(pug2);
            dogs.Add(boxer1);
            dogs.Add(pug1);
            

            foreach(var dog in dogs)
                {
                Console.WriteLine(dog.GetTypeDog());
                }

            }
        }
    }
