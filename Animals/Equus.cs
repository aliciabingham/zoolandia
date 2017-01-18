using System;

namespace Zoolandia.Animals 
{
    public class Equus : Animal
    {

        public string isStriped { get; set; }

        public int milesPerHour { get; set; }



        public class Zebra : Equus
        {

        }

        public class Horse : Equus
        {

        }


    }
}