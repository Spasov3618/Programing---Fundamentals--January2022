using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //На първия ред ще ви бъде дадено потребителско име, вашата задача е да опитате да влезете в потребителя.Паролата на потребителя е обърната.На следващите редове ще получите пароли:
            //• Ако паролата е неправилна, отпечатайте "Неправилна парола. Опитайте отново."
            //• Ако паролата е правилна, отпечатайте: "Потребител {username} е влязъл." и спрете програмата
            //Имайте предвид, че при четвъртия опит, ако паролата все още не е правилна, отпечатайте: „Потребителят { username}
            //е блокиран!“
            //След това програмата спира. 
            string username = Console.ReadLine();
            string newPassword = Console.ReadLine();
            string password = "";
            for (int i = username.Length -1; i >= 0; i--)
            {
                char c = username[i] ;
                password += c;
            }
            for (int j = 1; j<= 4; j++)
            {
                if (j==4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

            if (newPassword!= password)
            {
                Console.WriteLine("Incorrect password. Try again.");
                newPassword = Console.ReadLine();
            }
             if (newPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
                    return;
            }
            }
          
        }
    }
}
