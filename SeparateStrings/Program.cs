using System;

namespace SeparateWords
{
    public static class SeparateWord
    {
        public static void Main(string[] args)
        {
            //how to separate string with any character

            string word = "Abraham"; //this is string
            string separator = " "; //this is separotor for separate above string
            string separatedWord = " "; //this is null value
            for (int i = 0; i < word.Length; i++)
            {
                separatedWord += word[i] + separator;
            }
            Console.WriteLine(separatedWord);
        }
    }
}