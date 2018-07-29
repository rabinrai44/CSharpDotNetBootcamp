using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindUpdateStudentInformation
{
    /// <summary>
    /// Student Class that provide the all require properties
    /// that can access whether calling it
    /// </summary>
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string HomeTown { get; set; }
        public string Food { get; set; }
        public string Color { get; set; }
        public int FavoriteNumber { get; set; }

        //Student Constructor passing the value through argument
        public Student(int id, string name, string hometown, string food, string color, int num)
        {
            this.ID = id;
            this.Name = name;
            this.HomeTown = hometown;
            this.Food = food;
            this.Color = color;
            this.FavoriteNumber = num;
        }
    }

    class Program
    {
        //List
        static List<Student> Students = new List<Student>();
        static bool preLoop = true;
        static bool ShouldContinueInside = true;

        static void Main(string[] args)
        {
            //initial header
            Console.WriteLine("\n=============================================================\n\tWelcome to the Grand Circus C#.NET Bootcamp!\n=============================================================\n");

            do
            {
                Console.WriteLine("\nMENU OPTIONS");
                Console.WriteLine("1 - Learn about individual students\n2 - Fun Stuff\n3 - Exit program\n");

                try
                {
                    Console.WriteLine("Please select the option showing above, What would you want to know?");

                    int userReponse = int.Parse(Console.ReadLine());

                    switch (userReponse)
                    {
                        case 1:
                            LearnStudentDetails();
                            break;

                        case 2:
                            //only testing
                            Console.WriteLine("Hi there! Nice to meet you!"); ;
                            break;

                        case 3:
                            preLoop = false;
                            Console.WriteLine("\nGoodbye! Thanks for visit.");

                            break;
                        default:
                            Console.WriteLine("Hmm, that's not exist! try again");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Write("Would you like to continue (y/n)?");
                var res = char.ToLower(Console.ReadKey().KeyChar);

                if (res != 'y')
                    preLoop = false;


            } while (preLoop);

            Console.ReadKey();
        }

        //public static void DisplayAllStudent()
        //{
        //    Console.WriteLine("Student ID\t Student Name");
        //    Console.WriteLine("================================================");
        //    foreach(Student item in Students)
        //    {
        //        Console.WriteLine(item.ID+ "\t" +item.Name);
        //    }
        //    Console.WriteLine();
        //}

        //add student
        private static void AddStudent()
        {
            throw new NotImplementedException();
        }

        //Students details information
        private static void LearnStudentDetails()
        {
            GetStudentInformation();

            Console.WriteLine($"Which student do you want to learn more? Enter a number 1-{Students.Count}");

            if (!int.TryParse(Console.ReadLine(), out int id) || id > Students.Count)
            {
                Console.WriteLine("That does not exist. Please try again");
            }
            else
            {
                Student student = Students[id - 1];
                Console.WriteLine($"Student {student.ID} is {student.Name}");

                while (ShouldContinueInside)
                {
                    Console.WriteLine($"What would you like to know about {student.Name}?");

                    string userChoice = Console.ReadLine();

                    switch (userChoice)
                    {
                        case "hometown":
                        case "home town":
                        case "home":
                            Console.WriteLine($"{student.Name} from {student.HomeTown}.");
                            break;
                        case "food":
                        case "favorite food":
                            Console.WriteLine($"{student.Name} favorite food is {student.Food}.");
                            break;
                        case "color":
                        case "favorite color":
                            Console.WriteLine($"{student.Name} favorite color is {student.Color}.");
                            break;
                        case "number":
                            Console.WriteLine($"{student.Name} favorite number is {student.FavoriteNumber}.");
                            break;

                        default:
                            Console.WriteLine("That's doesn't exist. Please try \"hometown\" or, \"food\" ");
                            break;
                    }

                    //Ask user to know more
                    Console.Write($"Would you like to know more (y/n)?", 5);
                    string inputYes = Console.ReadLine().ToLower();
                    ShouldContinueInside = (inputYes == "y" || inputYes == "yes");
                }
            }
        }

        /// <summary>
        /// All Student Informations including student name, student id, favorite food, 
        /// home town, favorite color, favorite number
        /// People can access the all students whether input is correct
        /// </summary>
        private static void GetStudentInformation()
        {
            Student student;

            student = new Student(1, "Rabin", "Kentwood", "Pizza", "Green", 44);
            Students.Add(student);
            student = new Student(2, "Bruce", "Grand Rapids", "Pizza", "Brown", 99);
            Students.Add(student);
            student = new Student(3, "Sean S", "Grand Rapids", "Shusi", "White", 121);
            Students.Add(student);
            student = new Student(4, "Sean A", "Grand Rapids", "Steak", "Red", 321);
            Students.Add(student);
            student = new Student(5, "Jacob", "Lansing", "Burger", "Purple", 564);
            Students.Add(student);
            student = new Student(6, "Mike", "Grand Rapids", "Pizza", "Green", 652);
            Students.Add(student);
            student = new Student(7, "Michael", "Wyoming", "Burger", "Black", 320);
            Students.Add(student);
            student = new Student(8, "Bradley", "Grand Rapids", "Shusi", "Blue", 55);
            Students.Add(student);
            student = new Student(9, "Catherine", "Grand Rapids", "Shusi", "White", 121);
            Students.Add(student);
            student = new Student(10, "Chris", "Grand Rapids", "Lasana", "White", 56);
            Students.Add(student);
            student = new Student(11, "Aquoinette", "Grand Rapids", "Chips", "White", 66);
            Students.Add(student);
            student = new Student(12, "Ross", "Grandville", "Shusi", "White", 99);
            Students.Add(student);
        }


        //looping program
        private static bool ShouldContinue()

        {
            do
            {
                Console.Write("\nWould you like to Continue? (y/n)");
                var userInput = Char.ToLower(Console.ReadKey().KeyChar);

                if (userInput != 'y' && userInput != 'n')
                    continue;
                else
                    return userInput == 'y';
            } while (true);

        }
    }
}
