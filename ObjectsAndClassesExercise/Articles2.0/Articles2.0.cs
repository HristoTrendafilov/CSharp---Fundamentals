using System;
using System.Collections.Generic;
using System.Linq;
namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Articles> totalArticles = new List<Articles>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                List<string> inputArticle = Console.ReadLine().Split(", ").ToList();

                string title = inputArticle[0];
                string content = inputArticle[1];
                string author = inputArticle[2];

                var newArticle = new Articles();

                newArticle.Title = title;
                newArticle.Content = content;
                newArticle.Author = author;

                totalArticles.Add(newArticle);
            }
            string command = Console.ReadLine();

            if (command == "title")
            {
                List<Articles> SortedList = totalArticles.OrderBy(o => o.Title).ToList();

                for (int i = 0; i < SortedList.Count; i++)
                {
                    Console.WriteLine(SortedList[i]);
                }
            }
            else if (command == "content")
            {
                List<Articles> SortedList = totalArticles.OrderBy(o => o.Content).ToList();

                for (int i = 0; i < SortedList.Count; i++)
                {
                    Console.WriteLine(SortedList[i]);
                }
            }
            else if (command == "author")
            {
                List<Articles> SortedList = totalArticles.OrderBy(o => o.Author).ToList();

                for (int i = 0; i < SortedList.Count; i++)
                {
                    Console.WriteLine(SortedList[i]);
                }
            }
        }
        class Articles
        {

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

    }
}
