using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class GiantKillerRobot
    {
        public string Name { get; set; }
        public bool TargetIsAlive = true;
        public GiantKillerRobot(String name)
        {
            this.Name = name;
        }
        public bool initialize()
        {
            Console.WriteLine($"{Name} is activating...  Please wait.");
            return true;
        }
        public string target(Random random, String answer)
        {
            int targetN = random.Next(501);
            string unlucky = "n/a";
            if (answer == "Y" || answer == "y")
            {
                if (targetN < 150)
                {
                    unlucky = "creature";
                    Console.WriteLine($"Current target: {unlucky}");
                    return unlucky;
                }
                else if (targetN > 150 && targetN < 310)
                {
                    unlucky = "human";
                    Console.WriteLine($"Current target: {unlucky}");
                    return unlucky;
                }
                else if (targetN > 310 && targetN < 499)
                {
                    unlucky = "superhero";
                    Console.WriteLine($"Current target: {unlucky}");
                    return unlucky;
                }
                else
                    unlucky = "alldead";
                return unlucky;
            }
            else if (answer == "N" || answer == "n")
            {
                Console.WriteLine("Robot is shutting down...");
                return "sd";
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
                Console.WriteLine("Y / N");
                string newanswer = Console.ReadLine();
                target(random, newanswer);
                return "n/a";
            }
        }
        public bool FireLasersAt(Random random, String targ)
        {
            string name = targ;
            int desc = random.Next(500);
            if (desc < 100)
                Console.WriteLine($"    The {name} has been vaporized");
            else if (desc > 100 && desc < 200)
                Console.WriteLine($"    The {name} has been melted to the ground");
            else if (desc > 200 && desc < 300)
                Console.WriteLine($"    The {name} has been desintegrated");
            else if (desc > 300 && desc < 400)
                Console.WriteLine($"    The {name} has been reduced to dust");
            else if (desc > 400)
                Console.WriteLine($"    The {name} has been burnt to death");
            return false;
        }
    }
}