using opdracht_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static opdracht_2.Trainer;

namespace opdracht_3
{
    public class Squirtle : Pokemon
    {
        public enum Sort
        {
            Charmander,
            Squirtle,
            Bulbasaur
        }

        public Squirtle(string name, Ty strength, string weakness, string type) : base(name, strength, weakness, type)
        {
            this.Type = "Squirtle";

        }

        public override void battle_cry()
        {
            Console.WriteLine(this.Type+" "+this.Name + " is zijn Battlecry aan het doen O<>O " + this.Strength);


        }
    }
}
