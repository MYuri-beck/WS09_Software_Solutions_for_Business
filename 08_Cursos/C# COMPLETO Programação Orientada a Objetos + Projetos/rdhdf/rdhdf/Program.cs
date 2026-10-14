using System;
using System.Collections.Generic;
using System.Text;

namespace Herenca01
{
     class Program
    {
        static void Main(string[] args)
        {
            // Create a list of animals
            List<Animal> animals = new List<Animal>();
            // Add some animals to the list
            animals.Add(new Dog("Buddy", 3));
            animals.Add(new Cat("Whiskers", 2));
            animals.Add(new Dog("Max", 5));
            animals.Add(new Cat("Luna", 1));
            // Iterate through the list and make each animal speak
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Speak());
            }
        }
    }
}
