namespace Algorithms.Core
{
    public class Swapper
    {
        /// <summary>
        /// XOR swap algorithm - https://en.wikipedia.org/wiki/XOR_swap_algorithm
        /// </summary>
        public static void Swap(ref char x, ref char y)
        {
            if (x == y)
            {
                return;
            }

            x ^= y;
            y ^= x;
            x ^= y;
        }
    }
}