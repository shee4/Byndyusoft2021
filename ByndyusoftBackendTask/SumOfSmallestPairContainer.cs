namespace ByndyusoftBackendTask
{
    public class SumOfSmallestPairContainer
    {
        public (int, int) SmallestPair { get; }
        
        public int Sum => SmallestPair.Item1 + SmallestPair.Item2;

        public int[] Array { get; }

        public SumOfSmallestPairContainer(IScanner scanner, int[] array)
        {
            Array = array;
            SmallestPair = scanner.GetSmallestPair(array);
        }
    }
}