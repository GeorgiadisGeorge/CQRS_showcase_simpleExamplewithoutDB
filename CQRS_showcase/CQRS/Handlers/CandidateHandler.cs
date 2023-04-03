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
    public class CandidateHandler
    {
        private readonly List<Candidate> _candidates;

        public CandidateHandler(List<Candidate> candidates)
        {
            _candidates = candidates;
        }

        public void Handle(AddCandidateCommand command)
        {
            var candidates = new[]
            {
                new Candidate { Name = "John Doe", Age = 30, Experience = "5 years" },
                new Candidate { Name = "George Georgiou", Age = 90, Experience = "50 years" },
                new Candidate { Name = "Ann Cate", Age = 15, Experience = "10 years" },
                new Candidate { Name = "Bruce Lee", Age = 150, Experience = "100 years" }
            };

            foreach (var candidate in candidates)
            {
                command.Execute(candidate);
            }
        }


        public List<Candidate> Handle(GetCandidatesQuery query)
        {
            return query.Execute();
        }
    }

}
