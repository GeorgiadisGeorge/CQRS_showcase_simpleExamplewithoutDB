using CQRS_showcase.Interfaces;
using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS.GetQueries
{
    public class GetCandidatesQuery : IQuery<List<Candidate>>
    {
        private readonly List<Candidate> _candidates;

        public GetCandidatesQuery(List<Candidate> candidates)
        {
            _candidates = candidates;
        }

        public List<Candidate> Execute()
        {
            return _candidates;
        }
    }
}
