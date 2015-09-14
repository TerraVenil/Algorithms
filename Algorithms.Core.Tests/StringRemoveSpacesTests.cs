using NUnit.Framework;

namespace Algorithms.Core.Tests
{
    [TestFixture]
    public class StringRemoveSpacesTests
    {
        [TestCase("Mr John Smith               ")]
        [TestCase("               Mr John Smith")]
        public void RemoveSpaces1(string value)
        {
            var result = String.RemoveSpaces1(value);

            Assert.That(result, Is.EqualTo("Mr%20John%20Smith"));
        }

        [TestCase("Mr John Smith               ")]
        [TestCase("               Mr John Smith")]
        public void RemoveSpaces2(string value)
        {
            var result = String.RemoveSpaces2(value, 13);

            Assert.That(result, Is.EqualTo("Mr%20John%20Smith"));
        }

        [TestCase("Mr John Smith               ")]
        [TestCase("               Mr John Smith")]
        public void RemoveSpaces3(string value)
        {
            var result = String.RemoveSpaces3(value);

            Assert.That(result, Is.EqualTo("Mr%20John%20Smith"));
        }

        [Test]
        public void RemoveSpaces4()
        {
            var result = String.RemoveSpaces4("Mr John Smith               ", 13);

            Assert.That(result, Is.EqualTo("Mr%20John%20Smith"));
        }
    }
}