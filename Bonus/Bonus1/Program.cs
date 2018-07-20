using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus1
{
    class Program
    {
        private static bool doContinue = true;

        static void Main(string[] args)
        {

            // welcome header message
            Console.WriteLine("Welcome to the Letter Grade Converter!\n---------------------------------------");
            // promt the user with loop
            while(doContinue)
            {
                Console.Write("\nEnter anumerical grade: ");
                int grade = int.Parse(Console.ReadLine());

                CalculateGrade(grade);

                PlayAgain();
               
            }
            Console.ReadKey();
        }
        
        public static void CalculateGrade(int num)
        {
            if (num >= 88 & num <= 100)
            {
                Console.WriteLine("Grade: A");
            }
            else if (num < 88 && num >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (num < 80 && num >= 67)
            {
                Console.WriteLine("Grade: C");
            }
            else if (num < 67 && num >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else if (num < 61 && num >= 0)
            {
                Console.WriteLine("Grade: F");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void PlayAgain()
        {
            Console.WriteLine("Continue? (y/n): ");
            var userInput = Console.ReadKey().KeyChar;
            if (userInput != 'y')
            {
                doContinue = false;
                Console.WriteLine("\nBye!");
            }
        }
    }
}
