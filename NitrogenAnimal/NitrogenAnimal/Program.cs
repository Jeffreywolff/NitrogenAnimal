using System;
using System.Collections.Generic;

namespace NitrogenAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            Console.WriteLine("Welcome to the zoo, shop animals and Accessories: \n");

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Choose an Animal: \n" +
                "1. Giraffe \n" +
                "2. Gorilla \n" +
                "3. Panda \n" +
                "4. Go to Accessories");
                int coice = Convert.ToInt32(Console.ReadLine());

                switch (coice)
                {
                    case 1:
                        Giraffe giraffe = new Giraffe();
                        model.animals.Add(giraffe);
                        break;
                    case 2:
                        Gorilla gorilla = new Gorilla();
                        model.animals.Add(gorilla);
                        break;
                    case 3:
                        Panda panda = new Panda();
                        model.animals.Add(panda);
                        break;
                    case 4:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid Input");
                        break;
                }
            }



            


        }
    }



    class Model
    {
        public List<Animal> animals = new List<Animal>();
        public List<Accessories> accessories = new List<Accessories>();
    }


     abstract class Animal
    {
        public void Defecate()
        {
            Console.WriteLine("Made a poo");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping, Zzz");
        }

        public abstract void Consuming();

        public abstract void AnimalSound();

        public string Color { get; set; }
        public double Intelligence { get; set; }
    }


    class Giraffe : Animal
    {
        public override void Consuming()
        {
            Console.WriteLine("Prefers consuming leaves");
        }

        public override void AnimalSound()
        {
            Console.WriteLine("What does the Giraffe say?");
        }

        
    }
    class Gorilla : Animal
    {
        public override void Consuming()
        {
            Console.WriteLine("Prefers consuming fruit and berries");
        }

        public override void AnimalSound()
        {
            Console.WriteLine("OoO OoO AH AH");
        }
    }
    class Panda : Animal
    {
        public override void Consuming()
        {
            Console.WriteLine("Prefers Bambu");
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Rawr...");
        }
    }

    abstract class Accessories
    {
        public abstract void Open();

        public abstract void Explode();

        public string Color{ get; set; }

        public double Intelligence { get; set; }
    }

    class Leash : Accessories
    {
        public override void Open()
        {
            Console.WriteLine("Leash is open");
        }

        public override void Explode()
        {
            Console.WriteLine("Leash Exploded");
        }
    }
    class FoodBag : Accessories
    {
        public override void Open()
        {
            Console.WriteLine("Foodbag is open");
        }

        public override void Explode()
        {
            Console.WriteLine("Foodbag Exploded");
        }
    }
    class AnimalHouse : Accessories
    {
        public override void Open()
        {
            Console.WriteLine("Animal House is open");
        }

        public override void Explode()
        {
            Console.WriteLine("Animal House Exploded");
        }
    }
    class Schampoo : Accessories
    {
        public override void Open()
        {
            Console.WriteLine("Schampoo is open");
        }

        public override void Explode()
        {
            Console.WriteLine("Schampoo Exploded");
        }
    }
    class DrugBox : Accessories
    {
        public override void Open()
        {
            Console.WriteLine("Drugbox is open");
        }

        public override void Explode()
        {
            Console.WriteLine("Drugbox Exploded");
        }
    }
    class Toothpaste : Accessories
    {
        public override void Open()
        {
            Console.WriteLine("Toothpaste is open");
        }

        public override void Explode()
        {
            Console.WriteLine("Thoothpaste Exploded");
        }
    }







}






