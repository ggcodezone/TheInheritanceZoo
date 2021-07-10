using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceZoo
{
    class Animals //this is the main class or "parent" class, which is a general animals category.
        //all of our animals regardless of species can do these tasks via inheritance.
    {
        public void Sleep()
        {
            Console.WriteLine("He's sleeping.");
        }

        public void Eat()
        {
            Console.WriteLine("He's eating.");
        }

        public void Run()
        {
            Console.WriteLine("He's running.");
        }

        public void Walk()
        {
            Console.WriteLine("He's walking around.");
        }

        public void Rest()
        {
            Console.WriteLine("He's relaxing in his enclosure.");
        }

        public void Yawn()
        {
            Console.WriteLine("He's yawning.");
        }

        public void Play()
        {
            Console.WriteLine("He's playing.");
        }
    }
}
