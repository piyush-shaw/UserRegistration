using UserRegistrationProblem;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to User Registration Problem !!!");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nSelect option to choice ");
            Console.WriteLine("\n1.First Name \n2.Last Name \n3.Email");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter First Name");
                    string fName = Console.ReadLine();
                    UserRegistration.ValidateFirstName(fName);
                    break;
                case 2:
                    Console.WriteLine("Enter Last Name");
                    string lName = Console.ReadLine();
                    UserRegistration.ValidateLastName(lName);
                    break;
                case 3:
                    Console.WriteLine("Enter Email Id ");
                    string email = Console.ReadLine();
                    UserRegistration.ValidateEmail(email);
                    break;
                default:
                    flag = false;
                    Console.WriteLine("Enter the correct option ");
                    break;
            }
        }
    }
}