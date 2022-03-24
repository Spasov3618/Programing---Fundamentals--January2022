using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
namespace _3._Post_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");
            var dictionaryLetterAndWordLength = new Dictionary<char, int>();
            string firstPart = input[0];
            string secondPart = input[1];
            string thirdPart = input[2];

            Regex regexForTheLettersInFirstPart = new Regex(@"(\$|#|%|\*|&)(?<capitalLetters>[A-Z]+)(\1)");
            MatchCollection matchesCapitalLettersInTheFirstPart = regexForTheLettersInFirstPart.Matches(firstPart);
            Regex regexForTheDigitsInTheSecondPart = new Regex(@"([0-9][0-9]):([0-9][0-9])");
            MatchCollection matchesDigitsInTheSecondPart = regexForTheDigitsInTheSecondPart.Matches(secondPart);
            string[] wordsInTheThirdPart = thirdPart.Split();

            if (regexForTheLettersInFirstPart.IsMatch(firstPart) && regexForTheDigitsInTheSecondPart.IsMatch(secondPart))
            {
                string cappitalLetter = matchesCapitalLettersInTheFirstPart[0].Groups["capitalLetters"].Value; //NB!
                foreach (var letter in cappitalLetter)
                {
                    foreach (Match digits in matchesDigitsInTheSecondPart)
                    {
                        string firstDigit = digits.Groups[1].Value;
                        int firstLetterInt = int.Parse(firstDigit);
                        char firstLetterChar = (char)firstLetterInt;
                        string wordLength = digits.Groups[2].Value;
                        int wordLengthInt = int.Parse(wordLength);

                        if (letter == firstLetterChar)
                        {
                            dictionaryLetterAndWordLength[letter] = wordLengthInt + 1;
                            break;
                        }
                    }
                }

                foreach (var kvp in dictionaryLetterAndWordLength)
                {
                    char letter = kvp.Key;
                    int wordLength = kvp.Value;

                    foreach (string word in wordsInTheThirdPart)
                    {
                        char currentFirstLetter = word[0];
                        int currentWordLength = word.Length;

                        if (letter == currentFirstLetter && wordLength == currentWordLength)
                        {
                            Console.WriteLine(word);
                            break;
                        }
                    }
                }
            }
        }
    }
}
