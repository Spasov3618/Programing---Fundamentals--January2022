using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Project
    {
        public Project(string projectName, string teemName)
        {
            ProjectName = projectName;
            TeamName = teemName;
            Members = new List<string>();
        }

        public string ProjectName { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int numTeem = int.Parse(Console.ReadLine());
            List<Project> projegt = new List<Project>();
            for (int i = 0; i < numTeem; i++)
            {
                string[] input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string projectName = input[0];
                string teemName = input[1];
                if (projegt.Any(x => x.ProjectName == projectName))
                {
                    Console.WriteLine($"{projectName} cannot create another team!");
                    continue;
                }
                if (projegt.Any(x => x.TeamName == teemName))
                {
                    Console.WriteLine($"Team {teemName} was already created!");
                    continue;
                }
                Project newProject = new Project(projectName, teemName);
                projegt.Add(newProject);
                Console.WriteLine($"Team {teemName} has been created by {projectName}!");
            }
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string members = arguments[0];
                string team = arguments[1];
                Project searchTeam = projegt.FirstOrDefault(x => x.TeamName == team);
                if (searchTeam == null)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }
                if (projegt.Any(t => t.ProjectName == members))
                {
                    //Creator of a team cannot be a member of another team
                    Console.WriteLine($"Member {members} cannot join team {team}!");
                    continue;
                }
                if (IsAlreadyMemberOfTeam(projegt, members))
                {
                    Console.WriteLine($"Member {members} cannot join team {team}!");
                    continue;
                }


            searchTeam.Members.Add(members);
            
            }
                List<Project> teamsWithMembers = projegt
               .Where(t => t.Members.Count > 0)
               .OrderByDescending(t => t.Members.Count)
               .ThenBy(t => t.TeamName)
               .ToList();
                List<Project> teamsToDisband = projegt
                    .Where(t => t.Members.Count == 0)
                    .OrderBy(t => t.TeamName)
                    .ToList();

                PrintValidTeams(teamsWithMembers);
                PrintInvalidTeams(teamsToDisband);

        }
            static void PrintValidTeams(List<Project> validTeams)
            {
                foreach (Project validTeam in validTeams)
                {
                    Console.WriteLine($"{validTeam.TeamName}");
                    Console.WriteLine($"- {validTeam.ProjectName}");

                    foreach (string currMember in validTeam.Members.OrderBy(m => m))
                    {
                        Console.WriteLine($"-- {currMember}");
                    }
                }
            }
            static void PrintInvalidTeams(List<Project> invalidTeams)
            {
                Console.WriteLine("Teams to disband:");
                foreach (Project invalidTeam in invalidTeams)
                {
                    Console.WriteLine($"{invalidTeam.TeamName}");
                }
            }
        static bool IsAlreadyMemberOfTeam(List<Project> teams, string memberName)
        {
            foreach (Project team in teams)
            {
                if (team.Members.Contains(memberName))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
