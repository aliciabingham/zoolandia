using System;

namespace Zoolandia.Animals
{
    public class PlatynotaReptilia: Animal
    {

        public PlatynotaReptilia ()
        {
            this.name = "Second Lizard";
        }

        public string IsMammal { get; set; }
        public override void Mammal ()
        {
            base.Mammal();
            Console.WriteLine("This animal is not a mammal.");
        }
    }
}