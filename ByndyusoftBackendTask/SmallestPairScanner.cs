using System;

namespace ByndyusoftBackendTask
{
    public class SmallestPairScanner : IScanner
    {
        public (int, int) GetSmallestPair(int[] array)
        {
            if(array == null || array.Length < 2)
                throw new ArgumentException("Not enough elements in array or array is null");

            var first = int.MaxValue;
            var second = int.MaxValue;

            foreach (var el in array)
            {
                if (el < first)
                {
                    second = first;
                    first = el;
                }
                else if (el < second)
                {
                    second = el;
                };
            }

            return (first, second);
        }
    }
}