using System;
namespace reverseString
{
    public static class reverseStr
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Enter a string: ");
            string str  = "John Doe";
            string reversedString = " ";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedString += str[i];
            }
            Console.WriteLine(reversedString);
        }
    }
}