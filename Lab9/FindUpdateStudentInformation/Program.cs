using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindUpdateStudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    //user prompt
                    Console.WriteLine("\n======================================================\n" + "\tWelcome to our C# .NET Bootcamp class\n" + "======================================================\n\n" +
                        "Which student would you like to learn more about? (enter a number 1-20)");
                    int inputNumber = int.Parse(Console.ReadLine());

                    //getting data from array
                    string name = GetStudentName(inputNumber);
                    string food = GetFavoriteFood(inputNumber);
                    string home = GetHomeTown(inputNumber);

                    //set default bool true
                    bool inputYes = true;

                    //loop after user input number
                    while (inputYes)
                    {
                        //student information
                        Console.WriteLine($"\nStudent {inputNumber} is {name}. What would you like to know about {name}? (enter or hometown or favorite food): ");

                        var input = Console.ReadLine();

                        switch (input)
                        {
                            case "hometown":
                                Console.WriteLine($"\n{name} is from {home}. Would you like to know more? (enter yes or no): ");
                                break;

                            case "favorite food":
                                Console.WriteLine($"\n{name}s favorite food is {food}. Would you like to know more? (enter yes or no): ");
                                break;

                            default:
                                Console.WriteLine("\nThat data does not exist. Please try again. (enter or hometown or favorite food");
                                break;
                        }
                        //taking user response to more info
                        var inputAgain = Char.ToLower(Console.ReadKey().KeyChar);

                        if (inputAgain != 'y')
                        {
                            inputYes = false;
                        }
                    }
                   
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.WriteLine("That does not exist. Please tray again. (enter a number 1-20): ");
                }
                
                
                //stop program when user hit n
                if(!ShouldContinue())
                {
                    break;
                }

            } while (true);
            
            Console.ReadKey();
        }

        //shouldcontinue
        private static bool ShouldContinue()
        {
            do
            {
                Console.WriteLine("Do you want to continue (y/n) ?");
                var userInput = Char.ToLower(Console.ReadKey().KeyChar);
                if (userInput != 'y' && userInput != 'n')
                    continue;
                return userInput == 'y';
            } while (true);
        }

        //student name
        private static string GetStudentName(int number)
        {
            List<string> students = new List<string> { "Sean S", "Jacob Hands", "Rabin Rai", "Bruc T", "Chris A", "Sean A", "Michael Clark", "Michael M", "Aquoin A", "Ross",
                "Bradly", "Ricky B", "Laxmi K", "Mum L", "Donna W", "Kevin W","Peggy B","Khem G", "Hem G", "Eunice R" };
            
            return students[number];
        }

        //student favorite foods
        private static string GetFavoriteFood(int number)
        {
            List<string> foods = new List<string>  {
                "Bread", "Subway", "Rice", "Big Mac", "Subway", "Sereal", "Popcorn", "Ham Burger", "Mac Chicken", "Big Mac",
                "Bread", "Rice", "Dedo", "Hot turkey soup", "Bean soup","Meat ball","Chamre", "Kodo ko dhedo", "Hot soup", "Mosrum"
            };

            return foods[number];
        }

        //student hometown
        private static string GetHomeTown(int hometown)
        {
            List<string> hometowns = new List<string> {
                "Grand Rapids, MI", "Lansing, MI", "Kentwood, MI", "Grand Rapids, MI", "Grand Rapids, MI", "Grand Rapids, MI", "Kentwood, MI", "Grand Rapids, MI", "Kentwood, MI", "Grand Rapids, MI",
                "Detroit, MI", "Detroit, MI", "Grand Rapids, MI", "Grand Rapids, MI", "Grand Rapids, MI", "Grand Rapids, MI","Holland, MI","Battle Greek, MI", "Wyoming, MI", "Kentwood, MI", "Grand Rapids, MI"
            };

            return hometowns[hometown];
        }

       
    }
}
