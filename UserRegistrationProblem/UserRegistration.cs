using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserRegistration
    {

        //Pattern for checking the first name that start with cap letter and has minimum 3 character
        public static string firstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        //Pattern for checking the last name that start with cap letter and has minimum 3 character
        public static string lastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        //Pattern for checking the email with @ precise and . position
        public static string Email = "^[a-zA-Z]+@[a-zA-Z]+.+([co.in|com])$";
        //Pattern for checking the mobile number
        public static string mobileNumber = "^[1-9]{2}[: :][0-9]{10}$";

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

        //Method to check the lastname using regex
        public static void ValidateLastName(string lName)
        {
            if (Regex.IsMatch(lName, lastName))
            {
                Console.WriteLine("Last Name :"+lName);
            }
            else
            {
                Console.WriteLine("Last name first character should be capital and has minimum 3 character ");
            }
        }

        //Method to check email using regex
        public static void ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, Email))
            {
                Console.WriteLine("Email is valid "+email);
            }
            else
            {
                Console.WriteLine("Given email is not valid ");
            }
        }

        //Method to check mobile number using regex
        public static void ValidateMobileNumber(string number)
        {
            if (Regex.IsMatch(number, mobileNumber))
            {
                Console.WriteLine("Mobile Number is valid "+number);
            }
            else
            {
                Console.WriteLine("Mobile Number with country code followed by space and 10 digit number");
            }
        }

    }
}
