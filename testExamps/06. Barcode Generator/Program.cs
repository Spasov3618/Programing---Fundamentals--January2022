using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStart = int.Parse(Console.ReadLine());
            int numFinish = int.Parse(Console.ReadLine());

            int a1 = numStart % 10;
            int b1 = numFinish % 10;
            numStart /= 10;
            numFinish /= 10;
            int c1 = numStart % 10;
            int d1 = numFinish % 10;
            numStart /= 10;
            numFinish /= 10;
            int e1 = numStart % 10;
            int f1 = numFinish % 10;
            numStart /= 10;
            numFinish /= 10;
            for (int i = numStart ; i <=numFinish; i++)
            {
                for (int j = e1; j <=f1; j++)
                {
                    for (int k = c1; k <= d1; k++)
                    {
                        for (int l = a1; l <= b1; l++)
                        {
                            if (i%2 !=0 && j%2 !=0 && k%2 !=0 && l%2 !=0 )
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
