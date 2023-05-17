using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    public class PokeBall
    {
        private Charmander? _name;
        public Charmander PokemoneName { get { return _name; } set { _name = value; } }



        public PokeBall(Charmander name)
        {
            this._name = name;
        }

        public Charmander open_ball()
        {
            _name.battle_cry();
            return _name;
        }



    }
}

