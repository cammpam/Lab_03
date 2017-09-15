using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
	        {	        
                string fileName = "word-game.txt";
                string path = Path.Combine(Environment.CurrentDirectory, @"Word-Game\", fileName);

                Console.WriteLine("Welcome to Josie's Guessing Game");
                Console.WriteLine("Enter Your Name");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{name}, Pick your difficulty");
                Level();

		
	        }
	        catch (DirectoryNotFoundException)
	        {

		        Console.WriteLine("Dirctory Not Found!");
	        }

            Console.Read();
        }

        static void Level()
        {
            string[] difficultyLevel = new string[] { " A - ELEMENTARY: 3 letters", " B - HIGH SCHOOL: 5 letters", " C - COLLEGE: 10 letters " };
            string one = "Elementary";
            string two = "High School";
            string three = "College";

            foreach (string level in difficultyLevel)
            {         
                Console.WriteLine(level);
            }
            string difficultyChoice = Console.ReadLine().ToUpper();


            if (difficultyChoice == "A")
            {
                Console.Clear();
                Console.WriteLine($"Great, You chose { one}! Lets Start");
	        }
            else if (difficultyChoice == "B")
	        {
                Console.Clear();
                Console.WriteLine($"Great, You chose { two}! Lets Start");
	        } 
            else if (difficultyChoice == "C")
	        {
                Console.Clear();
                Console.WriteLine($"Great, You chose { three}! Lets Start");
	        }
            else if (difficultyChoice == "Q")
	        {
                Console.Clear();
                Environment.Exit(0);
	        }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry, Invaid Choice. Try Again! OR Press q to quit");
                DifficultyTryAgain();

            }

        }

        static void DifficultyTryAgain()
        {
                Level();
        }


        static void LevelElem()
        {

        }
    }
}
