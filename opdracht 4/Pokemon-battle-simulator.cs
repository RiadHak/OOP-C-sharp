using opdracht_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static opdracht_2.Trainer;

namespace opdracht_4
{
    public class Pokemon_battle_simulator
    {

        public int returnWinner(string p1 , string p2 , string p3)
        {
            if (p1 == p3)
            {
                Console.WriteLine("player 1 wins");

                return 1;
            }
            else
            {
                Console.WriteLine("player 2 wins");

                return 2;
            }
        }



        public int battle_simulator(Pokemon fighter1, Pokemon fighter2)
        {


            if(fighter1.Strength == Ty.fire && fighter2.Strength == Ty.water || fighter1.Strength == Ty.water && fighter2.Strength == Ty.fire)
            {
                return returnWinner(fighter1.Strength,fighter2.Strength,Ty.water);
               
                
            }
            else if(fighter1.Strength == Ty.fire && fighter2.Strength == Ty.grass || fighter1.Strength == Ty.grass && fighter2.Strength == Ty.grass)
            {
                return returnWinner(fighter1.Strength,fighter2.Strength, Ty.fire);
                    
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

        private int returnWinner(Ty strength1, Ty strength2, Ty water)
        {
            throw new NotImplementedException();
        }
    }
}

