using System;

namespace Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете поредица от низове от конзолата. Шифровайте всеки низ чрез сумиране:
            //• Кодът на всяка гласна, умножен по дължината на низа
            //• Кодът на всяка съгласна, разделен на дължината на низа
            //Сортирайте последователността от числа във възходящ ред и я отпечатайте на конзолата.
            //На първия ред винаги ще получавате броя низове, които трябва да прочетете.
            int input = int.Parse(Console.ReadLine());
            int[] rezult= new int[input];
            for (int i = 0; i < input; i++)
            {
                string name = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] == 'a'|| name[j]=='e' || name[j]=='i' || name[j]== 'o' || name [j] == 'u' || name[j]=='A'||name[j]=='E' ||name[j]=='I'|| name[j]=='O'|| name[j]=='U')
                    {

                    sum += name[j] * name.Length;
                    }
                    else
                    {
                    sum+= name[j]/name.Length;
                    }
                }
                    
                        rezult[i]= sum;
                    
            }
            Array.Sort(rezult);
            for (int l = 0; l < rezult.Length; l++)
            {
                Console.WriteLine(rezult[l]);
            }
           
        }
    }
}
