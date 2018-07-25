using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStudentInformation
{
    class Program
    {

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\nWelcome to our C# class. Which student would you like to learn more about? (enter a number 1-20)");
                int inputNumber = int.Parse(Console.ReadLine());

                try
                {
                    string homeTown = "hometown";
                    string favoriteFood = "favorite food";
                    string inputYes = "yes";


                    Console.Write($"\nStudent {inputNumber} is {GetStudentName(inputNumber)}. What would you like to know about {GetStudentName(inputNumber)}? (enter or hometown or favorite food):", GetStudentName(inputNumber));

                    var inputOption = Console.ReadLine();
                    bool doAgain = true;
                    while (doAgain)
                    {
                        if (Equals(inputOption, homeTown))
                        {
                            Console.WriteLine($"\n{GetStudentName(inputNumber)} is from {GetHomeTown(inputNumber)}. Would you like to know more? (enter yes or no):");
                            var inputAgain = Console.ReadLine();
                        }
                        else if (Equals(inputOption, favoriteFood))
                        {
                            Console.WriteLine($"\n{GetStudentName(inputNumber)} favorite food is {GetFavoriteFood(inputNumber)}. Would you like to know more? (enter yes or no):");
                            var inputAgain = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("That does not exist. Please try again. (enter or hometown or favorite food");
                        }
                        
                    };
                   

                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("That student does not exist. Please try again. (enter a number 1-20)", ex);
                }

                if (!ShouldContinue())
                    break;

            } while (true);

            Console.WriteLine("\nBye!\n");
            Console.ReadKey();
        }

        //student name
        public static string GetStudentName(int num)
        {

            string[] students = new string[20];
            students = new string[]
            {
                "Sean S", "Jacob Hands", "Rabin Rai", "Bruc T", "Chris A", "Sean A", "Michael Clark", "Michael M", "Aquoin A", "Ross",
                "Bradly", "Ricky B", "Laxmi K", "Mum L", "Donna W", "Kevin W","Peggy B","Khem G", "Hem G", "Eunice R", "Aron R"
            };

            return students[num];
        }

        //favorite food
        public static string GetFavoriteFood(int number)
        {
            string[] favoriteFood = new string[20];
            favoriteFood = new string[]
            {
                "Bread", "Subway", "Rice", "Big Mac", "Subway", "Sereal", "Popcorn", "Ham Burger", "Mac Chicken", "Big Mac",
                "Bread", "Rice", "Dedo", "Hot turkey soup", "Bean soup","Meat ball","Chamre", "Kodo ko dhedo", "Hot soup", "Mosrum"
            };

            return favoriteFood[number];
        }

        //student hometown
        public static string GetHomeTown(int number)
        {
            string[] homeTown = new string[20];
            homeTown = new string[]
            {
                "Grand Rapids, MI", "Lansing, MI", "Kentwood, MI", "Grand Rapids, MI", "Grand Rapids, MI", "Grand Rapids, MI", "Kentwood, MI", "Grand Rapids, MI", "Kentwood, MI", "Grand Rapids, MI",
                "Detroit, MI", "Detroit, MI", "Grand Rapids, MI", "Grand Rapids, MI", "Grand Rapids, MI", "Grand Rapids, MI","Holland, MI","Battle Greek, MI", "Wyoming, MI", "Kentwood, MI", "Grand Rapids, MI"
            };

            return homeTown[number];
        }

        //continue
        private static bool ShouldContinue()
        {
            do
            {
                Console.Write("\nContinue (y/n) ?");
                var input = char.ToLower(Console.ReadKey().KeyChar);
                if (input != 'y' && input != 'n')
                {
                    continue;
                }

                return input == 'y';
            } while (true);
        }

    }

}