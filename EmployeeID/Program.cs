using System;

namespace EmployeeIdGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee ID Generator");

            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter the last name: ");
            string lastName = Console.ReadLine();


            Logic logic = new Logic();
            string employeeId = logic.GenerateEmployeeId(firstName, lastName);
            Console.WriteLine($"Generated Employee ID: {employeeId}");
            

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    public class Logic
    {
        private Random random = new Random();

        public string GenerateEmployeeId(string firstName, string lastName)
        {
            int randomDigit = random.Next(10);

            string paddedFirstName = firstName.PadRight(4, 'x');
            string paddedLastName = lastName.PadRight(4, 'x');

            string employeeId = $"{paddedFirstName.Substring(0, 4)}{paddedLastName.Substring(0, 4)}{randomDigit}";

            return employeeId;
        }
    }
}
