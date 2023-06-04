using opdracht_3;
using opdracht_4;
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
        public Pokemon throw_ball(PokeBall pos)
        {   
            if(pos.ready == true) {return pos.open_ball(); }
            else {return pos.open_ball();}
            
            
        }
        public void del_pok(int pos)
        {
            return;
        }
        public List<PokeBall> get_belt()
        {
            return trainer_belt;
        }

        // addPokeball(Pokeball pokeball) { }




        public void make_pokemon(Trainer train, string ty, string char_name)
        {
            if (ty == "fire")
            {
                Console.WriteLine(train.add_poke_ball(new PokeBall(new Charmander(char_name, ty, "water", " "), true)));

            }
            else if (ty == "water")
            {
                Console.WriteLine(train.add_poke_ball(new PokeBall(new Squirtle(char_name, ty, "grass", " "), true)));

            }
            else if (ty == "grass")
            {
                Console.WriteLine(train.add_poke_ball(new PokeBall(new Bulbasaur(char_name, ty, "fire", " "), true)));

            }
        }
    }
}
