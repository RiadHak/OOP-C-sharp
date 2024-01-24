using opdracht_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static opdracht_2.Trainer;

namespace opdracht_3
{
    public abstract class Pokemon
    {
        private string name;
        private Ty strength;
        private string weakness;
        private string type;
        private Trainer.Ty strength1;

        public string Name { get { return name; } set { name = value; } }
        public Ty Strength { get { return strength; } set { strength = value; } }
        public string Weakness { get { return weakness; } set { weakness = value; } }
        public string Type { get { return type; } set { type = value; } }


        public Pokemon(string name, Ty strength, string weakness, string type)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
            this.type = type;
        }

  

        public abstract void battle_cry();

        // public bool isWeakAgainst(Pokemon pokemon)
        //{
        //    return this.weakness == pokemon.strength;
        //}
    }
}
