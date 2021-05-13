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
    }
}