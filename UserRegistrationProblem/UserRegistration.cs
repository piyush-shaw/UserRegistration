using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
	public class UserRegistration
	{
        //Pattern for checking the first name that start with cap letter and has minimum 3 character
        public static string firstName = "^[A-Z]{1}[A-Za-z]{2,}$";

        //Method to check the firstname using regex
        public static void ValidateFirstName(string fName)
        {
            if (Regex.IsMatch(fName, firstName))
            {
                Console.WriteLine("First Name :" + fName);
            }
            else
            {
                Console.WriteLine("First alphabet should be capital and has minimum 3 character ");
            }
        }

    }
}

