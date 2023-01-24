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
            Console.WriteLine("1.First Name");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter First Name");
                    string fName = Console.ReadLine();
                    UserRegistration.ValidateFirstName(fName);
                    break;
                default:
                    flag = false;
                    Console.WriteLine("Enter the correct option ");
                    break;
            }
        }
    }
}