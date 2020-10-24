using System;
using System.Collections.Generic;
using System.Linq;
namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var userNames = Console.ReadLine().Split(", ");
            var correctUsernames = new List<string>();

            for (int i = 0; i < userNames.Length; i++)
            {
                bool isNotValid = false;
                var charUserName = userNames[i].ToCharArray();

                if (charUserName.Length>= 3 && charUserName.Length<= 16)
                {
                    for (int j = 0; j < charUserName.Length; j++)
                    {

                        if (char.IsLetterOrDigit(charUserName[j])|| charUserName[j]=='-' || charUserName[j]=='_')
                        {
                            continue;
                        }
                        else
                        {
                            isNotValid = true;
                            break;
                        }
                    }
                    if (isNotValid == false)
                    {
                        correctUsernames.Add(userNames[i]);
                    }
                }
            }
            foreach (var username in correctUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
