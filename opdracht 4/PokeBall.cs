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
        public bool ready;



        public PokeBall(Pokemon name, bool ready)
        {
            this._name = name;
            this.ready = ready;
        }

        public Pokemon open_ball()
        {
            this.ready = false;
            _name.battle_cry();
            return _name;
        }
        public void ball_not_ready()
        {
            Console.WriteLine("ball is not ready!");
        }



    }
}

