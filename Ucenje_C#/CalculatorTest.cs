//Made a simple calculator for two numbers. Might not be perfect for now. will improve in the future.

using System;

namespace LearningCSharp
{
    class Calculator
    {
        public static void MainCalc()
        {
            
            Console.WriteLine("Welcome to the basic calculator. Enter 1 for decimal numbers or press 0 for whole numbers: ");

            if (Convert.ToInt32(Console.ReadLine()) == 0)
            {
                Console.WriteLine("Enter number one: ");

                int INTnumber1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number two: ");

                int INTnumber2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Now select the operation you wish to do:");
                Console.WriteLine("+ addition: ");
                Console.WriteLine("- subtraction:");
                Console.WriteLine("* multiplication: ");
                Console.WriteLine("/ division:");

                int INTanswer = 0;
                switch (Console.ReadLine())//Learned to use switch case!
                {
                    case "+":
                        INTanswer = INTnumber1 + INTnumber2;
                        Console.WriteLine("Result: " + INTnumber1 + "  + " + INTnumber2 + " = " + INTanswer);
                        break;

                    case "-":
                        INTanswer = INTnumber1 - INTnumber2;
                        Console.WriteLine("Result: " + INTnumber1 + " - " + INTnumber2 + " = " + INTanswer);
                        break;

                    case "*":
                        INTanswer = INTnumber1 * INTnumber2;
                        Console.WriteLine("Result: " + INTnumber1 + " * " + INTnumber2 + " = " + INTanswer);
                        break;

                    case "/":
                        INTanswer = INTnumber1 / INTnumber2;
                        Console.WriteLine("Result: " + INTnumber1 + " / " + INTnumber2 + " = " + INTanswer);
                        break;

                    default:
                        Console.WriteLine("You must enter a value!: ");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Enter number one: ");

                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter number two: ");

                double number2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Now select the operation you wish to do:");
                Console.WriteLine("+ addition: ");
                Console.WriteLine("- subtraction:");
                Console.WriteLine("* multiplication: ");
                Console.WriteLine("/ division:");

                double answer = 0;
                switch (Console.ReadLine())//Learned to use switch case!
                {
                    case "+":
                        answer = number1 + number2;
                        Console.WriteLine("Result: " + number1 + "  + " + number2 + " = " + answer);
                        break;

                    case "-":
                        answer = number1 - number2;
                        Console.WriteLine("Result: " + number1 + " - " + number2 + " = " + answer);
                        break;

                    case "*":
                        answer = number1 * number2;
                        Console.WriteLine("Result: " + number1 + " * " + number2 + " = " + answer);
                        break;

                    case "/":
                        answer = number1 / number2;
                        Console.WriteLine("Result: " + number1 + " / " + number2 + " = " + answer);
                        break;

                    default:
                        Console.WriteLine("You must enter a value!: ");
                        break;
                }
            }
            
        }
    }
}