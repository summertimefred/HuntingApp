using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HuntingApp
{
    class GameEngine
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();


        public Animal HuntAnimal()
        {
            int r = GetRandomNumber();

            //create a fish object to return;
            Animal animal = new Animal();

            if (r == 1) // Bass and 10 points
            {
                animal.AnimalType = "Coyote";
                animal.Points = 10;
                animal.DamageDealt = 10;
            }
            else if (r == 2) //
            {
                animal.AnimalType = "Rabbit";
                animal.Points = 2;
                animal.DamageDealt = 1;
            }
            else if (r == 3)
            {
                animal.AnimalType = "Wolf";
                animal.Points = 20;
                animal.DamageDealt = 20;
            }
            else if (r == 4)
            {
                animal.AnimalType = "Squirrel";
                animal.Points = 5;
                animal.DamageDealt = 2;
            }
            else if (r == 5)
            {
                animal.AnimalType = "Bear";
                animal.Points = 30;
                animal.DamageDealt = 20;
            }
            else
            {
                animal.AnimalType = "NO Animal!";
                animal.Points = 0;
            }



            return animal;
        }

        public static int GetRandomNumber()
        {
            Random randomNum = new Random();
            //lock (syncLock)
            //{ // synchronize
            //    return random.Next(1, 8);
            //}
            Thread.Sleep(1000);
            int i = randomNum.Next(1, 8);
            return i;
        }
    }
}
