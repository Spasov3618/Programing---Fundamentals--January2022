using System;

namespace _03._Gaming_Store__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                double budjet = double.Parse(Console.ReadLine());
                string nameOfGame = Console.ReadLine();
                double money = 0;
                while (nameOfGame != "Game Time")
                {
                    if (nameOfGame == "OutFall 4")
                    {
                        if (budjet < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            budjet -= 39.99;
                            money += 39.99;
                            Console.WriteLine($"Bought {nameOfGame}");
                        }
                    }
                    else if (nameOfGame == "CS: OG")
                    {
                        if (budjet < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            budjet -= 15.99;
                            money += 15.99;
                            Console.WriteLine($"Bought {nameOfGame}");
                        }
                    }
                    else if (nameOfGame == "Zplinter Zell")
                    {
                        if (budjet < 19.99)
                        {
                            Console.WriteLine("Too Expensive");

                        }
                        else
                        {
                            budjet -= 19.99;
                            money += 19.99;
                            Console.WriteLine($"Bought {nameOfGame}");
                        }
                    }
                    else if (nameOfGame == "Honored 2")
                    {
                        if (budjet < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            budjet -= 59.99;
                            money += 59.99;
                            Console.WriteLine($"Bought {nameOfGame}");
                        }
                    }
                    else if (nameOfGame == "RoverWatch")
                    {
                        if (budjet < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            budjet -= 29.99;
                            money += 29.99;
                            Console.WriteLine($"Bought {nameOfGame}");
                        }
                    }
                    else if (nameOfGame == "RoverWatch Origins Edition")
                    {
                        if (budjet < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            budjet -= 39.99;
                            money += 39.99;
                            Console.WriteLine($"Bought {nameOfGame}");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Not Found");

                    }

                    nameOfGame = Console.ReadLine();
                    if (budjet == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                if (nameOfGame == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${money:f2}. Remaining: ${budjet:f2}");
                }
            }
        }
    }

