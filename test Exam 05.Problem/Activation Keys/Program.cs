using System;

namespace Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Първият ред на входа ще бъде вашият необработен ключ за активиране.Ще се състои само от букви и цифри.
            //След това, докато не бъде дадена командата "Генериране", ще получавате низове с инструкции за различни операции, които трябва да се извършат върху необработения ключ за активиране.
            //Има няколко типа инструкции, разделени с ">>>":
            //• "Съдържа>>>{подниз}":
            //o Ако необработеният ключ за активиране съдържа дадения подниз, отпечатва: "{raw activation key} contains {substring}".
            //o В противен случай отпечатва: "Поднизът не е намерен!"
            //• "Flip>>>Upper/Dower>>>{startIndex}>>>{endIndex}":
            //o Променя подниз между дадените индекси(крайният индекс е изключителен) на главни или малки букви и след това отпечатва ключа за активиране.
            //o Всички дадени индекси ще бъдат валидни.
            //• "Slice>>>{startIndex}>>>{endIndex}":
            //o Изтрива знаците между началния и крайния индекс(крайният индекс е изключителен) и отпечатва ключа за активиране.
            //o И двата индекса ще бъдат валидни.
            //Вход
            //• Първият ред на входа ще бъде низ, състоящ се само от букви и цифри.
            //• След първия ред, докато не бъде дадена командата "Generate", ще получавате низове.
            //Изход
            //• След като бъде получена командата "Генериране", отпечатайте:
            //            o „Вашият ключ за активиране е: { активационен ключ}“
            string key = Console.ReadLine();
            string action;
            while ((action = Console.ReadLine()) != "Generate")
            {
                string [] arg = action.Split(">>>");
                if (arg[0] == "Contains")
                {
                    string word = arg[1];
                    if (key.Contains(word))
                    {
                        Console.WriteLine($"{key} contains {word}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (arg[0] == "Flip")
                {
                    string word = arg[1];
                    int startIndex = int.Parse(arg[2]);
                    int endIndex = int.Parse(arg[3]);
                    string sustring = key.Substring(startIndex, endIndex - startIndex);
                    if (word == "Upper")
                    {
                        
                        key = key.Replace(sustring, sustring.ToUpper());
                        Console.WriteLine(key);
                    }
                    else
                    {
                      key=  key.Replace(sustring, sustring.ToLower());
                        Console.WriteLine(key);
                    }
                }
                else if (arg[0] == "Slice")
                {
                    int startIndex = int.Parse(arg[1]);
                    int endIndex = int.Parse(arg[2]);   
                    key = key.Remove(startIndex,endIndex-startIndex);
                    Console.WriteLine(key);
                }
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
