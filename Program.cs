using System;
using System.Security.Cryptography;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int minValue = 0;
            int maxValue = 100;

            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue + 1);
            }

            Console.WriteLine($"Массив до сортировки: {string.Join(" ", numbers)}");

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine($"Массив после сортировки: {string.Join(" ", numbers)}");
        }
    }
}
