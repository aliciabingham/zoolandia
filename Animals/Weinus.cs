using System;

namespace Zoolandia.Animals 
{
    public class Weinus : Animal 
    {
        public bool IsMammal { get; set; }

        public bool IsDog { get; set; }

        public bool IsLoooooooong { get; set; }



        public class Caninus : Weinus
        {
            public string softBelly { get; set; }
        }

        public class Feline : Weinus
        {

        }
    }
}