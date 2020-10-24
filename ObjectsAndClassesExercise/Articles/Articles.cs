using System;
using System.Collections.Generic;
using System.Linq;
namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sentence = Console.ReadLine().Split(", ").ToList();

            int numberOfCommands = int.Parse(Console.ReadLine());

            string title = sentence[0];
            string content = sentence[1];
            string author = sentence[2];

            var newText = new Article(title, content, author);

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine()
                    .Split(':')
                    .Select(s => s.Trim())
                    .ToList();

                if (command[0] == "Edit")
                {
                    newText.Content = command[1];
                }
                else if (command[0]=="ChangeAuthor")
                {
                    newText.Author = command[1];
                }
                else if (command[0] == "Rename")
                {
                    newText.Title = command[1];
                }

            }
            Console.WriteLine(newText);
        }
        class Article
        {
            public Article(string title,string content,string author)
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
    }
}
