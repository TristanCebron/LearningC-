/*
Create a program where two delivery trucks compete to complete 3 deliveries first.

Create a DeliveryTruck class.
Each truck should have a name, fuel starting at 100, distance starting at 0, and deliveries starting at 0.
Create two separate truck objects.
Ask for the name of both trucks/drivers.
Each player takes turns choosing an action.
Use a switch statement for the action choice.
The available actions are:
0 — Normal Drive
1 — Speed Drive
2 — Refuel
Normal Drive should travel a random 10–20 km and use 10 fuel.
Speed Drive should travel a random 20–35 km and use 20 fuel.
Refuel should restore a random 15–30 fuel.
Fuel must never go above 100.
A truck cannot use a driving action if it does not have enough fuel.
Every delivery location is 100 km away.
When a truck reaches or passes 100 km, increase its deliveries by 1 and reset its distance to 0.
After every turn, display that truck's fuel, distance and completed deliveries.
The first truck to complete 3 deliveries wins.
Make sure the second truck does not get another turn if the first truck has already won.
Keep the main method relatively short by using other methods.

Create methods for getting the truck name, displaying its status, Normal Drive, Speed Drive, Refuel, choosing an action, adding travelled distance, checking whether a delivery was completed, and displaying the winner.
*/

using System;

namespace LearningCSharp
{
    class DeliveryTruck
    {
        public string name = "";

        public double fuel = 100;

        public double distance = 0;

        public int deliveries = 0;
    }

    class Game
    {

        public static void MainGame()
        {
            DeliveryTruck truck1 = new DeliveryTruck();

            truck1.name = Naming(truck1);

            DeliveryTruck truck2 = new DeliveryTruck();

            truck2.name = Naming(truck2);

            while (truck1.deliveries < 3 && truck2.deliveries < 3)
            {

                Action(truck1);
                Output(truck1);
                CheckVictory(truck1);

                Console.WriteLine();

                Action(truck2);
                Output(truck2);
                CheckVictory(truck2);
            }
        }

        public static string Naming(DeliveryTruck truck)
        {
            Console.WriteLine("Enter the name of the truck: ");

            truck.name = Console.ReadLine();

            return truck.name;
        }

        public static void Action(DeliveryTruck truck)
        {
            Console.WriteLine("The available actions are 0 — Normal Drive 1 — Speed Drive 2 — Refuel");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 0:
                    NormalDrive(truck);
                    break;

                case 1:
                    SpeedDrive(truck);
                    break;

                case 2:
                    Refuel(truck);
                    break;
            }
        }

        public static (double km, double fuel) NormalDrive(DeliveryTruck truck)
        {
            if (!CheckFuel(truck, 10))
            {
                return (truck.distance, truck.fuel);
            }

            truck.distance += Random.Shared.Next(10, 21);

            truck.fuel = truck.fuel - 10.0;

            Delivery(truck);

            return (truck.distance, truck.fuel);
        }

        public static (double km, double fuel) SpeedDrive(DeliveryTruck truck)
        {
            if (!CheckFuel(truck, 20))
            {
                return (truck.distance, truck.fuel);
            }

            truck.distance += Random.Shared.Next(20, 36);

            truck.fuel = truck.fuel - 20.0;

            Delivery(truck);

            return (truck.distance, truck.fuel);
        }

        public static double Refuel(DeliveryTruck truck)
        {
            if (truck.fuel == 100.0)
            {
                Console.WriteLine("You cannot refuel! Choose another action!");
                Action(truck);
                return truck.fuel;
            }
            else if (truck.fuel >= 70.0 && truck.fuel <= 80.0)
            {
                truck.fuel = truck.fuel + Random.Shared.Next(10, 21);

                return truck.fuel;
            }
            else if (truck.fuel <= 70.0)
            {
                truck.fuel = truck.fuel + Random.Shared.Next(15, 31);

                return truck.fuel;
            }
            else
            {
                return truck.fuel;
            }
        }

        public static void Output(DeliveryTruck truck)
        {
            Console.WriteLine(truck.name + " Has drove " + truck.distance + " km and has " + truck.fuel + " L of fuel remining. The truck also completed " + truck.deliveries + " deliveries.");
        }

        public static int Delivery(DeliveryTruck truck)
        {
            if (truck.distance >= 100.0)
            {
                truck.deliveries++;
                truck.distance = 0;
            }

            return truck.deliveries;
        }

        public static void CheckVictory(DeliveryTruck truck)
        {
            if (truck.deliveries == 3)
            {
                Console.WriteLine(truck.name + " Has completed 3 deliveries!");
                Environment.Exit(0);
            }
        }

        public static bool CheckFuel(DeliveryTruck truck, double requiredFuel)
        {
            if (truck.fuel < requiredFuel)
            {
                Console.WriteLine("You do not have enough fuel!");
                return false;
            }

            return true;
        }
    }
}