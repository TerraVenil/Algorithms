using NUnit.Framework;

namespace Algorithms.Core.Tests
{
    [TestFixture]
    public class StringReverseTests
    {
        [Test]
        public void Reverse1()
        {
            // abcd\0 - length equal 5
            var result = String.Reverse1("abcd" + char.MinValue);

            Assert.That(result, Is.EqualTo(char.MinValue + "dcba"));
        }

        [Test]
        public void Reverse2()
        {
            // abcd\0 - length equal 5
            var result = String.Reverse2("abcd" + char.MinValue);

            Assert.That(result, Is.EqualTo(char.MinValue + "dcba"));
        }

        [Test]
        public void Reverse3()
        {
            // abcd\0 - length equal 5
            var result = String.Reverse3("abcd" + char.MinValue);

            Assert.That(result, Is.EqualTo(char.MinValue + "dcba"));
        }
    }
}