using System;

namespace ByndyusoftBackendTask
{
    public class SmallestPairScanner : IScanner
    {
        public (int, int) GetSmallestPair(int[] array)
        {
            if(array == null || array.Length < 2)
                throw new ArgumentException("Not enough elements in array or array is null");

            return (0, 0);
        }
    }
}