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


            foreach (Animal zooanimals in ZooAnimals)
            {
                Console.WriteLine(zooanimals.name);
            }

        }
    }
}
