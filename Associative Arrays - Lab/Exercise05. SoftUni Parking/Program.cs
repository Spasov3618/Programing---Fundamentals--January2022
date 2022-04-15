using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //СофтУни току-що получи нов паркинг.Толкова е изискано, дори има онлайн валидиране за паркиране. Освен че онлайн услугата не работи. Той може да получава само потребителски данни, но не знае какво да прави с тях. Добре, че сте в екипа на разработчиците и знаете как да го поправите, нали?
            //Напишете програма, която валидира място за паркиране за онлайн услуга.Потребителите могат да се регистрират за паркиране и да отменят регистрацията, за да напуснат.
            //Програмата получава 2 команди:
            //• "регистрирайте {username} {licensePlateNumber}":
            //o Системата поддържа само една кола на потребител в момента, така че ако потребител се опита да регистрира друга регистрационна табела, използвайки същото потребителско име, системата трябва да отпечата:
            //„ГРЕШКА: вече е регистриран с номер на табела { licensePlateNumber}“
            //o Ако гореспоменатите проверки преминат успешно, табелата може да бъде регистрирана, така че системата трябва да отпечата:
            // „{ username} успешно регистрира { licensePlateNumber}“
            //• "отмяна на регистрация на {username}":
            //o Ако потребителят не присъства в базата данни, системата трябва да отпечата:
            //„ГРЕШКА: потребител { username} не е намерен“
            //o Ако гореспоменатата проверка премине успешно, системата трябва да отпечата:
            //„{ username} се отмени успешно“
            //След като изпълните всички команди, отпечатайте всички регистрирани потребители и техните регистрационни номера във формата:
            //• „{ username} => { licensePlateNumber}“
            //Вход
            //• Първи ред: n - брой команди – цяло число
            //• Следващи n реда: команди в един от двата възможни формата:
            //            o Регистрирайте се: "регистрирайте {username} {licensePlateNumber}"
            //o Отмяна на регистрация: "отмяна на регистрация {username}"
            //Въвеждането винаги ще бъде валидно и не е необходимо да го проверявате изрично.
            int num = int.Parse(Console.ReadLine());
            Dictionary<string,string> dic = new Dictionary<string,string>();
            for (int i = 0; i < num; i++)

            {
                string[] command = Console.ReadLine().Split(' ');
                string arg = command[0];
                string name = command[1];
                if (arg == "register")
                {
                string license = command[2];
                    if (!dic.ContainsKey(name))
                    {
                        dic.Add(name, license);
                        Console.WriteLine($"{name} registered {license} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {dic[name]}");
                    }
                }
                else if (arg == "unregister")
                {
                    if (dic.ContainsKey(name))
                    {
                        dic.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
            
        }
    }
}
