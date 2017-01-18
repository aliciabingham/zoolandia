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

        public EquusZebra (int feelings, string feelings2)
        {
            this.feelings = feelings;
            this.feelings2 = feelings2;
        }

        public override void Mammal ()
        {
            base.Mammal();
            Console.WriteLine("This animal is a mammal that is usually striped.");
        }
    }
}