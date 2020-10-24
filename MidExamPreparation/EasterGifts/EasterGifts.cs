using System;
using System.Linq;
using System.Collections.Generic;
namespace EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine().Split().ToList();

            while (true)
            {
               List<string>command= Console.ReadLine().Split().ToList();

                if (command[0]=="No" && command[1] == "Money")
                {
                    break;
                }
                else if (command[0] == "OutOfStock")
                {
                    string gift = command[1];

                    for(int i=0;i<gifts.Count;i++)
                    {
                        if (gifts[i]==gift)
                        { 
                            gifts.RemoveAt(i);
                            gifts.Insert(i, "None");
                        }
                    }
                }
                else if (command[0] == "Required")
                {
                    string gift = command[1];
                    int index = int.Parse(command[2]);

                    if(index>=0 && index <= gifts.Count-1)
                    {
                        gifts.RemoveAt(index);
                        gifts.Insert(index, gift);
                    }
                }
                else if (command[0] == "JustInCase")
                {
                    string gift = command[1];

                    gifts.RemoveAt(gifts.Count - 1);
                    gifts.Add(gift);
                }
            }
            for (int i = 0; i < gifts.Count; i++)
            {
                if (gifts[i] != "None")
                {
                    Console.Write($"{gifts[i]} ");
                }
            }
        }
    }
}
