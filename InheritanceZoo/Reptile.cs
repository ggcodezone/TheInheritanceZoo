using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceZoo
{
    class Reptile : Animals //this allows reptile animals to inherit the abilities of the general animal class
    {
        public void IntroReptile()
        {
            Console.WriteLine("Here's one of our lizards!");
        }
        public void Sunbathe()
        {
            Console.WriteLine("He's sunbathing.");
        }

        public void Hibernate()
        {
            Console.WriteLine("He's hibernating.");
        }
    }
    //our specific animal classes can do everything the general class can, 
    //but they also have their own unique abilities too
}
