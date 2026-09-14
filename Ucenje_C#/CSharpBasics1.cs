using System;

namespace LearningCSharp
{
    class CSharpBasics1
    {
        static void Studying1()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your height in meters:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your monthly income:");
            int income = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your monthly expenses:");
            int expenses = Convert.ToInt32(Console.ReadLine());
            


            int yearlyincome = income * 12;
            int totalexpenses = expenses * 12;
            int moneyremaining = yearlyincome - totalexpenses;
            
            Console.WriteLine("======REPORT======");
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Height: "+height);
            Console.WriteLine("Monthy income: "+income);
            Console.WriteLine("Monthy expenses: "+expenses);
            Console.WriteLine("Annual income: "+yearlyincome);
            Console.WriteLine("Annual expenses: "+totalexpenses);
            Console.WriteLine("Money remaining: "+moneyremaining);

            bool resultage = age>=18;
            bool incomeoverexp = income>expenses;
            bool expensesunder = expenses <= 1000;
            bool adultincome = resultage && expenses<=1000;
            bool noadultincome = resultage! || expenses<=500;

            Console.WriteLine("Adult: "+resultage);
            Console.WriteLine("Income greater than expenses: "+incomeoverexp);
            Console.WriteLine("Expenses are 1000 € or less: "+expensesunder);
            Console.WriteLine("Adult AND income above 1000 €: "+adultincome);
            Console.WriteLine("Under 18 OR income below 500 €: "+noadultincome);

            
        }
    }
}