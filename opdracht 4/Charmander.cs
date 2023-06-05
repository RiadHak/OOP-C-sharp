using opdracht_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    public class Charmander : Pokemon
    {

        public Charmander(string name, string strength, string weakness, string type) : base(name, strength, weakness, type)
        {
            this.type = "Charmander";
        }
        public override void battle_cry()
        {
            Console.WriteLine(this.type + " " + this.name + " is zijn Battlecry aan het doen O<>O "+this.strength);

        }

    }
}
