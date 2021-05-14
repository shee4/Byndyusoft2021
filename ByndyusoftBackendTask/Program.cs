using System;

namespace ByndyusoftBackendTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var array = new[] {4, 0, 3, 19, 492, -10, 1};
            var scanner = new SmallestPairScanner();
            var smallestPair = new SumOfSmallestPairContainer(scanner, array);

            Console.WriteLine("Array of numbers:");
            foreach (var el in array) 
                Console.Write(el + " ");
            Console.Write("\nSmallest pair:" + smallestPair.SmallestPair + "\nSum of smallest pair: ");
            Console.Write(smallestPair.Sum);
        }
    }
}