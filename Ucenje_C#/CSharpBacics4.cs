//Made a little game so i can study more about objects, classes and methods.

using System;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace LearningCSharp
{
    class Human
    {
        public string name = "";

        public int health = 100;

        public int damage;
    }
    class MainClass
    {

        static int damage = 0;

        public static void MainMethod()
        {
            Human player1 = new Human();

            player1.name = GetPlayerName(player1);

            Human player2 = new Human();

            player2.name = GetPlayerName(player1);

            ShowHealth(player1);

            ShowHealth(player2);

            while (player1.health > 0 && player2.health > 0)
            {
                if (player1.health <= 0)
                {
                    Winner(player1, player2);
                    Environment.Exit(0);
                }
                Console.WriteLine(player1.name + " is attacking " + player2.name);
                DealDamage(player2, ChooseAttack(player1));
                Console.WriteLine(player1.name + " attacked " + player2.name + ". " + player2.name + " health: ");
                ShowHealth(player2);

                Console.WriteLine();

                if (player2.health <= 0)
                {
                    Winner(player1, player2);
                    Environment.Exit(0);
                }
                Console.WriteLine(player2.name + " is attacking " + player1.name);
                DealDamage(player1, ChooseAttack(player2));
                Console.WriteLine(player2.name + " attacked " + player1.name + ". " + player1.name + " health: ");
                ShowHealth(player1);

                Console.WriteLine();
            }

            Winner(player1, player2);
        }

        public static string GetPlayerName(Human player)
        {
            Console.WriteLine("Enter name for player: ");

            string name = Console.ReadLine();

            return name;
        }

        public static void ShowHealth(Human player)
        {
            int health = player.health;

            Console.WriteLine(player.name + "'s health: " + health);
        }

        public static int NormalAttack(Human player)
        {
            player.damage = Random.Shared.Next(10, 21);

            return player.damage;
        }

        public static int HeavyAttack(Human player)
        {
            player.damage = Random.Shared.Next(15, 31);

            return player.damage;
        }

        public static int ChooseAttack(Human player)
        {
            Console.WriteLine("Choose betwen NormalAttack 0 or HeavyAttack 1: ");

            int decision = Convert.ToInt32(Console.ReadLine());

            if (decision == 0)
            {
                damage = NormalAttack(player);

                return damage;
            }
            else if (decision == 1)
            {
                damage = HeavyAttack(player);

                return damage;
            }
            else
            {
                Console.WriteLine("You did not enter 0 or 1. Program stopping.");
                Environment.Exit(0);
                return 0;
            }
        }

        public static int DealDamage(Human player, int damage)
        {
            player.health = player.health - damage;

            return player.health;
        }

        public static void Winner(Human player1, Human player2)
        {
            if (player1.health > 0)
            {
                Console.WriteLine(player1.name + " is the WINNER!");
            }
            else
            {
                Console.WriteLine(player2.name + " is the WINNER!");
            }
        }
    }
}