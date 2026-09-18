//Made a simple calculator for two numbers. Might not be perfect for now. will improve in the future.

using System;

namespace LearningCSharp
{
    class Calculator
    {
        public static void MainCalc()
        {
            Console.WriteLine("Welcome to the basic calculator. Enter 1 for decimal numbers or press 0 for whole numbers: ");

            Calc();

        }
        public static void Select()
        {
            Console.WriteLine("Now select the operation you wish to do:");
            Console.WriteLine("+ addition: ");
            Console.WriteLine("- subtraction:");
            Console.WriteLine("* multiplication: ");
            Console.WriteLine("/ division:");
        }

        public static (int num1, int num2) INTInput()
        {
            Console.WriteLine("Enter number one: ");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number two: ");

            int num2 = Convert.ToInt32(Console.ReadLine());

            return (num1, num2);
        }

        public static (double num1, double num2) DOUBLEInput()
        {
            Console.WriteLine("Enter number one: ");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number two: ");

            double num2 = Convert.ToDouble(Console.ReadLine());

            return (num1, num2);
        }

        public static void Calc()
        {
            if (Convert.ToInt32(Console.ReadLine()) == 0)
            {
                (int num1, int num2) = INTInput();

                Select();
                int INTanswer = 0;
                switch (Console.ReadLine())//Learned to use switch case!
                {
                    case "+":
                        INTanswer = num1 + num2;
                        Console.WriteLine("Result: " + num1 + "  + " + num2 + " = " + INTanswer);
                        break;

                    case "-":
                        INTanswer = num1 - num2;
                        Console.WriteLine("Result: " + num1 + " - " + num2 + " = " + INTanswer);
                        break;

                    case "*":
                        INTanswer = num1 * num2;
                        Console.WriteLine("Result: " + num1 + " * " + num2 + " = " + INTanswer);
                        break;

                    case "/":
                        INTanswer = num1 / num2;
                        Console.WriteLine("Result: " + num1 + " / " + num2 + " = " + INTanswer);
                        break;

                    default:
                        Console.WriteLine("You must enter a value!: ");
                        break;
                }
            }
            else
            {
                (double num1, double num2) = DOUBLEInput();

                Select();

                double answer = 0;
                switch (Console.ReadLine())//Learned to use switch case!
                {
                    case "+":
                        answer = num1 + num2;
                        Console.WriteLine("Result: " + num1 + "  + " + num2 + " = " + answer);
                        break;

                    case "-":
                        answer = num1 - num2;
                        Console.WriteLine("Result: " + num1 + " - " + num2 + " = " + answer);
                        break;

                    case "*":
                        answer = num1 * num2;
                        Console.WriteLine("Result: " + num1 + " * " + num2 + " = " + answer);
                        break;

                    case "/":
                        answer = num1 / num2;
                        Console.WriteLine("Result: " + num1 + " / " + num2 + " = " + answer);
                        break;

                    default:
                        Console.WriteLine("You must enter a value!: ");
                        break;
                }
            }
        }
    }
}