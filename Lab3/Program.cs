using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            // welcome message
            Console.WriteLine("Grand Circus C#.NET Bootcamp Lab-3 Practice || Check if your input number is Even or Odd\n=======================================");

            // ask user their name
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Hi " + name + "!");
            
            // set continue as default value true
            bool shouldContinue = true;


            // do loop when user want to continue run program
            do
            {
                // prompt user integer
                Console.WriteLine("\nEnter the integer between 1 - 100:");
                string input = Console.ReadLine();
                
                // check wheather user input is valid as a number
                if (int.TryParse(input, out int x))
                {
                    int N = int.Parse(input);

                    if (N >= 0 && N <= 99)
                    {

                        // check wheather users given value is Even or Odd
                        if (N % 2 == 0)
                        {
                            if (N > 1 && N < 25)
                                Console.WriteLine("Even and less than 25");
                            else if (N > 25 && N <= 60)
                                Console.WriteLine("Even");
                            else
                                Console.WriteLine(N + " and Even");
                        }

                        else
                            Console.WriteLine("Odd");
                    }
                    else
                        Console.WriteLine("Hmm, that's not integer between 1-100. Try Again");
                }
                else
                    Console.WriteLine("Ops! Not postive number.");

                /* message to user continue... 
                 * wish to run program need to press y 
                 * otherwise shouldContinue value will be false 
                 * and exit program
                 */
                Console.Write("Continue check? Y/N ");
                var checkInput = Console.ReadKey().KeyChar;

                if (checkInput != 'y')
                {
                    shouldContinue = false;
                    Console.WriteLine("\nBye!");
                    Console.ReadKey();
                }

            } while (shouldContinue);
        }
    }
}
