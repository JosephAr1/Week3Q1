using System;

namespace Week3Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] display = new int[10];
            int i;
            int number1, sum = 0, count = 0;

            for(number1=0; number1<=10; number1++)
            {
                for (i = 1; i <= 10; i++)
                {
                    if(number1 % 1 == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            number1 = 1;
            sum = 0;
            while (number1 <= 10)
            {
                Console.WriteLine(number1);
                sum = sum + number1;
                number1 = number1 + 2;
            }
            Console.WriteLine("Sum of all  Odd numbers till 10 = " + sum.ToString());
        }
    }
}
