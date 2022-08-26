using System;

namespace AIE
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 45, 6, 12, 51, 4, 23, 31 };

            for (int i = 0; i < numbers.Length; ++i)
            {
                Console.WriteLine(numbers[i]);
                Console.WriteLine(numbers[i + 1]);
            }

        }
    }
}