using System;

namespace Zoolandia.Animals 
{
    public class EquusZebra : Animal
    {
        public EquusZebra ()
        {
            this.name = "Second Zebra Name";
        }
        public string IsStriped { get; set; }

        public override void Mammal ()
        {
            base.Mammal();
            Console.WriteLine("This animal is a mammal that is usually striped.");
        }
    }
}