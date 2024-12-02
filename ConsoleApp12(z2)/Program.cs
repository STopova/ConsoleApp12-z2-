using System;

namespace Second_Task
{
    class FibonacciEvenSum
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int sumEven = 0;

            while (a <= 4000000)
            {
                if (a % 2 == 0)
                {
                    sumEven += a;
                }

                int next = a + b;
                a = b;
                b = next;
            }

            Console.WriteLine(sumEven);
        }
    }
}
