using System;
namespace Strings
{
    public static class Strings
    {
        static void Main(string[] args)
        {
            //Task 1

            Console.WriteLine("Enter your first name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine($"First name: {fname} \nLast name: {lname}");
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            string warning = (age > 18) ? "You can enter" : "Sorry, you cannot enter";
            Console.WriteLine(warning);

        }
    }
}