using System;
using System.Linq;
using System.Collections.Generic;
namespace LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintingNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "END")
                {
                    break;
                }

                if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    int paintingNumber = int.Parse(command[2]);

                    if (index + 1 > paintingNumbers.Count)
                    {
                        continue;
                    }
                    else
                    {
                        paintingNumbers.Insert(index + 1, paintingNumber);
                    }
                }
                else if (command[0] == "Switch")
                {
                    int painting1 = int.Parse(command[1]);
                    int painting2 = int.Parse(command[2]);

                    if (paintingNumbers.Contains(painting1) && paintingNumbers.Contains(painting2))
                    {
                        for (int i = 0; i < paintingNumbers.Count; i++)
                        {
                            if (paintingNumbers[i] == painting1)
                            {
                                paintingNumbers.RemoveAt(i);
                                paintingNumbers.Insert(i, painting2);
                            }
                            else if(paintingNumbers[i] == painting2)
                            {
                                paintingNumbers.RemoveAt(i);
                                paintingNumbers.Insert(i, painting1);
                            }
                        }
                    }
                }
                else if (command[0] == "Hide")
                {
                    int paintingNumber = int.Parse(command[1]);

                    if (paintingNumbers.Contains(paintingNumber))
                    {
                        paintingNumbers.RemoveAt(paintingNumbers.IndexOf(paintingNumber));
                    }
                }
                else if (command[0] == "Reverse")
                {
                    paintingNumbers.Reverse();
                }
                else if (command[0] == "Change")
                {
                    int paintingNumber = int.Parse(command[1]);
                    int changedNumber = int.Parse(command[2]);

                    if (paintingNumbers.Contains(paintingNumber))
                    {
                        paintingNumbers.Insert(paintingNumbers.IndexOf(paintingNumber), changedNumber);
                        paintingNumbers.RemoveAt(paintingNumbers.IndexOf(paintingNumber));
                    }

                }
            }
            Console.WriteLine(string.Join(" ",paintingNumbers));
        }
    }
}
