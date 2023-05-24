using opdracht_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    public class PokeBall
    {
        private Pokemon? _name;

        public Pokemon PokemoneName { get { return _name; } set { _name = value; } }



        public PokeBall(Pokemon name)
        {
            this._name = name;
        }

        public Pokemon open_ball()
        {
            _name.battle_cry();
            return _name;
        }



    }
}

