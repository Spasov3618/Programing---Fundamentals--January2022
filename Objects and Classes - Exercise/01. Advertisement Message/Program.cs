using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that generates random fake advertisement messages to advertise a product.The messages must consist of 4 parts:
            //phrase + event + author + city. Use the following predefined parts:
            //•	Phrases – { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."}
            //•	Events – { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
            //•	Authors – { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
            //•	Cities – { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}
            //        The format of the output message is the following: "{phrase} {event} {author} – {city}."
            //You will receive the number of messages to be generated. Print each random message at a separate line.
            int n = int.Parse(Console.ReadLine());
            string[] phrase = new string[]
            {
                 "Excellent product.","Such a great product.","I always use that product.","Best product of its category.","Exceptional product.",
                "I can’t live without this product."
            };
            string[] events = new string[]
            {
                "Now I feel good.","I have succeeded with this product.","Makes miracles. I am happy of the results!","I cannot believe but now I feel awesome.","Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            string[] city = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };
            
            
                Random phrase1 = new Random();
                Random events1 = new Random();
                Random authors1 = new Random();
                Random city1 = new Random();

                for (int j = 0; j <n; j++)
                {
                    int phraseIndex = phrase1.Next(0,phrase.Length);
                    int eventsIndex = events1.Next(0, events.Length);
                    int authorsIndex = authors1.Next(0, authors.Length);
                    int cityIndex = city1.Next(0, city.Length);

                    Console.WriteLine($"{phrase[phraseIndex]} {events[eventsIndex]} {authors[authorsIndex]} - {city[cityIndex]}");
                }

            
        }
    }
}
