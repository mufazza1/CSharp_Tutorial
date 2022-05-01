using System;
namespace LenghtofString
{
    public static class LenghtofString
    {
        public static void Main(string[] args)
        {
            int length = 0;
            string str = "This is just an example";
            foreach (char chr in str)
            {
                length++;
            }
            Console.WriteLine("The lenght of string is " + length);
        }
    }
}