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

            Console.ReadKey(true);

            Console.WriteLine("");


            // Game Factors ------

            int cookingPoints;
            cookingPoints = 0;

            int damage;
            damage = 0;

            float shieldDamage;
            shieldDamage = 0;

            float multiplier;
            multiplier = 0;

            int cookingExperience;
            cookingExperience = 0;








            //Score ---------
            Console.WriteLine("---------HUD---------");
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


            // Lives -------

            int lives;
            lives = 3;



            Console.WriteLine("Lives:" + lives);

            // Multiplier / experience points  --------




            float experiencePoints;
            experiencePoints = 0;

            experiencePoints = experiencePoints + cookingExperience;
            experiencePoints = experiencePoints * multiplier;

            Console.WriteLine("ExperiencePoints: " + experiencePoints);
            Console.WriteLine("---------------------");
            Console.WriteLine("");

            Console.WriteLine("You wake up in a kitchen, a note on the counter states:" +
                " for you to pass you must cook your first dish...");
            Console.WriteLine("press any key to start....");
            Console.ReadKey(true);
            Console.WriteLine("");


            // Game Factors ------


            cookingPoints = 0;


            damage = -5;


            shieldDamage = 0;


            multiplier = 0;


            cookingExperience = +10;




            //Score ---------

            Console.WriteLine("---------HUD---------");
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


            // Lives -------




            Console.WriteLine("Lives:" + lives);

            // Multiplier / experience points  --------





            experiencePoints = 0f;

            experiencePoints = experiencePoints + cookingExperience;


            Console.WriteLine("ExperiencePoints: " + experiencePoints);
            Console.WriteLine("---------------------");
            Console.WriteLine("");

            Console.WriteLine("You begin with cutting the vegetables laid out in the rustic looking pantry,");
            Console.WriteLine(" unfortunitly for you,");
            Console.WriteLine("you notice the lack of experience points you have in cooking.");
            Console.WriteLine("daydreaming, you mistaken your finger to be one of the carrots, cutting the tip clean off.");
            Console.WriteLine("Taking -5 Damage");
            Console.WriteLine("Gaining +5 experience points knowing you wont make that mistake again....");
            Console.WriteLine("");
            Console.ReadKey(true);

            // Game Factors ------


            cookingPoints = +5;


            damage = -5;


            shieldDamage = 2f;


            multiplier = 0f;


            cookingExperience = +10;




            //Score ---------

            Console.WriteLine("---------HUD---------");
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
            Console.WriteLine("FryingPan Percatage: " + shield);

            // Lives -------




            Console.WriteLine("Lives:" + lives);

            // Multiplier / experience points  --------





            experiencePoints = 0;

            experiencePoints = experiencePoints + cookingExperience;


            Console.WriteLine("ExperiencePoints: " + experiencePoints);
            Console.WriteLine("---------------------");
            Console.WriteLine("");

            Console.WriteLine("Looking around you found a frying pan,");
            Console.WriteLine("Weilding the frying pan allows you to saute the now cut vegtables");
            Console.WriteLine("not really kowing what your doing, you start burning everything, including the pan.");
            Console.WriteLine("Fortunitly it shielded the hot oils from your eyes with the cover");
            Console.WriteLine("Your Frying Pan taking half its utillity Percentage.");
            Console.WriteLine("Gaining +5 Cooking points to your Score for cleaverness.");
            Console.WriteLine("");
            Console.ReadKey(true);

            // Game Factors ------


            cookingPoints = 25;


            damage = -5;


            shieldDamage = 2;


            multiplier = 3.0f / 2.0f;


            cookingExperience = 15;




            //Score ---------

            Console.WriteLine("---------HUD---------");
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
            Console.WriteLine("Shield Percatage: " + shield);

            // Lives -------




            Console.WriteLine("Lives:" + lives);

            // Multiplier / experience points  --------


            Console.WriteLine("XP Multiplier: " + multiplier);


            experiencePoints = 0;

            experiencePoints = experiencePoints + cookingExperience;
            experiencePoints = experiencePoints * multiplier;

            Console.WriteLine("ExperiencePoints: " + experiencePoints);
            Console.WriteLine("---------------------");
            Console.WriteLine("");

            Console.WriteLine("Now to the protine!");
            Console.WriteLine("Taking the obvious choice of chicken, needing to butcher it first");
            Console.WriteLine("You take the best part of the meat, spitting it over a fire till you get medieval style rotisserie.");
            Console.WriteLine("picking through the scraps you find one of the legs of the chicken, finding out its a charm of sorts");
            Console.WriteLine("Granting you with a small XP Multiplier!");
            Console.WriteLine("You gain +20 cooking points for the lack of chaos");
            Console.WriteLine("You gain +5 Experience points");
            Console.WriteLine("");
            Console.ReadKey(true);

            // Game Factors ------


            cookingPoints = 100;


            damage = -5;


            shieldDamage = 2;


            multiplier = 3.0f / 2.0f;


            cookingExperience = 30;




            //Score ---------

            Console.WriteLine("---------HUD---------");
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
            Console.WriteLine("Shield Percatage: " + shield);

            // Lives -------


            lives = 3;

            if (health <= 0)
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

            // Level------------

            int Level;
            Level = 1;

            if (experiencePoints >= 40)
            {
                Level = Level + 1;
            }

            Console.WriteLine("Level: " + Level);


            Console.WriteLine("---------------------");

            Console.WriteLine(" ");
            Console.WriteLine("As you finsished your dish you notice : ");
            Console.WriteLine("");
            Console.WriteLine("A door starts to open allowing you to leave, ");
            Console.WriteLine("With that you gain +100 cooking points");
            Console.WriteLine("Aswell as +15 XP");
            Console.WriteLine("");


            Console.ReadKey(true);
        }
    }
}
