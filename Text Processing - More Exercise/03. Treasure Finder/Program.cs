using System;
using System.Linq;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] key = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
            string word;
            while ((word = Console.ReadLine()) != "find")
            {
            string newWord = "";
            int startIndexMetal = 0;
            int endIndexMetal = 0;
            int startIndexCordinates = 0;
            int endIndexCordinates = 0;
            string metal = "";
            string cordinates = "";
                    int counter = 0;
                for (int i = 0; i < word.Length; i++)
                {
                   
                        int sumbol = (int)word[i];
                        int newSymbol = sumbol - key[counter];
                        newWord += (char)newSymbol;
                        
                        counter++;

                        if (counter > key.Length-1)
                        {
                            counter = 0;
                        }

                        
                   
                    
                }
                startIndexMetal = newWord.IndexOf('&');
                endIndexMetal = newWord.LastIndexOf('&');
                metal = newWord.ToString().Substring(startIndexMetal + 1, endIndexMetal - startIndexMetal - 1);
                startIndexCordinates = newWord.IndexOf('<');
                endIndexCordinates = newWord.IndexOf('>');
                cordinates = newWord.Substring(startIndexCordinates+1, endIndexCordinates - startIndexCordinates - 1);
                Console.WriteLine($"Found {metal} at {cordinates}");
            }
        }
    }
}
