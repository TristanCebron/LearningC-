/*
    Create a Player class. Give it a string name and an int[] scores that can hold 3 scores.
    Hint: new int[3].
    Inside Studying2(), create one object called player1.
    Hint: use new Player().
    Ask the user for their name and store it inside player1.
    Hint: use the . operator to access name.
    Use a for loop to ask the player for 3 scores. Save every answer into the player's scores array.
    Hint: use player1.scores[i].
    After entering the scores, use another for loop to print all three scores.
    Hint: use .Length instead of manually writing 3.
    Create a method called TotalScore. It should receive an int[] and return the total of all numbers in that array.
    Hint: start with int total = 0, loop through the array, and use +=.
    Call the method using the player's score array and print the result.
    Your output should roughly be:
*/

using System;

namespace LearningCSharp
{

    class Player
    { 
        public string name = "";

        public int[] score = new int[3];
    }

    class CSharpBasics3
    {
        public static void Studying3()
        {
            
            Player player1 = new Player();  

            Console.WriteLine("Enter name for player1: ");
            
            player1.name = Console.ReadLine();
            
            

            for(int i = 0; i < player1.score.Length; i++)
            {
                Console.WriteLine("Enter the players score: ");
                    
                player1.score[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine(player1.name);

            
            for(int i = 0; i < player1.score.Length ; i++)
            {
                Console.Write(player1.score[i]+", ");
            }
            

            int total = TotalScore(player1.score);
            Console.WriteLine("Total score: " + total);

        }

        public static int TotalScore(int[] n)
        {
            int total = 0;

            for(int i = 0; i<n.Length; i++)
            {
                total += n[i];
            }

            return total;
        }
    }
}