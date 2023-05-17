﻿using System.Collections.Generic;
using System.Xml.Linq;

namespace opdracht_2;

public class Program {

 

    public static void Main(string[] args)
    {
        bool game = true;
        while (game =true)
        {
            Trainer trainer1 = createTrainer();
            Trainer trainer2 = createTrainer();


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("wat is je Charmander's naam?");
                string char_name = Console.ReadLine();
                Console.WriteLine(trainer1.add_poke_ball(new PokeBall(new Charmander(char_name, "fire", "water"))));
                Console.WriteLine(trainer2.add_poke_ball(new PokeBall(new Charmander(char_name, "fire", "water"))));
            }
            /*to do the trainer throws the ball*/
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(trainer1.TrainerName + $" is Throwing his ball number :{i + 1} ");
                trainer1.throw_ball(i);

                Console.WriteLine(trainer2.TrainerName + $" is Throwing his ball number :{i + 1} ");
                trainer2.throw_ball(i);


                Console.WriteLine(trainer1.TrainerName + $" is retrieving his ball number :{i + 1} ");
                Console.WriteLine(trainer2.TrainerName + $" is retrieving his ball number :{i + 1} ");
            }
            Console.WriteLine("do you still wanna play?(Y/N)");
            string vraag = Console.ReadLine();
            if ( vraag == "Y")
            {
                game = true;
            }
            else {
                game = false; break;
            }
        }
        
    }

    public static Trainer createTrainer() {
        Console.WriteLine("what is the name of the first Trainer? ");
        string a1 = Console.ReadLine();
        return new Trainer(a1);

    }
}
















