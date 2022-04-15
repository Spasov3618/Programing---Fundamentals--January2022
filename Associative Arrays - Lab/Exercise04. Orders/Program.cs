using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Създайте програма, която съхранява информацията за продуктите и техните цени.Всеки продукт има име, цена и количество. Ако продуктът все още не съществува, добавете го с началното му количество.
            //Ако получите продукт, който вече съществува, увеличава количеството му с вложеното количество и ако цената му е различна, заменете и цената.
            //Ще получавате имената на продуктите, цените и количествата на нови редове. Докато не получите командата "купува", продължете да добавяте артикули. Когато получите командата „купете“, отпечатайте артикулите с техните имена и общата цена на всички продукти с това име.
            //Вход
            //• Докато не получите „купете“, продуктите ще идват във формат: „{ име} { цена} { количество}“.
            //• Данните за продукта винаги са разделени с един интервал.
            //Изход
            //• Отпечатайте информация за всеки продукт в следния формат:
            //„{ productName} -> { totalPrice}“
            //• Форматирайте средната оценка до 2 - ра цифра след десетичния разделител.
            Dictionary<string,double[]> product = new Dictionary<string,double[]>();
            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] parts = input.Split();
                string name = parts[0];
                double price = double.Parse(parts[1]);
                double quantity = double.Parse(parts[2]);
                if (!product.ContainsKey(name))
                {
                    product.Add(name, new double[2]);
                }
                product[name][0] = price;
                product[name][1] += quantity;
            }
            foreach (var item in product)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):F2}");
            }
        }
    }
}
