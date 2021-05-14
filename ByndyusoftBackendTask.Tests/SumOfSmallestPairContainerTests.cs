using NUnit.Framework;

namespace ByndyusoftBackendTask.Tests
{
    [TestFixture]
    public class SumOfSmallestPairContainerTests
    {
        [Test]
        public void GetSumFromContainer_ArrayWithMoreThanOneElement_ExpectedSum()
        {
            var firstCase = new[] {2, 3};
            var secondCase = new[]{4, 0, 3, 19, 492, -10, 1};
            var thirdCase = new int[100000000];

            var scanner = new SmallestPairScanner();

            var firstContainer = new SumOfSmallestPairContainer(scanner, firstCase);
            var firstCaseResult = firstContainer.Sum;

            var secondContainer = new SumOfSmallestPairContainer(scanner, secondCase);
            var secondCaseResult = secondContainer.Sum;

            var thirdContainer = new SumOfSmallestPairContainer(scanner, thirdCase);
            var thirdCaseResult = thirdContainer.Sum;

            Assert.AreEqual(5, firstCaseResult);
            Assert.AreEqual(-10, secondCaseResult);
            Assert.AreEqual(0, thirdCaseResult);
        }
    }
}