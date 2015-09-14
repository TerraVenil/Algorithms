using System.Linq;

namespace Algorithms.Core
{
    public static partial class String
    {
        public static string Compress1(string value)
        {
            var compressed = string.Join("", value.GroupBy(x => x).Select(x => $"{x.Key}{x.Count()}"));

            return compressed.Length >= value.Length ? value : compressed;
        }
    }
}