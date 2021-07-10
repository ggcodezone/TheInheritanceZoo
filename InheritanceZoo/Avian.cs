using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceZoo
{
    class Avian : Animals  //this allows bird animals to inherit the abilities of the general animal class
    {
        public void IntroBird()
        {
            Console.WriteLine("Here's one of our parrots!");
        }
        public void Fly()
        {
            Console.WriteLine("He's flying.");
        }
        public void Mimick()
        {
            Console.WriteLine("He's repeating the Zookeeper. Clever boy!");
        }

        public void EatSeeds()
        {
            Random random = new Random();

            int num = random.Next(1, 10);

            Console.WriteLine(num);

        }
    }
}

//our specific animal classes can do everything the general class can, 
//but they also have their own unique abilities too
