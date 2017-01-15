using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name { get; set; }

        public string type { get; set; }

        public string color { get; set; }

    }

    class EquusZebra : Animal
    {
        public string IsStriped { get; set; }
    }

    class WeinusCaninus: Animal 
    {
        public string IsSuperLong { get; set; }
    }

    class PlatynotaReptilia: Animal
    {
        public string IsMammal { get; set; }
    }
}