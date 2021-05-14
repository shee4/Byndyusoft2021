using System;
using NUnit.Framework;

namespace ByndyusoftBackendTask.Tests
{
    [TestFixture]
    public class SmallestPairScannerTests
    {
        [Test]
        public void GetSmallestPair_ArrayWithLessThanTwoElements_ExceptionThrown()
        {
            var scanner = new SmallestPairScanner();

            var firstCase = Assert.Throws<ArgumentException>(() => scanner.GetSmallestPair(new[] {1}));
            Assert.That(firstCase.Message, Is.EqualTo("Not enough elements in array or array is null"));

            var secondCase = Assert.Throws<ArgumentException>(() => scanner.GetSmallestPair(Array.Empty<int>()));
            Assert.That(secondCase.Message, Is.EqualTo("Not enough elements in array or array is null"));
            
            //third case
            Assert.DoesNotThrow(() => scanner.GetSmallestPair(new []{1, 2, 3}));
        }

        [Test]
        public void GetSmallestPair_ArrayWithMoreThanOneElement_ExpectedPair()
        {
            var scanner = new SmallestPairScanner();
            
            var firstCase = new[] {2, 3};
            var secondCase = new[] {4, 0, 3, 19, 492, -10, 1};
            var thirdCase = new int[100000000];

            var firstCaseResult = scanner.GetSmallestPair(firstCase);
            var secondCaseResult = scanner.GetSmallestPair(secondCase);
            var thirdCaseResult = scanner.GetSmallestPair(thirdCase);

            Assert.AreEqual((2, 3), firstCaseResult);
            Assert.AreEqual((-10, 0), secondCaseResult );
            Assert.AreEqual((0, 0), thirdCaseResult);
        }
    }
}