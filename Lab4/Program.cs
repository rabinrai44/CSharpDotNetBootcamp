using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //doContinue 
            bool doContinue = true;

            // loop the program
            while (doContinue)
            {
                // prompt the message to the user
                Console.Write("\nEnter a integer: ");
                int number = Convert.ToInt16(Console.ReadLine());

                // print header 
                var header = String.Format("{0,6}{1,8}{2,8}\n", "Number", "Square", "Cubed");
                Console.WriteLine(header);

                // do math through loop 
                for (int x = 1; x <= number; x++)
                {
                    Console.WriteLine("{0, -8} {1, -10} {2, -6}", x, Math.Pow(x, 2), x * x * x);
                }
                
                // do continue
                Console.Write("\n\nDo you want to continue? y/n\t");
                var userInput = Console.ReadKey().KeyChar;
                if (userInput != 'y')
                {
                    doContinue = false;
                    Console.WriteLine("\nBye!");
                }
            }

            Console.ReadKey();
        }
    }
}
