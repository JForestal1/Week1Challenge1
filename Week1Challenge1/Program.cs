using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Declare and initialize variables that hold your first name, last name, and age

            string firstName = "Joe";
            string lastName = "Forestal";
            int age = 48;

            //*Declare and initialize an array that holds  a collection of at least four of your favorite book or movie titles

            string[] listOfMovies = { "Forrest Gump", "Momento", "Dune", "Matrix" };

            //* Make a list to hold dates. Include on that list the current date and time.

            List<DateTime> listOfDates = new List<DateTime>();
            listOfDates.Add(DateTime.Now);
            listOfDates.Add(new DateTime(1972, 2, 3));
            listOfDates.Add(new DateTime(2021, 1, 31));

            //*Write out to the Console the values calculated by your age variable and the number 7.

            Console.WriteLine(age + 7);

            //*Write out a collection of conditionals that evaluates a new variable for how many hours of sleep the user gets.

            int hoursOfSleep = 2;

            if (hoursOfSleep > 9)
                Console.WriteLine("Wow, thats a lot of sleep");
            else if (hoursOfSleep == 9)
                Console.WriteLine("You are well rested");
            else if (hoursOfSleep / 4 == 1)
                Console.WriteLine("Bummer");
            else
                Console.WriteLine("Get Some Sleep");

            //* Write out a switch case that evaluates a variable that holds the value for how the user's day has been.

            string dayDescription = "poor";

            switch (dayDescription)
            {
                case "Great":
                    Console.WriteLine("Great");
                    break;
                case "Good":
                    Console.WriteLine("Good");
                    break;
                case "Okay":
                    Console.WriteLine("Okay");
                    break;
                case "Bad":
                    Console.WriteLine("Bad");
                    break;
                default:
                    Console.WriteLine("I'm not sure what to say");
                    break;
            }

            //*Print every letter of the word "Supercalifragilisticexpialidocious" to the console, one at a time.



            string superLongString = "Supercalifragilisticexpialidocious";
            int letterCount = 0;
            foreach (char letter in superLongString)
            {
                if (letter == 'i' || letter == 'l')
                    Console.WriteLine(letter);
                else
                    Console.WriteLine("Not an i");
                letterCount++;
            }
            Console.WriteLine(letterCount);

        }
    }
}
