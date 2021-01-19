using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")};

            Console.WriteLine("###############");
            Console.WriteLine();

            foreach (var animal in animals)
            {
                if (animal is Dog)
                {
                    var bonklas = new Bonklas("Bonklas");
                    bonklas.ChangeAnimalOwned("The dog named Doge");
                    Console.WriteLine(bonklas._animalThatIsOwned + " is now owned by " + bonklas._owner);
                    
                }

                animal.Eat();
                animal.Sleep();
                animal.Speak();
                animal._color = "Grey";
                Console.WriteLine(animal.GetType().Name + " is " + animal._color);
                Console.WriteLine();

                Console.WriteLine("###############");
                Console.WriteLine();
            }
        }
    }
}
