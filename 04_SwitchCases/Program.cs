using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1; 

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello World!");
                    break; //break keyword tells computer we want code to move on outside of switch case
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default: //same concept as an else
                    Console.WriteLine("This is default. It will be executed if no other case is evaluated.");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek; //Today similar to now
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Welcome to the beginning of a work week!");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Still working!"); //All will say "still working," like 'or' operator, same output
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's the weekend!!!");
                    break;
            }

            Console.WriteLine("How are you feeling on a scale of 1-5?");
            //string response = Console.ReadLine();
            //int mood = int.Parse(response)this is a longer way of inputing code below
            int mood = int.Parse(Console.ReadLine()); //Use if you want user to input an int,  means you are converting user input value(which is a string) in to a integer.
            switch (mood)
            {
                case 1:
                    Console.WriteLine("Take a break, and give yourself some time to wake up.");
                    break;
                case 2:
                    Console.WriteLine("Drink some coffee, and you'll feel better.");
                    break;
                case 3:
                    Console.WriteLine("Meh, you could be better.");
                    break;
                case 4:
                    Console.WriteLine("Feeling pretty darn good, eh?");
                    break;
                case 5:
                    Console.WriteLine("You are on top of your game today!");
                    break;
                default:
                    Console.WriteLine("Didn't I say on a scale of 1-5?");
                    break;

            }
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    Console.WriteLine("Take a break, and give yourself some time to wake up.");
                    break;
                case "2":
                    Console.WriteLine("Drink some coffee, and you'll feel better.");
                    break;
                case "3":
                    Console.WriteLine("Meh, you could be better.");
                    break;
                case "4":
                    Console.WriteLine("Feeling pretty darn good, eh?");
                    break;
                case "5":
                    Console.WriteLine("You are on top of your game today!");
                    break;
                default:
                    Console.WriteLine("Didn't I say on a scale of 1-5?");
                    break;

            }
            //Challenge
            //Ask the user how they're feeling on a scale of 1-5, Capture their input, and urn iit thorugh a swithc statement, then output a different repsonse for each value, let them know if they respond oout of range
            Console.ReadKey();
        }
    }
}
