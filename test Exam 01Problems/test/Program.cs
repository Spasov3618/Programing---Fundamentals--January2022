using System;
using System.Text.RegularExpressions;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text =
        "Няма скара, няма бира, няма к'во да ям.";
            // Регулярен израз за търсене на последователности
            // от букви и цифри, завършващи на "ира", подниз 
            // "скара" и думи, съдържащи в себе си подниз "ям"
            string pattern = @"\w*ира|скара|\w*ям\w*";
            Match match = Regex.Match(text, pattern);
            while (match.Success)
            {
                Console.WriteLine(
                    "Низ: \"{0}\" - начало {1}, дължина {2}",
                    match, match.Index, match.Length);
                match = match.NextMatch();
            }

        }
    }
}
