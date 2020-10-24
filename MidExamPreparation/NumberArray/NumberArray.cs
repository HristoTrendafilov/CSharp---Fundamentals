using System;
using System.Linq;
using System.Collections.Generic;
namespace NumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "End")
                {
                    break;
                }

                if (command[0] == "Switch")
                {
                    int index = int.Parse(command[1]);

                    if(index>=0 && index < number.Count)// =
                    {
                        int numberInArray = number[index];
                        if (number[index] > 0)
                        {
                            number[index] = numberInArray * -1;
                        }
                        else if (number[index] < 0)
                        {
                            number[index] = Math.Abs(numberInArray);
                        }
                    }
                }
                else if (command[0] == "Change")
                {

                    int index = int.Parse(command[1]);
                    int value = int.Parse(command[2]);

                    if (index >= 0 && index < number.Count)// =
                    {
                        number.RemoveAt(index);
                        number.Insert(index, value);
                    }
                    
                }
                else if(command[1]== "Negative")
                {
                    List<int> negativeNumber = new List<int>();

                    for (int i = 0; i < number.Count; i++)
                    {
                        if (number[i] < 0)
                        {
                            negativeNumber.Add(number[i]);
                        }
                    }
                    Console.WriteLine(negativeNumber.Sum());
                }
                else if(command[1]=="Positive")
                {
                    List<int> positiveNumber = new List<int>();

                    for (int i = 0; i < number.Count; i++)
                    {
                        if (number[i] >= 0)
                        {
                            positiveNumber.Add(number[i]);
                        }
                        Console.WriteLine(positiveNumber.Sum());
                    }
                }
                else if(command[1]=="All")
                {
                    Console.WriteLine(number.Sum());
                }

            }
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] >= 0)
                {
                    Console.Write($"{number[i]} ");
                }
               
            }

        }
    }
}
