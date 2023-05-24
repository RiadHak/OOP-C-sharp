using opdracht_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4
{
    public class Pokemon_battle_simulator
    {
        //List<string> charm = new List<string>();
        //List<string> squirtle = new List<string>();
        //List<string> bull = new List<string>();

        //private string charm;
        //private string squirte;
        //private string bull;




        public int returnWinner(string p1 , string p2 , string p3)
        {
            if (p1 == p3)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }



        public int battle_simulator(Pokemon fighter1, Pokemon fighter2)
        {


            if(fighter1.strength == "fire" && fighter2.strength == "water" || fighter1.strength == "water" && fighter2.strength == "fire")
            {
                return returnWinner(fighter1.strength,fighter2.strength, "water");
               
                
            }
            else if(fighter1.strength == "fire" && fighter2.strength == "grass" || fighter1.strength == "grass" && fighter2.strength == "fire")
            {
                return returnWinner(fighter1.strength,fighter2.strength, "fire");

            }
            else if (fighter1.strength == "water" && fighter2.strength == "grass" || fighter1.strength == "grass" && fighter2.strength == "water")
            {
                return returnWinner(fighter1.strength, fighter2.strength, "grass");

            }
            else
            {
                return 3;
            }

        }
    }
}

