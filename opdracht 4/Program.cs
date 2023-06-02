using opdracht_3;
using opdracht_4;
using System.Collections.Generic;
using System.Xml.Linq;

namespace opdracht_2;

public class Program
{



    public static void Main(string[] args)
    {
        bool game = true;
        while (game)
        {
            Trainer trainer1 = createTrainer();
            Trainer trainer2 = createTrainer();


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("wat is je Pokemone's naam?");
                string char_name = Console.ReadLine(); 
                Console.WriteLine("wat is je Pokemone kracht?");
                string st = Console.ReadLine();
                if(st == "fire")
                {
                    Console.WriteLine(trainer1.add_poke_ball(new PokeBall(new Charmander(char_name, st, "water", " "),true)));
                    Console.WriteLine(trainer2.add_poke_ball(new PokeBall(new Charmander(char_name, st, "water", " "), true)));
                }
                else if(st == "water")
                {
                    Console.WriteLine(trainer1.add_poke_ball(new PokeBall(new Squirtle(char_name, st, "grass", " "), true)));
                    Console.WriteLine(trainer2.add_poke_ball(new PokeBall(new Squirtle(char_name, st, "grass", " "), true)));
                }
                else if (st == "grass")
                {
                    Console.WriteLine(trainer1.add_poke_ball(new PokeBall(new Bulbasaur(char_name, st, "fire", " "), true)));
                    Console.WriteLine(trainer2.add_poke_ball(new PokeBall(new Bulbasaur(char_name, st, "fire", " "), true)));
                }

            }
            Random ran = new Random();
            Random ran2 = new Random();



            for (int i = 0; i < 6; i++)
            {
                var pokes = trainer1.get_belt().Where(p => p.ready == true).ToList();
                var pokes2 = trainer2.get_belt().Where(p => p.ready == true).ToList();
                // trainer 1: 
                Console.WriteLine(" ");
                Console.WriteLine(trainer1.TrainerName + $" is Throwing his ball number :{i + 1} ");


                Console.WriteLine(trainer2.TrainerName + $" is Throwing his ball number :{i + 1} ");

                var x = pokes[ran.Next(0,pokes.Count)];
                var y = pokes2[ran.Next(0,pokes2.Count)];



                //object _value = pokes.ran.Next(0, pokes.Count);

                Battle sim = new Battle();
                 sim.battle_simulator(trainer1.throw_ball(x), trainer2.throw_ball(y));



                Console.WriteLine(trainer1.TrainerName + $" is retrieving his ball number :{i + 1} ");
                Console.WriteLine(trainer2.TrainerName + $" is retrieving his ball number :{i + 1} ");
                Console.WriteLine(" ");

            }
            Console.WriteLine("do you still wanna play?(Y/N)");
            string vraag = Console.ReadLine();
            if (vraag == "Y")
            {
                game = true;
            }
            else
            {
                game = false;
            }
        }

    }

    public static Trainer createTrainer()
    {
        Console.WriteLine("what is the name of the first Trainer? ");
        string a1 = Console.ReadLine();
        return new Trainer(a1);

    }
}











