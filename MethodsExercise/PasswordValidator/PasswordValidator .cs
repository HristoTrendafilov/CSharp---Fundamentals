using System;
using System.Linq;
namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            var passwordToCharArray = password.ToCharArray();

            int containsNumber = 0;
            bool isLetter = false;
            int falseLetter = 0;
            bool correctPassword = true;

            for (int i = 0; i < passwordToCharArray.Length; i++)
            {
                bool isDigit = char.IsDigit(passwordToCharArray[i]);

                if (isDigit)
                {
                    containsNumber++;
                }
                if ((passwordToCharArray[i] >= 'a' && passwordToCharArray[i] <= 'z' || 
                    passwordToCharArray[i]>='A' && passwordToCharArray[i]<='Z')||
                    passwordToCharArray[i]>='0' && passwordToCharArray[i]<='9')
                {
                    isLetter = true;
                }
                else
                {
                    falseLetter++;
                    
                }
            }

            if (password.Length<6)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
                correctPassword = false;
            }

            else if (password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
                correctPassword = false;
            }

            if (falseLetter >= 1)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                correctPassword = false;
            }

            if (containsNumber < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                correctPassword = false;
            }

            if (correctPassword)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
