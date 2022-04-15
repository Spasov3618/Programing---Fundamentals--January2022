using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            int countArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            string[] input;

            for (int i = 0; i < countArticles; i++)
            {
                input = Console.ReadLine().Split(", ");

                var article = new Article(input[0], input[1], input[2]);

                articles.Add(article);

            }

            string orderByWhat = Console.ReadLine();

            switch (orderByWhat)
            {
                case "title":
                    articles = articles.OrderBy(X => X.Title).ToList();
                    break;

                case "content":
                    articles = articles.OrderBy(X => X.Content).ToList();
                    break;

                case "author":
                    articles = articles.OrderBy(X => X.Author).ToList();
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
}
