using System;

namespace task_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            WriteArray(array);

            Shaffle(array);

            Console.WriteLine("\nВывод после тасовки: ");

            WriteArray(array);
        }

        static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }


        static void Shaffle(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int randomNumber = i + (int)(random.NextDouble() * (array.Length - i));
                int randomNumberFromArray = array[randomNumber];
                array[randomNumber] = array[i];
                array[i] = randomNumberFromArray;
            }   
        }
    }
}
