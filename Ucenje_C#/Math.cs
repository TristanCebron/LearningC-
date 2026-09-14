/*
    Was learning the total basics of loops, if statements and math operators, strings,..
*/

using System;
using System.Dynamic;

namespace LearningCSharp
{
    class CSharpBasics2
    {
        public static void Studying2()
        {

            Console.WriteLine("Enter your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Weekly budget?: ");

            double budget = Convert.ToDouble(Console.ReadLine());

            double avgDailyExpence = 0;

            double maxDailyExpences = 0;

            double minDailyExpences = 99999999999; //could use double.MaxValue;

            double allExpences = 0;

            double dailyExpences = 0;

            /*
            Would rather use if statment but i wanted to test a while loop because why not.
            while(budget < 0)
            {
                Console.WriteLine("Budget can't be negative or zero: ");

                budger = Convert.ToDouble(Console.ReadLine);
            }
            */

            for (int day = 1; day <= 7; day++)
            {
                Console.WriteLine("How much did you spend on day " + day);

                dailyExpences = Convert.ToDouble(Console.ReadLine());

                while (dailyExpences < 0)
                {
                    Console.WriteLine("Daily expences cant be less than 0. Re enter the value: ");
                    dailyExpences = Convert.ToDouble(Console.ReadLine());
                }

                allExpences += dailyExpences;

                maxDailyExpences = Math.Max(maxDailyExpences, dailyExpences);

                minDailyExpences = Math.Min(minDailyExpences, dailyExpences);

            }

            avgDailyExpence = Math.Round(allExpences / 7, 2);

            double budgetRemaining = budget - allExpences;

            bool withinBudget = budget > allExpences;

            bool spentNothing = allExpences == 0;

            if (spentNothing == true)
            {
                Console.WriteLine("User " + name + " did not use any money this week!");
            }
            else if (allExpences <= budget)
            {
                Console.WriteLine("User " + name + " used " + allExpences + " from their " + budget + " budget.");
            }
            else
            {
                Console.WriteLine("User " + name + " spent all his money this week!");
            }

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Weekly budget: " + budget);
            Console.WriteLine("Weekly expences: " + allExpences);
            Console.WriteLine("Average daily expence: " + avgDailyExpence);
            Console.WriteLine("Maxsimum daily expence:" + maxDailyExpences);
            Console.WriteLine("Minimum daily expence:" + minDailyExpences);
            Console.WriteLine("Within Budget:" + withinBudget);
            Console.WriteLine("Did user spent nothing: " + spentNothing);
        }

    }
}