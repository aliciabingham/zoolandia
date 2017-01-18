using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var MargaretHamilton = new WeinusCaninus();

            MargaretHamilton.IsSuperLong = "yes";
            MargaretHamilton.name = "Margaret Hamilton";
            MargaretHamilton.type = "weiner dog";
            
            Console.WriteLine($"I have a {MargaretHamilton.type} named {MargaretHamilton.name}. When asked if she was really long, the vet said {MargaretHamilton.IsSuperLong}.");

            var Zebra = new EquusZebra();

            Zebra.IsStriped = "not striped";
            Zebra.name = "Rodney";
            Zebra.color = "orange";

            Console.WriteLine($"I went to the zoo and saw a zebra named {Zebra.name}. Incredibly, he was {Zebra.IsStriped}, and I think he was painted {Zebra.color}.");

            var Lizard = new PlatynotaReptilia();

            Lizard.IsMammal = "not mammals";
            Lizard.name = "Rex";
            Lizard.color = "green";

            Console.WriteLine($"The zoo also had a {Lizard.color} lizard named {Lizard.name}. Lizards in general are {Lizard.IsMammal}.");
            
            PlatynotaReptilia Lizard2 = new PlatynotaReptilia();
            Console.WriteLine(Lizard2.name);

            WeinusCaninus Doggo2 = new WeinusCaninus();
            Console.WriteLine(Doggo2.name);

            EquusZebra Zebra2 = new EquusZebra();
            Console.WriteLine(Zebra2.name);

            var Lizard3 = new PlatynotaReptilia("Sammy");
            Console.WriteLine(Lizard3.actualName);

            var Doggo3 = new WeinusCaninus(200000);
            Console.WriteLine("This dachsund is " + Doggo3.actualLength + " inches long.");

            var Zebra3 = new EquusZebra(3, "red");
            Console.WriteLine("My feelings are " + Zebra3.feelings + " " + Zebra3.feelings2);

        }
    }
}
