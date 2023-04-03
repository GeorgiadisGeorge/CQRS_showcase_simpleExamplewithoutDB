using CQRS_showcase.Interfaces;
using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS.GetQueries
{
    // Define a public class named GetCandidatesQuery that implements the IQuery<List<Candidate>> interface
    public class GetCandidatesQuery : IQuery<List<Candidate>>
    {
        // Define a private, readonly field named _candidates that holds a list of Candidate objects
        private readonly List<Candidate> _candidates;

        // Define a constructor for the GetCandidatesQuery class that takes a list of Candidate objects as a parameter
        public GetCandidatesQuery(List<Candidate> candidates)
        {
            // Initialize the _candidates field with the list of candidates passed in as a parameter
            _candidates = candidates;
        }

        // Define a method named Execute that returns a list of Candidate objects
        public List<Candidate> Execute()
        {
            // Return the _candidates field, which holds the list of candidates
            return _candidates;
        }
    }

}
