using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Core
{
    public static partial class String
    {
        public static bool IsPermutation1(string value1, string value2)
        {
            var permutations = GetPermutationsWithYield(value1, string.Empty).ToList();

            return permutations.Contains(value2);
        }

        public static bool IsPermutation2(string value1, string value2)
        {
            if (value1.Length != value2.Length)
            {
                return false;
            }

            var charArray = value1.ToCharArray();
            var charSet = new int[256];

            foreach (var ch in charArray)
            {
                charSet[ch]++;
            }

            for (var j = 0; j < value2.Length; j++)
            {
                var c = value2.ElementAt(j);
                if (--charSet[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsPermutation3(string value1, string value2)
        {
            return Sort(value1).Equals(Sort(value2));
        }

        public static bool IsPermutation4(string value1, string value2)
        {
            return Permutations(value1.ToCharArray()).Contains(value2);
        }

        public static bool IsPermutation5(string value1, string value2)
        {
            var charArray = value1.ToCharArray();
            var permutations = GetPermutations(charArray, string.Empty, new List<string>()).ToList();

            return permutations.Contains(value2);
        }

        private static IEnumerable<string> GetPermutationsWithYield(string value, string accumulator)
        {
            if (accumulator.Length == value.Length)
                yield return accumulator;
            else
            {
                var charArray = value.ToCharArray();
                foreach (var ch in charArray)
                {
                    foreach (var ch1 in GetPermutationsWithYield(value, accumulator + ch))
                    {
                        yield return ch1;
                    }
                }
            }
        }

        private static List<string> GetPermutations(IEnumerable<char> charArray, string accumulator, List<string> permutationList)
        {
            if (accumulator.Length == charArray.Count())
            {
                permutationList.Add(accumulator);
                return permutationList;
            }
            else
            {
                var newPermutationList = permutationList;
                foreach (var ch in charArray)
                {
                    newPermutationList = GetPermutations(charArray, accumulator + ch, newPermutationList);
                }

                return newPermutationList;
            }
        }

        private static IEnumerable<string> Permutations(IEnumerable<char> source)
        {
            var c = source.Count();
            if (c == 1)
                yield return new string(source.ToArray());
            else
                for (var i = 0; i < c; i++)
                    foreach (var p in Permutations(source.Take(i).Concat(source.Skip(i + 1))))
                        yield return new string(source.Skip(i).Take(1).Concat(p).ToArray());
        }

        private static string Sort(string value1)
        {
            var charArray1 = value1.ToCharArray();
            Array.Sort(charArray1);
            return new string(charArray1);
        }
    }
}