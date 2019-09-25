using System;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
        }
        public static int[] RandomArray()
        {
            int[] arr = new int[10];
            arr[0] = new Random().Next(5, 25);
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(5, 25);
                sum += arr[i];
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Min: {min} | Max: {max} | Sum: {sum}");
            return arr;
        }
    }
}
