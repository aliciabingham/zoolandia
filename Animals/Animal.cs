using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name { get; set; }

        public string type { get; set; }

        public string color { get; set; }

        public virtual void Mammal ()
        {
            Console.WriteLine("This animal is a mammal.");
        }
    }
}