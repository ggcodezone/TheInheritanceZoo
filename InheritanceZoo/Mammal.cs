using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceZoo
{
    class Mammal: Animals //this allows mammilian animals to inherit the abilities of the general animal class
    {
        public void IntroMammal()
        {
            Console.WriteLine("Here's one of our big cats!");
        }
        public void Roar()
        {
            Console.WriteLine("He's roaring.");
        }

        public void Itch()
        {
            Console.WriteLine("He's itching himself");
        }
    }
    //our specific animal classes can do everything the general class can, 
    //but they also have their own unique abilities too
}
