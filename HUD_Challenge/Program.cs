using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUD_Challenge
{
    internal class Program
    {
        static string studioName = "Team Void";
        static string gameTitle = "Castle Breakers";
        static string charName = "VaLLy";
        static int score = 0;
        static int exp = 0;
        static int lvl = 1;
        static int health = 100;
        static int shield = 10;
        static int lives = 3;
        static int scoreMult = 1;
        static int scorePerEnemy = 100;
        static int expPerEnemy = 25;

        static void Main(string[] args)
        {



            ShowHUD();


            Console.WriteLine("{0,32}", studioName);
            Console.WriteLine("{0,35}", gameTitle);
            Console.WriteLine("");
            Console.WriteLine($"{charName} defeated 2 enemies, but got injured several times.");
            Console.WriteLine($"+200 score, {charName} took 30 damage, but {shield} damage was blocked.");
            TakeDamage(30);
            ScoreAdded(scorePerEnemy, 2, scoreMult);
            EXPAdded(expPerEnemy, 2);
            CheckLVL(exp);
            Console.WriteLine("Your stats are now...");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();


            ShowHUD();


            Console.WriteLine("{0,32}", studioName);
            Console.WriteLine("{0,35}", gameTitle);
            Console.WriteLine("");
            Console.WriteLine($"{charName} fell in a trap in the crypt and died. {charName} restored his health");
            lives -= 1;
            health += 20;
            Console.WriteLine("");
            Console.WriteLine("Your stats are now...");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();


            ShowHUD();


            Console.WriteLine("{0,32}", studioName);
            Console.WriteLine("{0,35}", gameTitle);
            Console.WriteLine("");
            Console.WriteLine($"{charName} flawlessly defeated 5 enemies! Multiplier is raised to 5X, and {charName} found a new shiny armor from a burglar.");
            Console.WriteLine("+20 shield");
            scoreMult *= 5;
            ScoreAdded(scorePerEnemy, 5, scoreMult);
            EXPAdded(expPerEnemy, 5);
            CheckLVL(exp);
            shield += 20;
            Console.WriteLine("Your stats are now...");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();


            ShowHUD();


        }

        static void ShowHUD()
        {
            Console.WriteLine("{0,32}", studioName);
            Console.WriteLine("{0,35}", gameTitle);
            Console.WriteLine("");
            Console.WriteLine("{0,30}", charName);
            Console.WriteLine("");
            Console.WriteLine("{0,0}{1,0}{2,20}{3,0}{4,20}{5,0}", "Score: ", score, "Health: ", health, "Shield: ", shield);
            Console.WriteLine("{0,0}{1,0}{2,44}{3,0}", "Lives: ", lives, "Multiplier: ", scoreMult);
            Console.WriteLine("{0,0}{1,0}{2,46}{3,0}", "EXP: ", exp, "LVL: ", lvl);
            Console.WriteLine("");
            Console.WriteLine("Press any button...");
            Console.ReadKey();
            Console.Clear();
        }

        static int TakeDamage(int damage)
        {
            health = health + shield - damage;
            return health;
        }

        static int ScoreAdded(int pointsPerKill, int enemiesKilled, int scoreMultiplier)
        {
            score = score + pointsPerKill * enemiesKilled * scoreMultiplier;
            return score;
        }

        static int EXPAdded(int expPerKill, int enemiesKilled)
        {
            exp = exp + expPerKill * enemiesKilled;
            return exp;
        }

        static void CheckLVL(int expAmount)
        {
            while (exp >= 50)
            {
                Console.WriteLine();
                lvl++;
                exp -= 50;
                Console.WriteLine($"{charName} leveled up! He is now {lvl} level!");
                Console.WriteLine();
            }
        }
    }
}
