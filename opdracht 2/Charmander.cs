using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    public class Charmander
    {
        public string name;
        public string strength;
        public string weakness;

        public Charmander(string name, string strength, string weakness)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
        }

        public void battle_cry()
        {
                Console.WriteLine(this.name + " is zijn Battlecry aan het doen O<>O ");


        }

    }
}
