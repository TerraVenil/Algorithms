using NUnit.Framework;

namespace Algorithms.Core.Tests
{
    [TestFixture]
    public class StringIsPermutationTests
    {
        [TestCase("ab", "ba")]
        [TestCase("abc", "bca")]
        [TestCase("abc", "bac")]
        [TestCase("abc", "cba")]
        [TestCase("abc", "cab")]
        [TestCase("abdc", "bcda")]
        public void IsPermutation1True(string value1, string value2)
        {
            var result = String.IsPermutation1(value1, value2);

            Assert.That(result, Is.True);
        }

        [TestCase("abc", "bcd")]
        public void IsPermutation1False(string value1, string value2)
        {
            var result = String.IsPermutation1(value1, value2);

            Assert.That(result, Is.False);
        }

        [TestCase("ab", "ba")]
        [TestCase("abc", "bca")]
        [TestCase("abc", "bac")]
        [TestCase("abc", "cba")]
        [TestCase("abc", "cab")]
        [TestCase("abdc", "bcda")]
        public void IsPermutation2True(string value1, string value2)
        {
            var result = String.IsPermutation2(value1, value2);

            Assert.That(result, Is.True);
        }

        [TestCase("abc", "bcd")]
        public void IsPermutation2False(string value1, string value2)
        {
            var result = String.IsPermutation2(value1, value2);

            Assert.That(result, Is.False);
        }

        [TestCase("ab", "ba")]
        [TestCase("abc", "bca")]
        [TestCase("abc", "bac")]
        [TestCase("abc", "cba")]
        [TestCase("abc", "cab")]
        [TestCase("abdc", "bcda")]
        public void IsPermutation3True(string value1, string value2)
        {
            var result = String.IsPermutation3(value1, value2);

            Assert.That(result, Is.True);
        }

        [TestCase("abc", "bcd")]
        public void IsPermutation3False(string value1, string value2)
        {
            var result = String.IsPermutation3(value1, value2);

            Assert.That(result, Is.False);
        }

        [TestCase("ab", "ba")]
        [TestCase("abc", "bca")]
        [TestCase("abc", "bac")]
        [TestCase("abc", "cba")]
        [TestCase("abc", "cab")]
        [TestCase("abdc", "bcda")]
        public void IsPermutation4True(string value1, string value2)
        {
            var result = String.IsPermutation4(value1, value2);

            Assert.That(result, Is.True);
        }

        [TestCase("abc", "bcd")]
        public void IsPermutation4False(string value1, string value2)
        {
            var result = String.IsPermutation4(value1, value2);

            Assert.That(result, Is.False);
        }

        [TestCase("ab", "ba")]
        [TestCase("abc", "bca")]
        [TestCase("abc", "bac")]
        [TestCase("abc", "cba")]
        [TestCase("abc", "cab")]
        [TestCase("abdc", "bcda")]
        public void IsPermutation5True(string value1, string value2)
        {
            var result = String.IsPermutation5(value1, value2);

            Assert.That(result, Is.True);
        }

        [TestCase("abc", "bcd")]
        public void IsPermutation5False(string value1, string value2)
        {
            var result = String.IsPermutation5(value1, value2);

            Assert.That(result, Is.False);
        }
    }
}