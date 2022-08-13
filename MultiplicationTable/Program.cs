using System;

namespace MultiplicationTable 
{
    public class MultTbale 
    {
        public static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("Number is invalid! ");
                Console.WriteLine("Valid number is 1 , 2 , 3 ... 10");
            }
            if (num < 1)
            {
                Console.WriteLine("Number is invalid! ");
                Console.WriteLine("Valid number is 1 , 2 , 3 ... 10");
            }
            if (num > 10)
            {
                Console.WriteLine("Number is invalid! ");
                Console.WriteLine("Valid number is 1 , 2 , 3 ... 10");
            }
            else
            {
                for(i = 1; i <= num; i++)
                {
                    for(j = 1; j <= 10; j++)
                    {
                        Console.WriteLine("{0} * {1} = {2}" ,i ,j , i * j);
                    }
                }
            }
        }
    }
}