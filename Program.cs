using System;

namespace task_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Shaffle(array);

            Console.WriteLine("\nВывод после тасовки: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static Random random = new Random();

        static int[] Shaffle(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int randomNumber = i + (int)(random.NextDouble() * (array.Length - i));
                int randomNumberFromArray = array[randomNumber];
                array[randomNumber] = array[i];
                array[i] = randomNumberFromArray;
            }

            return array;
        }
    }
}
