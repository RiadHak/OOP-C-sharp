using opdracht_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4
{
    public class Arena
    {
        private Battle fight = new Battle();
        private int rounds;
        private static int Score_Trainer1;
        private static int Score_Trainer2;
        public readonly string gameName = "Welcome to the pokemone game";


        public Battle Fight { get { return fight; } set { fight = value; } }
        public int Rounds { get {  return rounds; } set {  rounds = value; } }

        public int Trainer1_score { get { return Score_Trainer1;} set { Score_Trainer1 = value;} }
        public int Trainer2_score { get { return Score_Trainer2;} set { Score_Trainer2 = value;} }





        public static Arena arena = new Arena();
        
        private Arena() { }

        public void clash(Pokemon t1, Pokemon t2)
        {
            fight.battle_simulator(t1,t2);
        }

        public int getRounds()
        {
            return rounds;
        }

        public void setRounds(int rounds)
        {
            this.rounds = rounds;
            Console.WriteLine("Round :"+this.Rounds +" FIGHT!");
        }

        public void return_winner()
        {
            if(this.Trainer1_score > this.Trainer2_score)
            {
                Console.WriteLine("Player 1 WINS THE GAME!");
            }
            if (this.Trainer2_score > this.Trainer1_score)
            {
                Console.WriteLine("Player 2 WINS THE GAME!");
            }
            else if(this.Trainer1_score == this.Trainer2_score)
            {
                Console.WriteLine("Game over it's a DRAW!");
            }

         }
   
    }
}
