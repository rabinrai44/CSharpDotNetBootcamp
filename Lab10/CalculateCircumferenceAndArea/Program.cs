using Circles.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCircumferenceAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //initial header text
            Console.WriteLine("Welcome to the Circle Tester");
            do
            {
               try
                {
                    Console.Write("\nEnter radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    var circumference = new Circle(radius);
                    var area = new Circle(radius);
                    var areaResult = area.CalculateArea();
                    var circumferenceResult = circumference.CalculateFormattedCircumference();

                    Console.WriteLine($"Circumference: {circumferenceResult:F2}");
                    Console.WriteLine($"Area: {areaResult:F2}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //stop program when user hit n
                if (!ShouldContinue())
                {
                    Console.WriteLine("\nGoodbye!. You created 2 Circle object(s).");
                    break;
                }

            } while (true);
            
            Console.ReadKey();
        }


        //should continue
        private static bool ShouldContinue()
        {
            do
            {
                Console.Write("\nContinue? (y/n)");
                var continueYes = Char.ToLower(Console.ReadKey().KeyChar);

                if (continueYes != 'y' && continueYes != 'n')
                    continue;
                return continueYes == 'y';

            } while (true);
        }
    }
}
