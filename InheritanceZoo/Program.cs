using System;


namespace InheritanceZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inheritance Zoo!");

            Reptile Horatio = new Reptile();
            Reptile Frank = new Reptile();    //declaring the reptiles in our zoo
            Reptile Morris = new Reptile();

            Reptile[] reptiles = { Horatio, Morris, Frank }; //an array of all our reptiles

            Console.WriteLine("Here come our lizards!");

            for(int i=0; i<reptiles.Length;i++)
            {
                Console.WriteLine("Hiss!"); //all of our reptiles will do a noise
            }
            Horatio.IntroReptile(); //specific methods from reptile class
            Horatio.Sunbathe();
            Horatio.Eat(); //generic inherited animal method

            Console.WriteLine("Next, let's see some of the parrots.");

            Avian Paco = new Avian();
            Avian Baby = new Avian();  //declaring birds in our zoo
            Avian Skipper = new Avian();

            Avian[] birds = { Paco, Skipper, Baby }; //an array of all our birds

            for (int i = 0; i < birds.Length; i++)
            {
                Console.WriteLine("Caw Caw!"); //all of our birds will do a noise
            }

            Paco.IntroBird(); // Avian specific methods
            Paco.Fly();
            Paco.Play(); // inherited animal class general method

            Console.WriteLine("Let's feed Paco some seeds, it's his favorite snack.");
            Console.WriteLine("Paco ate the following number of seeds from his dish:");
            Paco.EatSeeds(); //ranomd number of seeds is generated with this method

            Console.WriteLine("Our zoo also has many mammals, including the big cats.");

            Mammal Kitty = new Mammal();
            Mammal Kitty2 = new Mammal();    //declare the cats in the zoo
            Mammal Kitty3 = new Mammal();
            Mammal Kitty4 = new Mammal();

            Mammal[] cats = { Kitty2, Kitty, Kitty3, Kitty4 }; // an array of all the cats

            for (int i = 0; i < cats.Length; i++)
            {
                Console.WriteLine("Mrowww!"); //all of our cats will do a noise
            }
            Kitty.IntroMammal(); //class specific methods
            Kitty2.Itch();
            Kitty3.Run(); //generic method inherited 
        }
        }
    }

