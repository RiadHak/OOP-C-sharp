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
        private int Score_Trariner1;
        private int Score_Trariner2;

        public Battle Fight { get { return fight; } set { fight = value; } }
        public int Rounds { get {  return rounds; } set {  rounds = value; } }

        public int Trainer1_score { get { return Score_Trariner1;} set { Score_Trariner1 = value;} }
        public int Trainer2_score { get { return Score_Trariner2;} set { Score_Trariner2 = value;} }



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



    }



}
