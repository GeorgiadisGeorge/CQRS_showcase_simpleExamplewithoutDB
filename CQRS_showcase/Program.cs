﻿using CQRS_showcase.Models;

namespace CQRS_showcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Candidate> candidates = new List<Candidate>();
            var addCommand = new AddCandidateCommand(candidates);
            addCommand.Execute(new Candidate { Name = "John", Age = 25, Experience = "3 years" });
            addCommand.Execute(new Candidate { Name = "George", Age = 88, Experience = "80 years" });
            addCommand.Execute(new Candidate { Name = "Bruce", Age = 15, Experience = "5 years" });


            var getQuery = new GetCandidatesQuery(candidates);
            List<Candidate> candidateList = getQuery.Execute();

            foreach (var candidate in candidateList)
            {
                Console.WriteLine($"Name: {candidate.Name}, Age: {candidate.Age}, Experience: {candidate.Experience}");
            }
            
        }
    }
}