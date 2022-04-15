using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Идва финалната и най-интересна част – Окончателното класиране на кандидат-стажантите.Окончателното класиране се определя от точките от задачите на интервюто и от изпитите в СофтУни. Ето последната ви задача. Ще получите някои въведени реда във формат "{contest}:{password for contest}", докато не получите "end of contests".Запазете тези данни, защото ще ви трябват по-късно.След това ще получавате друг тип входове във формат „{ contest}=>{ password}=>{ username}=>{ points}“, докато не получите „край на подаванията“. Ето какво трябва да направите.
            //• Проверете дали конкурсът е валиден(ако сте го получили при първия тип въвеждане)
            //• Проверете дали паролата е правилна за даденото състезание
            //• Запазете потребителя със състезанието, в което участва(потребител може да участва в много състезания) и точките, които потребителят има в даденото състезание.Ако получите същия конкурс и същият потребител актуализира точките само ако новите са повече от по-старите.
            //В крайна сметка трябва да отпечатате информацията за потребителя с най - много точки във формат „Най - добрият кандидат е { user}
            //            с общо { общо точки}
            //            точки.“. След това отпечатайте всички ученици, подредени по техните имена. За всеки потребител отпечатайте всяко състезание с точките в низходящ ред.Вижте примерите.
            //Вход
            //• Низове във формат „{ contest}:{ password for contest}“ до командата „end of contests“. Няма да има случай с две равни състезания
            //• Низове във формат "{contest}=>{password}=>{username}=>{points}" до командата "end of submissions".
            //• Няма да има случай с 2 ​​или повече потребители с еднакъв общ брой точки!
            //Изход
            //• На първия ред отпечатайте най - добрия потребител във формат „Най - добрият кандидат е { user}
            //            с общо { общо точки}
            //            точки.“.
            //• След това отпечатайте всички ученици, подредени, както е посочено по-горе във формат:
            //„{ user1 name}“
            //„# {contest1} -> {points}“
            //„# {contest2} -> {points}“
            //Ограничения
            //• низовете могат да съдържат всякакви ASCII символи, освен от(:, =, >)
            //• числата ще бъдат в диапазона[0 - 10000]
            //• вторият вход е винаги валиден
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> ranking = new Dictionary<string, Dictionary<string, int>>();
            string contes;
            while ((contes = Console.ReadLine()) != "end of contests")
            {
                string[] inputContest = contes.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string nameContest = inputContest[0];
                string passwordContest = inputContest[1];

                contests.Add(nameContest, passwordContest);

            }
            string arg;
            while ((arg = Console.ReadLine()) != "end of submissions")
            {
                string[] input = arg.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string nameContest = input[0];
                string passwordContest = input[1];
                string nameStudent = input[2];
                int points = int.Parse(input[3]);
                if (contests.ContainsKey(nameContest) && contests[nameContest] == passwordContest)
                {
                    if (!ranking.ContainsKey(nameStudent))
                    {
                        ranking.Add(nameStudent, new Dictionary<string, int>());

                    }
                        if (!ranking[nameStudent].ContainsKey(nameContest))
                        {
                            ranking[nameStudent].Add(nameContest, 0);
                        }

                        if (ranking[nameStudent][nameContest] < points)
                        {
                            ranking[nameStudent][nameContest] = points;
                        }
                    
                }

            }
            PrintBestCandidate(ranking);

            PrintAllStudents(ranking);
        }
        private static void PrintAllStudents(Dictionary<string, Dictionary<string, int>> ranking)
        {
            Console.WriteLine("Ranking: ");

            foreach (var student in ranking.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{student.Key}");

                foreach (var kvp in student.Value.OrderByDescending(kvp => kvp.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }

        private static void PrintBestCandidate(Dictionary<string, Dictionary<string, int>> ranking)
        {
            foreach (var user in ranking.OrderByDescending(kvp => kvp.Value.Values.Sum()))
            {
                Console.WriteLine($"Best candidate is {user.Key} with total {user.Value.Values.Sum()} points.");
                return;
            }
        }
    }
}
