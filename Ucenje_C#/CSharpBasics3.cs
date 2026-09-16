/*
    Same concept as CSharpBasics2 but a tiny bit harder.
*/

using System;
using System.Runtime.CompilerServices;

namespace LearningCSharp
{
    class Robot
    {
        public string name = "";

        public int[] energyUse = new int[4];
    }

    class CSharpBasics4
    {
        public static void Studying()
        {
            Robot robot1 = new Robot();

            Robot robot2 = new Robot();

            Console.WriteLine("Enter  the name of the first robot: ");

            robot1.name = Console.ReadLine();

            Console.WriteLine("Enter  the name of the second robot: ");

            robot2.name = Console.ReadLine();

            EnterEnergy(robot1);

            EnterEnergy(robot2);

            PrintRobot(robot1);
            PrintRobot(robot2);
        }

        public static void EnterEnergy(Robot robot)
        {
            for(int i = 0; i < robot.energyUse.Length;i++)
            {
                Console.WriteLine("Enter the ammount of energy: ");
                    
                robot.energyUse[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void EnergyOutput(Robot robot)
        {
            for(int i = 0; i < robot.energyUse.Length;i++)
            {
                Console.WriteLine(robot.energyUse[i]);
            }
        }

        public static int TotalEnergy(int[] n)
        {
            int total = 0;

            for(int i = 0; i<n.Length; i++)
            
            {
               total += n[i]; 
            }

            return total;
        }

        public static int HighestEnergy(int[] n)
        {
            int highestEnergy = n[0];

            for(int i=0; i < n.Length; i++)
            {
                if (n[i] >= highestEnergy)
                    highestEnergy = n[i];
            }

            return highestEnergy;
        }

        public static bool NeedsRecharge(Robot robot)
        {
            if(TotalEnergy(robot.energyUse) < 100)
                return true;

            return false;
        }

        public static void PrintRobot(Robot robot)
        {
            Console.WriteLine("Name "+robot.name);

            Console.WriteLine();
            Console.WriteLine("Energy Use: ");

            EnergyOutput(robot);

            Console.WriteLine();
            Console.WriteLine("Total Energy "+TotalEnergy(robot.energyUse));
            
            Console.WriteLine();
            Console.WriteLine("Highest Energy "+HighestEnergy(robot.energyUse));

            Console.WriteLine();
            Console.WriteLine("Needs Recharge "+NeedsRecharge(robot));
            Console.WriteLine();

        }
    }
}