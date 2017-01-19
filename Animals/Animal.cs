using System;
using System.Collections.Generic;

namespace Zoolandia.Animals
{
    public class Animal : IMammal
    {
        public string name { get; set; }

        public string type { get; set; }

        public string color { get; set; }

        public string sleepHabits { get; set; }

        public string typeOfFood { get; set; }

        public bool Long()
        {
            return true;
        }

        public void Run()
        {
            Console.WriteLine("Waddling, but slowly.");
        }

        public void Fetch()
        {
            Console.WriteLine("Not yet.");
        }

    }
}