using System;
using System.Linq;
namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
         {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbersSplit = new int[numbers.Length];

            int maxEven = int.MinValue;
            int maxOdd = int.MinValue;
            int minEven = int.MaxValue;
            int minOdd = int.MaxValue;

            int maxEvenCounter = 0;
            int maxOddCounter = 0;
            int minEvenCounter = 0;
            int minOddCounter = 0;

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandSplit = command.Split().ToArray();

                if (commandSplit[0] == "first" && commandSplit[2] == "even")
                {
                    int countIndex = int.Parse(commandSplit[1]);

                    if (countIndex > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    int[] evenNumbers = new int[countIndex];
                    int evenCount = 0;
                    bool exactEvenNumber = false;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (evenCount >= countIndex)
                        {
                            break;
                        }
                        if (numbers[i] % 2 == 0)
                        {
                            evenNumbers[i] = numbers[i];
                            evenCount++;
                        }                       
                    }
                    if (evenCount == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    if (evenCount == countIndex)
                    {
                        exactEvenNumber = true;
                    }
                    if (evenCount < countIndex && evenCount>0)
                    {
                        if (evenCount == 1)
                        {
                            Console.WriteLine($"[{evenNumbers[0]}]");
                            command = Console.ReadLine();
                            continue;
                        }
                        Array.Resize<int>(ref evenNumbers, evenCount);
                        Console.WriteLine($"[{string.Join(", ", evenNumbers)}]");
                    }
                    if (exactEvenNumber)
                    {
                        Console.WriteLine($"[{string.Join(", ", evenNumbers)}]");
                    }
                }
                if (commandSplit[0] == "first" && commandSplit[2] == "odd")
                {
                    int countIndex = int.Parse(commandSplit[1]);

                    if (countIndex > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    int[] oddNumbers = new int[countIndex];
                    int oddCount = 0;
                    bool exactEvenNumber = false;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (oddCount >= countIndex)
                        {
                            break;
                        }
                        if (numbers[i] % 2 == 1)
                        {
                            oddNumbers[i] = numbers[i];
                            oddCount++;
                        }
                    }
                    if (oddCount == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    if (oddCount == countIndex)
                    {
                        exactEvenNumber = true;
                    }
                    if (oddCount < countIndex && oddCount > 0)
                    {
                        if (oddCount == 1)
                        {
                            Console.WriteLine($"[{oddNumbers[0]}]");
                            command = Console.ReadLine();
                            continue;
                        }
                        Array.Resize<int>(ref oddNumbers, oddCount);
                        Console.WriteLine($"[{string.Join(", ", oddNumbers)}]");
                    }
                    if (exactEvenNumber)
                    {
                        Console.WriteLine($"[{string.Join(", ", oddNumbers)}]");
                    }
                }
                if (commandSplit[0] == "last" && commandSplit[2] == "even")
                {
                    int countIndex = int.Parse(commandSplit[1]);

                    if (countIndex > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    int[] evenNumbers = new int[countIndex];
                    int evenCount = 0;
                    bool exactEvenNumber = false;

                    for (int i = numbers.Length-1; i >=0; i--)
                    {
                        if (evenCount >= countIndex)
                        {
                            break;
                        }
                        if (numbers[i] % 2 == 0)
                        {
                            evenNumbers[evenCount] = numbers[i];
                            evenCount++;
                        }
                    }
                    if (evenCount == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    if (evenCount == countIndex)
                    {
                        exactEvenNumber = true;
                    }
                    if (evenCount < countIndex && evenCount > 0)
                    {
                        if (evenCount == 1)
                        {
                            Console.WriteLine($"[{evenNumbers[0]}]");
                            command = Console.ReadLine();
                            continue;
                        }
                        int[] reverseLastEven = new int[evenNumbers.Length];
                        int j = 0;

                        for (int i = evenNumbers.Length-1; i >=0; i--)
                        {
                            reverseLastEven[j] = evenNumbers[i];
                            j++;
                        }

                        Array.Resize<int>(ref reverseLastEven, evenCount);
                        Console.WriteLine($"[{string.Join(", ", reverseLastEven)}]");
                    }
                    if (exactEvenNumber)
                    {
                        int[] reverseLastEven = new int[evenNumbers.Length];
                        int j = 0;

                        for (int i = evenNumbers.Length - 1; i >= 0; i--)
                        {
                            reverseLastEven[j] = evenNumbers[i];
                            j++;
                        }
                        Console.WriteLine($"[{string.Join(", ", reverseLastEven)}]");
                    }
                }
                if (commandSplit[0] == "last" && commandSplit[2] == "odd")
                {
                    int countIndex = int.Parse(commandSplit[1]);

                    if (countIndex > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    int[] oddNumbers = new int[countIndex];
                    int oddCount = 0;
                    bool exactOddNumber = false;

                    for (int i = numbers.Length - 1; i >= 0; i--)
                    {
                        if (oddCount >= countIndex)
                        {
                            break;
                        }
                        if (numbers[i] % 2 == 1)
                        {
                            oddNumbers[oddCount] = numbers[i];
                            oddCount++;
                        }
                    }
                    if (oddCount == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    if (oddCount == countIndex)
                    {
                        exactOddNumber = true;
                    }
                    if (oddCount < countIndex && oddCount > 0)
                    {
                        if (oddCount == 1)
                        {
                            Console.WriteLine($"[{oddNumbers[0]}]");
                            command = Console.ReadLine();   
                            continue;
                        }
                        int[] reverseLastOdd = new int[oddNumbers.Length];
                        int j = 0;

                        for (int i = oddNumbers.Length - 1; i >= 0; i--)
                        {

                            reverseLastOdd[j] = oddNumbers[i];
                            j++;
                        }

                        Array.Resize<int>(ref reverseLastOdd, oddCount);
                        Console.WriteLine($"[{string.Join(", ", reverseLastOdd)}]");
                    }
                    if (exactOddNumber)
                    {
                        int[] reverseLastEven = new int[oddNumbers.Length];
                        int j = 0;

                        for (int i = oddNumbers.Length - 1; i >= 0; i--)
                        {
                            reverseLastEven[j] = oddNumbers[i];
                            j++;
                        }
                        Console.WriteLine($"[{string.Join(", ", reverseLastEven)}]");
                    }
                }
                if (commandSplit[0] == "exchange")
                {
                    int exchangeIndex = int.Parse(commandSplit[1]);
                    int indexCount = 0;

                    if (exchangeIndex == numbers.Length-1)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    if (exchangeIndex>=0 && exchangeIndex < numbers.Length - 1)
                    {
                        for (int i = exchangeIndex + 1; i < numbersSplit.Length; i++)
                        {
                            numbersSplit[indexCount] = numbers[i];
                            indexCount++;
                        }
                        for (int i = 0; i <= exchangeIndex; i++)
                        {
                            numbersSplit[indexCount] = numbers[i];
                            indexCount++;
                        }
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] = numbersSplit[i];
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                if (command == "max even")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] %2==0)
                        {
                            if (numbers[i] >= maxEven)
                            {
                                maxEven = numbers[i];
                                maxEvenCounter = i;
                            }                           
                        }
                    }
                    if (maxEven == int.MinValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxEvenCounter);
                    }
                    
                }
                if (command == "min even")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 2 ==0)
                        {
                            if (numbers[i] <= minEven)
                            {
                                minEven = numbers[i];
                                minEvenCounter = i;
                            }
                        }
                    }
                    if (minEven == int.MaxValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minEvenCounter);
                    }
                }
                if (command == "max odd")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            if (numbers[i] >= maxOdd)
                            {
                                maxOdd = numbers[i];
                                maxOddCounter = i;
                            }
                        }
                    }
                    if (maxOdd == int.MinValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxOddCounter);
                    }
                }
                if (command == "min odd")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            if (numbers[i] <= minOdd)
                            {
                                minOdd = numbers[i];
                                minOddCounter = i;
                            }
                        }
                    }
                    if (minOdd == int.MaxValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minOddCounter);
                    }
                }
                
                command = Console.ReadLine();
            }
            
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
            
            
        }
    }
}
