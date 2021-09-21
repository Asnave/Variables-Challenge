using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string gameTitle;
            gameTitle = "The Legend Of Thyme";
            Console.WriteLine(gameTitle);


            Console.WriteLine("");


            // Game Factors ------

            int cookingPoints;
            cookingPoints = 100;

            int damage;
            damage = 0;

            float shieldDamage;
            shieldDamage = 0;

            float multiplier;
            multiplier = 0;

            int cookingExperience;
            cookingExperience = 0;




            //Score ---------

            int score;
            score = 0;

            score = score + cookingPoints;
            Console.WriteLine("Score: " + score);

            // Health -----

            int health;
            health = 10;
            health = health + damage;
            Console.WriteLine("Health: " + health);

            // Shield -------

            float shield;
            shield = 100;
            shield = shield / shieldDamage;
            Console.WriteLine("Shield Percatage: " + shield);

            // Lives -------

            int lives;
            lives = 3;

            if (health < 10)
            {
                lives = lives - 1;

            }

            Console.WriteLine("Lives:" + lives);

            // Multiplier / experience points  --------


            Console.WriteLine("XP Multiplier: " + multiplier);

            float experiencePoints;
            experiencePoints = 0;

            experiencePoints = experiencePoints + cookingExperience;
            experiencePoints = experiencePoints * multiplier;

            Console.WriteLine("ExperiencePoints: " + experiencePoints);

            Console.WriteLine("You wake up in a kitchen, a note on the counter states:" +
                " for you to pass you must cook your first dish...");

            Console.WriteLine("");

            // Game Factors ------

         
            cookingPoints = 100;

            
            damage = -5;

            
            shieldDamage = 2;

            
            multiplier = 3.0f / 2.0f ;

            
            cookingExperience = 10;



            
            //Score ---------

            
            score = 0;

            score = score + cookingPoints;
            Console.WriteLine("Score: " + score);

            // Health -----

            
            health = 10;
            health = health + damage;
            Console.WriteLine("Health: " + health);

            // Shield -------

            
            shield = 100;
            shield = shield / shieldDamage;
            Console.WriteLine("Shield Percatage: "+ shield);

            // Lives -------

            
            lives = 3;

            if (health < 10) 
            {
                lives = lives - 1;
                
            }

            Console.WriteLine("Lives:" + lives);

            // Multiplier / experience points  --------


            Console.WriteLine("XP Multiplier: " + multiplier);

            
            experiencePoints = 0;

            experiencePoints = experiencePoints + cookingExperience;
            experiencePoints = experiencePoints * multiplier;

            Console.WriteLine("ExperiencePoints: " + experiencePoints);

            Console.WriteLine(" ");
            Console.WriteLine("As you finsished your last dish you notice : " +
                "You gained 100 cookig points" +
                "your took -5 damange" +
                "your Frying Pan shield took half its damage" +
                "Your Experience Points grew to + 15 with your XP Multiplier engaged");


            Console.ReadKey(true);

        }
    }
}
