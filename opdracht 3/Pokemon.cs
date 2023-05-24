using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    public abstract class Pokemon
    {
        public string name;
        public string strength;
        public string weakness;
        public string type;
        public Pokemon(string name, string strength, string weakness, string type)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
            this.type = type;
        }
        public abstract void battle_cry();
    }
}
