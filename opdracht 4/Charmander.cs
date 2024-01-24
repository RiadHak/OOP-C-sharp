using opdracht_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static opdracht_2.Trainer;

namespace opdracht_2
{
    public class Charmander : Pokemon
    {

        public Charmander(string name, Ty strength, string weakness, string type) : base(name, strength, weakness, type)
        {
            this.Type = "Charmander";
        }
        public override void battle_cry()
        {
            Console.WriteLine(this.Type + " " + this.Name + " is zijn Battlecry aan het doen O<>O "+this.Strength);

        }

    }
}
