using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNA261_Project
{
    internal class Program
    {

        static int GetValidPercentage(string prompt)
        {
            int percentage;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out percentage) && percentage >= 0 && percentage <= 100)
                {
                    return percentage; // valid input, return the value
                }
                Console.Clear();
                Console.WriteLine("Please enter a valid percentage between 0 and 100.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Please enter the percentages you received:");
            int test1 = GetValidPercentage("Test 1");
            double test1Final = test1 * 0.3;
            Console.Clear();
            int test2 = GetValidPercentage("Test 2");
            double test2Final = test2 * 0.5;
            Console.Clear();
            int assignment1 = GetValidPercentage("Assignment 1");
            double assignment1Final = assignment1 * 0.1;
            Console.Clear();    
            int project = GetValidPercentage("Project");
            double projectFinal = project * 0.1;
            Console.Clear();    
            double totalMarks = test1Final + test2Final + assignment1Final + projectFinal;
            Console.WriteLine(name + " the marks you entered are: Test 1: " + test1 + "%, Test 2: " + test2 + "%, Assignment: " + assignment1 + "% and Project: " + project + "%");
            Console.WriteLine("Your average is: " + totalMarks + "%");
            if (totalMarks >= 50)
            {
                Console.WriteLine("You have passed the course and qualify for the exam!");
            }
            else
            {
                Console.WriteLine("You have failed the course.");
            }
        }

    }
}
