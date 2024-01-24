using opdracht_3;
using opdracht_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static opdracht_2.Trainer;

namespace opdracht_2
{
    public class Trainer
    {
        private string _trainer_name;
        private readonly List<PokeBall> trainer_belt = new List<PokeBall>();

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
            if (trainer_belt.Count > 6)
            {
                throw new ArgumentOutOfRangeException("The belt should not has more than 6 pokeballs");
            }
            return "belt is filled"; // throw an exception}


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


        public enum Ty
        {
            fire,
            water,
            grass
        }
        public void make_pokemon(Trainer train, string char_name)
        {
            Random rnd = new Random();

            int number = rnd.Next(0, 2);

            if (number == 0)
            {
                Console.WriteLine(train.add_poke_ball(new PokeBall(new Charmander(char_name, Ty.fire, "water", " "), true)));

            }
            else if (number == 1)
            {
                Console.WriteLine(train.add_poke_ball(new PokeBall(new Squirtle(char_name, Ty.water, "grass", " "), true)));

            }
            else if (number == 2)
            {
                Console.WriteLine(train.add_poke_ball(new PokeBall(new Bulbasaur(char_name, Ty.grass, "fire", " "), true)));

            }
        }
    }
}
