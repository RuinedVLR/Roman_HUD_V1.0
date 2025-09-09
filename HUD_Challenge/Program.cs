using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUD_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studioName = "Team Void";
            string gameTitle = "Castle Breakers";
            string charName = "VaLLy";
            int score = 0;
            int health = 100;
            int shield = 10;
            int lives = 3;
            int scoreMult = 1;


            Console.WriteLine("{0,32}", studioName);
            Console.WriteLine("{0,35}", gameTitle);
            Console.WriteLine("");
            Console.WriteLine("{0,30}", charName);
            Console.WriteLine("");
            Console.WriteLine("{0,0}{1,0}{2,20}{3,0}{4,20}{5,0}", "Score: ", score, "Health: ", health, "Shield: ", shield);
            Console.WriteLine("{0,0}{1,0}{2,44}{3,0}", "Lives: ", lives, "Multiplier: ", scoreMult);
            Console.WriteLine("");
            Console.WriteLine("Press any button...");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("{0,32}", studioName);
            Console.WriteLine("{0,35}", gameTitle);
            Console.WriteLine("");
            Console.WriteLine($"{charName} defeated 2 enemies, but got injured several times.");
            Console.WriteLine("+200 score, -20 health, -10 shield.");
            score += 200;
            health -= 20;
            shield -= 10;
            Console.WriteLine("");
            Console.WriteLine("Your stats are now...");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("{0,32}", studioName);
            Console.WriteLine("{0,35}", gameTitle);
            Console.WriteLine("");
            Console.WriteLine("{0,30}", charName);
            Console.WriteLine("");
            Console.WriteLine("{0,0}{1,0}{2,20}{3,0}{4,20}{5,0}", "Score: ", score, "Health: ", health, "Shield: ", shield);
            Console.WriteLine("{0,0}{1,0}{2,44}{3,0}", "Lives: ", lives, "Multiplier: ", scoreMult);
            Console.WriteLine("");
            Console.WriteLine("Press any button...");
            Console.ReadKey();
            Console.Clear();


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


            Console.WriteLine("{0,32}", studioName);
            Console.WriteLine("{0,35}", gameTitle);
            Console.WriteLine("");
            Console.WriteLine("{0,30}", charName);
            Console.WriteLine("");
            Console.WriteLine("{0,0}{1,0}{2,20}{3,0}{4,20}{5,0}", "Score: ", score, "Health: ", health, "Shield: ", shield);
            Console.WriteLine("{0,0}{1,0}{2,45}{3,0}", "Lives: ", lives, "Multiplier: ", scoreMult);
            Console.WriteLine("");
            Console.WriteLine("Press any button...");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("{0,32}", studioName);
            Console.WriteLine("{0,35}", gameTitle);
            Console.WriteLine("");
            Console.WriteLine($"{charName} flawlessly defeated 5 enemies! Multiplier is raised to 5X, and {charName} found a new shiny armor from a burglar.");
            Console.WriteLine("+40 shield");
            scoreMult *= 5;
            score = (score + 500) * scoreMult;
            shield += 40;
            Console.WriteLine("");
            Console.WriteLine("Your stats are now...");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("{0,32}", studioName);
            Console.WriteLine("{0,35}", gameTitle);
            Console.WriteLine("");
            Console.WriteLine("{0,30}", charName);
            Console.WriteLine("");
            Console.WriteLine("{0,0}{1,0}{2,20}{3,0}{4,20}{5,0}", "Score: ", score, "Health: ", health, "Shield: ", shield);
            Console.WriteLine("{0,0}{1,0}{2,47}{3,0}", "Lives: ", lives, "Multiplier: ", scoreMult);
            Console.WriteLine("");
            Console.WriteLine("Press any button...");
            Console.ReadKey();
            Console.Clear();


        }
    }
}
