using System;
using System.Linq;

namespace PointsBet_Backend_Online_Code_Test
{
    public static class StringFormatter
    {
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            return string.Join(", ", items.Select(item => quote.Length > 0 ?item.Replace(quote, $"\\{quote}") : item).Select(item => $"{quote}{item}{quote}"));
        }
    }

    class Program {
        static void Main() {
            Console.WriteLine(StringFormatter.ToCommaSeparatedList(new[] { "test", "one" }, "'"));
            Console.WriteLine(StringFormatter.ToCommaSeparatedList(new[] { "te'st", "one" }, "'"));
            Console.WriteLine(StringFormatter.ToCommaSeparatedList(new[] { "te'st", "one" }, ""));
            Console.WriteLine(StringFormatter.ToCommaSeparatedList(new string[0], "!"));
            Console.WriteLine(StringFormatter.ToCommaSeparatedList(new string[0], "''"));
        }
    }
}
