using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        private static bool shouldContinue = true;

        static void Main(string[] args)
        {
            // starting program here through the loop
            while(shouldContinue)
            {
                // initial prompt
                Console.Write("\nEnter an integer from 1 to 10:\t");
                string inputInteger = Console.ReadLine();

                // check user input is an integer or not
                if (int.TryParse(inputInteger, out int x))
                {
                    int num = int.Parse(inputInteger);

                    // valid the input number
                    if (num > 0 && num <= 10)
                    {
                        long factorial = 1;

                        for (int i = 1; i <= num; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine(factorial);
                    }
                    else
                    {
                        Console.WriteLine("\nOps!It must be between 1-10\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nHmm, you put string, please try again with integer!\n");
                }
               

                PlayAgain();                
            }
            Console.ReadKey();
        } 
        
        //PlayAgain function does ask the user wish to play again the program and accept the input from user
        public static void PlayAgain()
        {
            Console.Write("\nContinue y/n ?\t");
            var userInput = Console.ReadKey().KeyChar;

            if (userInput != 'y')
            {
                shouldContinue = false;
                Console.WriteLine("\nGood Bye!");
            }
        }
    }
}
