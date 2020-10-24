using System;
using System.Linq;
using System.Collections.Generic;
namespace TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collectionOfWords = Console.ReadLine().Split().ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "Stop")
                {
                    break;
                }

                else if (command[0] == "Delete")
                {
                    int index = int.Parse(command[1]);

                    if (index < collectionOfWords.Count-1 && index>=0)
                    {
                        collectionOfWords.RemoveAt(index + 1);
                    }
                }
                else if (command[0] == "Swap")
                {
                    string word1 = command[1];
                    string word2 = command[2];

                    if (collectionOfWords.Contains(word1) && collectionOfWords.Contains(word2))
                    {
                        int indexWord1 = collectionOfWords.IndexOf(word1);
                        int indexWord2 = collectionOfWords.IndexOf(word2);

                        collectionOfWords[indexWord1] = word2;
                        collectionOfWords[indexWord2] = word1;
                    }
                }
                else if (command[0] == "Put")
                {
                    string word = command[1];
                    int index = int.Parse(command[2]);

                    if (index > 0 && index<=collectionOfWords.Count+1)
                    {
                        collectionOfWords.Insert(index - 1, word);
                    }
                }
                else   if (command[0] == "Sort")
                {
                    collectionOfWords.Sort();
                    collectionOfWords.Reverse();
                }
                else if (command[0] == "Replace")
                {
                    string word1 = command[1];
                    string word2 = command[2];

                    if (collectionOfWords.Contains(word2))
                    {
                        int indexWord2 = collectionOfWords.IndexOf(word2);

                        collectionOfWords.RemoveAt(indexWord2);
                        collectionOfWords.Insert(indexWord2, word1);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",collectionOfWords));
        }
    }
}
