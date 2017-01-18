using System;

namespace Zoolandia.Animals 
{
    public class WeinusCaninus: Animal 
    {
        public WeinusCaninus () 
        {
            this.name = "Second Doggo Name";
        }

        public WeinusCaninus (int actualLength) 
        {
            this.actualLength = actualLength;
        }
        public string IsSuperLong { get; set; }
        public override void Mammal ()
        {
            base.Mammal();
            Console.WriteLine("This animal is an extremely long mammal.");
        }
    }
}