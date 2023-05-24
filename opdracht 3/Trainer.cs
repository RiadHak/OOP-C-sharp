using opdracht_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    public class Trainer
    {
        private string _trainer_name;
        private List<PokeBall> trainer_belt = new List<PokeBall>();

        public string TrainerName { get { return _trainer_name; } set { _trainer_name = value; } }
        public Trainer(string trainer_name)
        {
            this._trainer_name = trainer_name;

        }

        public string add_poke_ball(PokeBall name)
        {
            if (trainer_belt.Count <= 5)
            {
                trainer_belt.Add(name);
                return "added";
            }
            return "belt full";
        }
        public void throw_ball(int pos)
        {
            trainer_belt[pos].open_ball();

        }
        public void del_pok(int pos)
        {
            return;
        }


        // addPokeball(Pokeball pokeball) { }
    }
}
