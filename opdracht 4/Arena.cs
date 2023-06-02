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
        private Battle fight;
        private int rounds;
        private int Score_Trariner1;
        private int Score_Trariner2;



        public void clash(Pokemon t1, Pokemon t2)
        {
            this.fight.battle_simulator(t1,t2);
        }





        public int getRounds()
        {
            return rounds;
        }

        public void setRounds(int rounds)
        {
            this.rounds = rounds;
        }

        public int getTrariner1()
        {
            return Score_Trariner1;
        }
        public int setTrainer(int trariner1)
        {

        }



    }
}
