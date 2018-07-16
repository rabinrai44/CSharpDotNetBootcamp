using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
      
            
            // Declaring variables 
            double Length;
            double Width;
            double area;
            double perimeter;
            bool StartAgain = true;

            // Starting program with while loop where program have StartAgain = true 
            while(StartAgain)
            {

                // Getting the user inputs
                Console.WriteLine("Please enter the room length: ");
                Length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the room width: ");
                Width = Convert.ToDouble(Console.ReadLine());

                // Calculate the area of the room
                area = Length * Width;

                // Calculate the Perimeter of the room
                perimeter = 2 * (Width + Length);

                // Print all the result to the user into console
                Console.WriteLine("The area of room is: " + area);
                Console.WriteLine("The perimeter of room is: " + perimeter);

                // Ask the users if do they want to run program again
                Console.WriteLine("Do you want to continue run the program? Y/N");
                string answer = Console.ReadLine();

                // Check the user input then if doesn't match with given value StartAgain = false and exit program
                if (answer != "Y")
                {
                    StartAgain = false;
                    Console.WriteLine("Exiting..");
                }
            }

        }
    }
}
