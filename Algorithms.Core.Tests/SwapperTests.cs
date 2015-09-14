using Xunit;

namespace Algorithms.Core.Tests
{
    public class SwapperTests
    {
        [Fact]
        public void SwapTwoChars()
        {
            var ab = new[] { 'a', 'b' };

            Swapper.Swap(ref ab[0], ref ab[1]);

            Assert.Equal('b', ab[0]);
            Assert.Equal('a', ab[1]);
        }
    }
}