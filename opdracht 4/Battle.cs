using opdracht_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4
{
    public class Battle
    {
        private int returnWinner(string p1, string p2, string p3)
        {
            if (p1 == p3)
            {
                Console.WriteLine("player 1 wins the round");

                return 1;
            }
            else
            {
                Console.WriteLine("player 2 wins the round");

                return 2;
            }
        }



        public int battle_simulator(Pokemon fighter1, Pokemon fighter2)
        {
            //if (fighter1.isWeakAgainst(fighter2))
            //{

            //}

            if (fighter1.strength == "fire" && fighter2.strength == "water" || fighter1.strength == "water" && fighter2.strength == "fire")
            {
                return returnWinner(fighter1.strength, fighter2.strength, "water");


            }
            else if (fighter1.strength == "fire" && fighter2.strength == "grass" || fighter1.strength == "grass" && fighter2.strength == "fire")
            {
                return returnWinner(fighter1.strength, fighter2.strength, "fire");

            }
            else if (fighter1.strength == "water" && fighter2.strength == "grass" || fighter1.strength == "grass" && fighter2.strength == "water")
            {
                return returnWinner(fighter1.strength, fighter2.strength, "grass");

            }
            else
            {
                Console.WriteLine("draw");
                return 3;
            }

        }
    }
}
