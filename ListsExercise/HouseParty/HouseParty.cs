using System;
using System.Linq;
using System.Collections.Generic;
namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommand = int.Parse(Console.ReadLine());
            List<string> namesOfGuests = new List<string>();
            List<string> namesOfGuestsNotComming = new List<string>();
            bool isInTheList = false;

            for (int i = 0; i < numberOfCommand; i++)
            {
                isInTheList = false;
                string guestInfo = Console.ReadLine();
                string[] guestInfoToArray = guestInfo.Split().ToArray();
                string guestName = guestInfoToArray[0];

                if (guestInfoToArray[1] == "is" && guestInfoToArray[2] == "going!")
                {
                    for (int j = 0; j < namesOfGuests.Count; j++)
                    {
                        if (namesOfGuests[j] == guestName)
                        {
                            Console.WriteLine($"{guestName} is already in the list!");
                            isInTheList = true;
                            break;
                        }                        
                    }
                    if (!isInTheList)
                    {
                        namesOfGuests.Add(guestName);
                    }
                }
                if (guestInfoToArray[1] == "is" && guestInfoToArray[2] == "not")
                {
                    namesOfGuestsNotComming.Add(guestName);
                    for (int l = 1; l < namesOfGuestsNotComming.Count; l++)
                    {
                        if (namesOfGuestsNotComming[l] == guestName)
                        {
                            namesOfGuestsNotComming.RemoveAt(l);
                        }
                    }
                    for (int j = 0; j < namesOfGuests.Count; j++)
                    {
                        if (namesOfGuests[j] == guestName)
                        {
                            namesOfGuests.RemoveAt(j);                     
                        }
                    }
                }
            }
            if (namesOfGuestsNotComming.Count > 0)
            {
                for (int i = 0; i < namesOfGuestsNotComming.Count; i++)
                {
                    Console.WriteLine($"{namesOfGuestsNotComming[i]} is not in the list!");
                }
                for (int i = 0; i < namesOfGuests.Count; i++)
                {
                    Console.WriteLine(namesOfGuests[i]);
                }
            }
            else
            {
                for (int i = 0; i < namesOfGuests.Count; i++)
                {
                    Console.WriteLine(namesOfGuests[i]);
                }
            }
        }
    }
}
