using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    public class Squirtle : Pokemon
    {

        public Squirtle(string name, string strength, string weakness, string type) : base(name, strength, weakness, type)
        {

        }
        public override void battle_cry()
        {
            Console.WriteLine(this.type+" "+this.name + " is zijn Battlecry aan het doen O<>O " + this.strength);


        }
    }
}
