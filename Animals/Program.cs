using System;
using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Zoo WeBoughtAZoo = new Zoo();

            Weinus Maggie = new Weinus();
            Maggie.name = "Maggie";
            Maggie.color = "black";
            Maggie.IsLoooooooong = true;

            List<Animal> ZooAnimals = new List<Animal>();
            ZooAnimals.Add(Maggie);
            ZooAnimals.Add(
                new Weinus() {
                    name = "Zeus",
                }
            );

            WeBoughtAZoo.ZooAnimals = ZooAnimals;


            Equus Zebra = new Equus();
            Zebra.name = "Zebra";


            List<Animal> inhabitants = new List<Animal>();
            inhabitants.Add(Zebra);
            inhabitants.Add(
            new Equus() {
                name = "Zebra2",
            }
        );

        Habitats ShortGrassPrairie = new Prairie();

        ShortGrassPrairie.inhabitants = inhabitants;

        Console.WriteLine("Animals that are in the Prairie are:");
        foreach (Animal inhabs in inhabitants) 
        {
            Console.WriteLine(inhabs.name);
        }

            Console.WriteLine("Animals that have a habitat in my house are:");
            foreach (Animal zooanimals in ZooAnimals)
            {
                Console.WriteLine(zooanimals.name);
            }

        }
    }
}
