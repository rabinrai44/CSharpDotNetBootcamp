using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindInvalidInputWIthRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex validator!\n");

            string inputName;
            string inputEmail;
            string inputPhoneNumber;
            string inputDate;

            //start here
            do
            {

                //Name prompt
                Console.Write("\nPlease enter a valid Name:\t");
                inputName = Console.ReadLine();

                if (NameValidate(inputName))
                    Console.WriteLine("Name is Valid!");
                else
                    Console.WriteLine("Sorry, name is not valid");

                //Email prompt
                Console.Write("Please enter a valid Email:\t");
                inputEmail = Console.ReadLine();

                if (EmailValidate(inputEmail))
                    Console.WriteLine("Email is valid!");
                else
                    Console.WriteLine("Email is not valid!");

                //phone number prompt
                Console.Write("Please enter a valid phone number:\t");
                inputPhoneNumber = Console.ReadLine();

                if (PhoneNumberValidate(inputPhoneNumber))
                    Console.WriteLine("Phone Number is valid!");
                else
                    Console.WriteLine("Phone Number is not valid!");

                //date prompt
                Console.Write("Please enter a valid date:\t");
                inputDate = Console.ReadLine();

                if (DateValidate(inputDate))
                    Console.WriteLine("Date is valid");
                else
                    Console.WriteLine("Date is not valid!");

                if (!PlayAgain())
                {
                    break;
                }

            } while (true);

            Console.WriteLine("\nGoodBye!\n");
            Console.ReadKey();
        }


        //name validate
        public static bool NameValidate(String name)
        {
            Regex NAME_PATTERN = new Regex(@"^([A-Z][a-z]{1,29})+$");
            return NAME_PATTERN.IsMatch(name);
        }


        //email validate
        public static bool EmailValidate(string email)
        {
            const string EMAIL_PATTERN = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                  @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            if (email != null)
                return Regex.IsMatch(email, EMAIL_PATTERN);
            else
                return false;
        }


        //phone number validate
        public static bool PhoneNumberValidate(string phone)
        {
            const string PHONE_PATTERN = @"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}";

            if (phone != null)
                return Regex.IsMatch(phone, PHONE_PATTERN);
            else
                return false;
        }

        //date validate
        public static bool DateValidate(string date)
        {
            const string DATE_PATTERN = @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$";
            if (date != null)
                return Regex.IsMatch(date, DATE_PATTERN);
            else
                return false;
        }


        //play again
        private static bool PlayAgain()
        {
            do
            {
                Console.WriteLine("\nWould you like to play again? y/n");
                var inputAnswer = char.ToLower(Console.ReadKey().KeyChar);
                if (inputAnswer != 'y' && inputAnswer != 'n')
                {
                    continue;
                }

                return inputAnswer == 'y';
            } while (true);
        }
    }
}
