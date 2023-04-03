using CQRS_showcase.Interfaces;
using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS.AddCommands
{
    public class AddCandidateCommand : ICommand<Candidate>
    {
        private readonly List<Candidate> _candidates;

        public AddCandidateCommand(List<Candidate> candidates)
        {
            _candidates = candidates;
        }

        public void Execute(Candidate candidate)
        {
            _candidates.Add(candidate);
        }
    }
}
