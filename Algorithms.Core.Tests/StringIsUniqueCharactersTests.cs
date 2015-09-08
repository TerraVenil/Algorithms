using NUnit.Framework;

namespace Algorithms.Core.Tests
{
    [TestFixture]
    public class StringIsUniqueCharactersTests
    {
        /// <summary>
        /// ASCII - 256 (0 - 255) characters
        /// UTF16 - 65533 characters
        /// </summary>
        [TestCase("feljxiu")]
        [TestCase("9ik0;l")]
        [TestCase("f4iu")]
        [TestCase("rituo")]
        public void IsUniqueCharacters1True(string value)
        {
            var result = String.IsUniqueCharacters1(value);

            Assert.That(result, Is.True);
        }

        [TestCase("rituoi")]
        public void IsUniqueCharacters1False(string value)
        {
            var result = String.IsUniqueCharacters1(value);

            Assert.That(result, Is.False);
        }

        [TestCase("feljxiu")]
        [TestCase("9ik0;l")]
        [TestCase("f4iu")]
        [TestCase("rituo")]
        public void IsUniqueCharacters2True(string value)
        {
            var result = String.IsUniqueCharacters2(value);

            Assert.That(result, Is.True);
        }

        [TestCase("rituoi")]
        public void UniqueCharacters2False(string value)
        {
            var result = String.IsUniqueCharacters2(value);

            Assert.That(result, Is.False);
        }

        [TestCase("feljxiu")]
        [TestCase("9ik0;l")]
        [TestCase("f4iu")]
        [TestCase("rituo")]
        public void IsUniqueCharacters3True(string value)
        {
            var result = String.IsUniqueCharacters3(value);

            Assert.That(result, Is.True);
        }

        [TestCase("rituoi")]
        public void IsUniqueCharacters3False(string value)
        {
            var result = String.IsUniqueCharacters3(value);

            Assert.That(result, Is.False);
        }

        [TestCase("feljxiu")]
        [TestCase("9ik0;l")]
        [TestCase("f4iu")]
        [TestCase("rituo")]
        public void IsUniqueCharacters4True(string value)
        {
            var result = String.IsUniqueCharacters4(value);

            Assert.That(result, Is.True);
        }

        [TestCase("rituoi")]
        public void IsUniqueCharacters4False(string value)
        {
            var result = String.IsUniqueCharacters4(value);

            Assert.That(result, Is.False);
        }
    }
}
