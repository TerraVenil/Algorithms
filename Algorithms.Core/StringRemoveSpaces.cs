using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Algorithms.Core
{
    public static partial class String
    {
        public static string RemoveSpaces1(string value)
        {
            return value.Trim().Replace(" ", "%20");
        }

        public static string RemoveSpaces2(string value, int length)
        {
            var stringBuilder = new StringBuilder();
            using (var stringReader = new StringReader(value))
            {
                while (stringReader.Peek() != -1)
                {
                    var ch = (char)stringReader.Peek();
                    if (char.IsWhiteSpace(ch))
                    {
                        while (char.IsWhiteSpace(ch))
                        {
                            stringReader.Read();
                            ch = (char)stringReader.Peek();
                        }

                        if (stringBuilder.Length != 0 && stringBuilder.Length < length)
                        {
                            stringBuilder.Append("%20");
                        }
                    }
                    else
                    {
                        stringBuilder.Append((char)stringReader.Read());
                    }
                }
            }

            return stringBuilder.ToString();
        }

        public static string RemoveSpaces3(string str)
        {
            var reg1 = Regex.Replace(str, @"^\s+|\s+$", string.Empty);
            return Regex.Replace(reg1, @"\s+", "%20");
        }

        public static string RemoveSpaces4(string value, int length)
        {
            var modifiedString = string.Empty;
            for (var i = 0; i < length; i++)
            {
                if (char.IsWhiteSpace(value[i]))
                {
                    modifiedString += "%20";
                }
                else
                {
                    modifiedString += value[i];
                }
            }

            return modifiedString;
        }
    }
}