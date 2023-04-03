using CQRS_showcase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.Models
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
