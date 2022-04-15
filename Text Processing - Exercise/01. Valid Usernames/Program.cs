using System;
using System.Text;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Създайте програма, която чете потребителски имена на един ред(съединени от ", ") и отпечатва всички валидни потребителски имена.
            //Валидно потребителско име:
            //• Има дължина между 3 и 16 знака и
            //• Съдържа само букви, цифри, тирета и долни черти
            string[] username = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder rezult = new StringBuilder();
            foreach (string item in username)
            {
                if (item.Length >= 3 && item.Length <= 16)
                {
                    bool validUsernames = ValidUserNames(item);
                    if (validUsernames == true)
                    {
                        rezult.Append(item);
                       Console.WriteLine (item);
                    }
                }
            }
          
            
//            Console.WriteLine (string.Join(Environment.NewLine, rezult));

        }

        private static bool ValidUserNames(string user)
        {
            foreach (var symbol in user)
            {
                if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
            }    
        }
      