using System;

namespace Algorithms.Core
{
    public static partial class String
    {
        public static string Reverse1(string value)
        {
            var array = value.ToCharArray();
            var index1 = 0;
            var index2 = value.Length - 1;
            for (; index1 < index2; index1++, index2--)
            {
                var current = value[index1];
                var end = value[index2];
                array[index1] = end;
                array[index2] = current;
            }

            return new string(array);
        }

        public static string Reverse2(string value)
        {
            var array = value.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static string Reverse3(string value)
        {
            var reverse = string.Empty;
            for (var i = value.Length - 1; i > -1; i--)
            {
                reverse += value[i];
            }

            return reverse;
        }
    }
}