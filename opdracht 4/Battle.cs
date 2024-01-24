using opdracht_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static opdracht_2.Trainer;

namespace opdracht_4
{
    public class Battle
    {
        private int returnWinner(Ty p1, Ty p2, Ty p3)
        {
            if (p1 == p3)
            {
                
                Console.WriteLine("player 1 wins the round");
                Arena.arena.Trainer1_score += 1;
                return 1;
            }
            else
            {
                Console.WriteLine("player 2 wins the round");
                Arena.arena.Trainer2_score += 1;

                return 2;
            }
        }



        public int battle_simulator(Pokemon fighter1, Pokemon fighter2)
        {
            if (fighter1.Strength == Ty.fire && fighter2.Strength == Ty.water || fighter1.Strength == Ty.water && fighter2.Strength == Ty.fire)
            {
                return returnWinner(fighter1.Strength, fighter2.Strength, Ty.water);


            }
            else if (fighter1.Strength == Ty.fire && fighter2.Strength == Ty.grass || fighter1.Strength == Ty.grass && fighter2.Strength == Ty.fire)
            {
                return returnWinner(fighter1.Strength, fighter2.Strength, Ty.fire);

            }
            else if (fighter1.Strength == Ty.water && fighter2.Strength == Ty.grass || fighter1.Strength == Ty.grass && fighter2.Strength == Ty.water)
            {
                return returnWinner(fighter1.Strength, fighter2.Strength, Ty.grass);

            }
            else
            {
                Console.WriteLine("draw");
                return 3;
            }

        }
    }
}
