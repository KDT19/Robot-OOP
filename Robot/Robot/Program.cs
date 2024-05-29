using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Robot
{
    internal class Program
    {
        #region Enunt Problema

        //Creati un simulator pentru un robot gigant de lupta, denumit "GiantKillerRobot". 
        //Robotul are misiunea de a detecta si elimina toate formele de viata de pe Pamant.
        //Simularea trebuie sa permita utilizatorului sa interactioneze cu robotul si 
        //sa controleze anumite aspecte ale misiunii.

        #endregion
        static void Main(string[] args)
        {
            
            Random random = new Random();
            Earth earth = new Earth();
            Console.WriteLine("Welcome to GiantKillerRobot2077 Simulator!");
            Console.WriteLine("Please name your ultimate death machine below, and press enter!");
            string RobotName = Console.ReadLine();
            GiantKillerRobot robot = new GiantKillerRobot(RobotName);
            bool Active = robot.initialize();
            Console.WriteLine("Start looking for targets?");
            Console.WriteLine("Y / N");
            string answer = Console.ReadLine();
            string currentTarget = robot.target(random, answer);
            while (Active && earth.ContainsLife)
            {
                if (currentTarget != "alldead" && currentTarget != "n/a" && currentTarget != "sd" && robot.TargetIsAlive)
                    robot.TargetIsAlive = robot.FireLasersAt(random, currentTarget);
                else if (currentTarget != "alldead" && currentTarget != "n/a" && currentTarget != "sd" && !robot.TargetIsAlive)
                {
                    currentTarget = robot.target(random, answer);
                    robot.TargetIsAlive = true;
                }
                else if (currentTarget == "sd")
                {
                    Console.WriteLine("Hope you enjoyed GiantKillerRobot2077 Simulator!");
                    Active = false;
                }
                if (currentTarget == "alldead")
                {
                    earth.ContainsLife = false;
                    Console.WriteLine("Mission acomplished, all life has been eliminated");
                    Console.WriteLine("Hope you enjoyed GiantKillerRobot2077 Simulator!!");
                }
            }


        }
    }
}