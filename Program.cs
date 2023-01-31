/*
Author: Jonathan Tsokos
Date: 1/30/23
Description: C# Console Application for Iterative Statements
*/

using System;
namespace Deliverable_3__IterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = 0;
            string series = "";

            try
            {
                while (true)
                {
                    Console.Write("Enter an integer between 1 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                }

            }
            catch
            {
                Console.Write("Please enter an integer");
                return;
            }


          
            while (true)
            {
                Console.Write("Specify the series type: Even or Odd: ");
                series = Console.ReadLine();

                if (series == "Even" || series == "Odd")
                {
                    break;
                }
            }


            if (series == "Odd")
            {
                Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are: ");
                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            if (series == "Even")
            {
                Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are: ");
                for (int i = 0; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}