﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    public class Bulbasaur : Pokemon
    {

        public Bulbasaur(string name, string strength, string weakness, string type) : base(name, strength, weakness, type)
        {
            this.type = "Bulbasaur";

        }
        public override void battle_cry()
        {
            Console.WriteLine(this.type + " " + this.name + " is zijn Battlecry aan het doen O<>O " + this.strength);


        }
    }
}
