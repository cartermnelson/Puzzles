using System;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomArray();
            // TossCoin();
            Console.WriteLine(TossMultipleCoins(3));
        }
        public static int[] RandomArray()
        {
            int[] arr = new int[10];
            arr[0] = new Random().Next(5, 26);
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(5, 26);
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
        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            int result = new Random().Next(0, 2);
            if (result == 0)
            {
                Console.WriteLine("Heads");
                return "Heads";
            }
            else
            {
                Console.WriteLine("Tails");
                return "Tails";
            }
        }
        public static double TossMultipleCoins(int num)
        {
            double heads = 0;
            for (int i = 0; i <= num; i++)
            {
                if (TossCoin() == "Heads")
                {
                    heads++;
                }
            }
            return heads/num;
        }
    }
}
