using System.Linq;

namespace Algorithms.Core
{
    using System;

    /// <summary>
    /// The string.
    /// </summary>
    public static class String
    {
        /// <summary>
        /// Time complexity - O(n*n), where n - length of the string
        /// Space complexity - O(1)
        /// </summary>
        public static bool IsUniqueCharacters1(string value)
        {
            var length = value.Length;

            for (var i = 0; i < length; i++)
            {
                for (var j = 0; j < length; j++)
                {
                    if (i == j)
                        continue;

                    if (value.ElementAt(i) == value.ElementAt(j))
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Time complexity - O(n), where n - length of the string
        /// Space complexity - O(1)
        /// </summary>
        public static bool IsUniqueCharacters2(string value)
        {
            if (value.Length > 256)
                return false;

            var charSet = new bool[256];
            for (var i = 0; i < value.Length; i++)
            {
                int val = value.ElementAt(i);

                if (charSet[val])
                {
                    return false;
                }

                charSet[val] = true;
            }

            return true;
        }

        /// <summary>
        /// Time complexity - O(n * log(n))
        /// </summary>
        public static bool IsUniqueCharacters3(string value)
        {
            var sortedString = value.ToCharArray();
            Array.Sort(sortedString);

            for (var i = 0; i < sortedString.Length - 1; i++)
            {
                if (sortedString[i] == sortedString[i + 1])
                    return false;
            }

            return true;
        }

        public static bool IsUniqueCharacters4(string value)
        {
            return !value.GroupBy(c => c).Any(g => g.Count() > 1);
        }
    }
}
