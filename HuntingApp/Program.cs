using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Print welcome message and ask for Username
            //printing Welcome message
            Console.WriteLine("====================================");
            Console.WriteLine("WELCOME TO THE HUNTING GAME");
            Console.WriteLine("BY: FRED");
            Console.WriteLine("====================================");

            //ask user for their username
            Console.WriteLine("What is your Username?");

            //making a variable userInput and capturing the data from the user
            string userInput = Console.ReadLine();

            //Print out the user name
            Console.WriteLine("Hello:" + userInput);

            #endregion

            #region Create Player object and set score to 0
            //created a new instance of Player and set the Username and print out
            Player player1 = new Player();
            player1.Username = userInput;
            player1.Score = 0;

            Console.WriteLine("player1 Username:" + player1.Username);
            Console.WriteLine("player1 Score:" + player1.Score);

            #endregion


            GameEngine game = new GameEngine();

            for(int i = 1; i<=10; i++)
            {
                Animal animal1 = game.HuntAnimal();

                Console.WriteLine("animal" + i + " AnimalType:" + animal1.AnimalType);
                Console.WriteLine("animal" + i + " Points:" + animal1.Points);
                Console.WriteLine("animal" + i + " Damage Dealt:" + animal1.DamageDealt);

                //add fish points to Player Score
                player1.Score = player1.Score + animal1.Points;
                Console.WriteLine("player" + i + " Score:" + player1.Score);

                player1.Health = player1.Health - animal1.DamageDealt;
                Console.WriteLine("player" + i + " Health:" + player1.Health);

                if (player1.Health <= 0) {
                    Console.WriteLine("YOU DIED!!!!!!!");
                    break;
                }


            }


            Console.WriteLine("************************************************");
            Console.WriteLine("FINAL REPORT CARD");
            Console.WriteLine("-----------------");
            Console.WriteLine("Score:" + player1.Score);
            Console.WriteLine("Health:" + player1.Health);

            if (player1.Health <= 0)
            {
                Console.WriteLine("YOU DIED!!!!!!!");
            }

            //Animal animal1 = game.HuntAnimal();

            //Console.WriteLine("animal1 FishType:" + animal1.AnimalType);
            //Console.WriteLine("animal1 Points:" + animal1.Points);

            ////add fish points to Player Score
            //player1.Score = player1.Score + animal1.Points;
            //Console.WriteLine("player1 Score:" + player1.Score);



            ////GameEngine game2 = new GameEngine();
            //Animal animal2 = game.HuntAnimal();

            //Console.WriteLine("animal2 FishType:" + animal2.AnimalType);
            //Console.WriteLine("animal2 Points:" + animal2.Points);



            ////add fish points to Player Score
            //player1.Score = player1.Score + animal2.Points;
            //Console.WriteLine("player1 Score:" + player1.Score);


        }
    }
}
