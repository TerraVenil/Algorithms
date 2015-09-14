using NUnit.Framework;

namespace Algorithms.Core.Tests
{
    [TestFixture]
    public class StringCompressTests
    {
        [Test]
        public void Compress1()
        {
            var result = String.Compress1("aaabbccccdde");

            Assert.That(result, Is.EqualTo("a3b2c4d2e1"));
        }

        [Test]
        public void Compress2()
        {
            var result = String.Compress1("abccdde");

            Assert.That(result, Is.EqualTo("abccdde"));
        }
    }
}