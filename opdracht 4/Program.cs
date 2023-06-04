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
                trainer1.make_pokemon(trainer1,st ,char_name );
                trainer2.make_pokemon(trainer2,st ,char_name );


            }
            Random ran = new Random();
            Random ran2 = new Random();



            for (int i = 0; i < 6; i++)
            {
                Arena.arena.setRounds(i + 1);

                Console.WriteLine(trainer1.TrainerName+" score: " +Arena.arena.Trainer1_score);
                Console.WriteLine(trainer2.TrainerName+" score: " +Arena.arena.Trainer2_score);

                var pokes = trainer1.get_belt().Where(p => p.ready == true).ToList();
                var pokes2 = trainer2.get_belt().Where(p => p.ready == true).ToList();
                // trainer 1: 
                Console.WriteLine(" ");
                Console.WriteLine(trainer1.TrainerName + $" is Throwing his ball number :{i + 1} ");


                Console.WriteLine(trainer2.TrainerName + $" is Throwing his ball number :{i + 1} ");

                var x = pokes[ran.Next(0,pokes.Count)];
                var y = pokes2[ran.Next(0,pokes2.Count)];

                Arena.arena.clash(trainer1.throw_ball(x), trainer2.throw_ball(y));

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











