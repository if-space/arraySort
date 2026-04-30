using System;
using System.Security.Cryptography;

namespace Lessons
{
    class Programm
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int minValue = 0;
            int maxValue = 100;
            int step = 1;

            Random value = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = value.Next(minValue, maxValue);
            }

            Console.WriteLine($"Массив до сортировки: {string.Join(" ", numbers)}");

            for (int i = 0; i < numbers.Length; i++) 
            {
                for (int j = 0; j < numbers.Length - 1; j++) 
                {
                    if (numbers[j] > numbers[j + step])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + step];
                        numbers[j + step] = temp;
                    }
                }
            }

            Console.WriteLine($"Массив после сортировки: {string.Join(" ", numbers)}");
        }
    }
}