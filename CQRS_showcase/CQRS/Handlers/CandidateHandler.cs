using CQRS_showcase.CQRS.AddCommands;
using CQRS_showcase.CQRS.GetQueries;
using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS.Handlers
{
    // Define a public class named CandidateHandler
    public class CandidateHandler
    {
        // Define a private, readonly field named _candidates that holds a list of Candidate objects
        private readonly List<Candidate> _candidates;

        // Define a constructor for the CandidateHandler class that takes a list of Candidate objects as a parameter
        public CandidateHandler(List<Candidate> candidates)
        {
            // Initialize the _candidates field with the list of candidates passed in as a parameter
            _candidates = candidates;
        }

        // Define a method named Handle that takes an AddCandidateCommand object as a parameter and returns nothing
        public void Handle(AddCandidateCommand command)
        {
            // Define an array of four Candidate objects
            var candidates = new[]
            {
            new Candidate { Name = "John Doe", Age = 30, Experience = "5 years" },
            new Candidate { Name = "George Georgiou", Age = 90, Experience = "50 years" },
            new Candidate { Name = "Ann Cate", Age = 15, Experience = "10 years" },
            new Candidate { Name = "Bruce Lee", Age = 150, Experience = "100 years" }
        };

            // Iterate through each Candidate object in the candidates array
            foreach (var candidate in candidates)
            {
                // Execute the AddCandidateCommand on the CandidateHandler's _candidates list, passing in the current Candidate object as a parameter
                command.Execute(candidate);
            }
        }

        // Define a method named Handle that takes a GetCandidatesQuery object as a parameter and returns a list of Candidate objects
        public List<Candidate> Handle(GetCandidatesQuery query)
        {
            // Execute the GetCandidatesQuery on the CandidateHandler's _candidates list and return the result
            return query.Execute();
        }
    }


}
