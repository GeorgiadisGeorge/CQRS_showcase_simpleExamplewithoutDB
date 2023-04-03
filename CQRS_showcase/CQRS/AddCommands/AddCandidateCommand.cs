using CQRS_showcase.Interfaces;
using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS.AddCommands
{
    // Define a public class named AddCandidateCommand that implements the ICommand<Candidate> interface
    public class AddCandidateCommand : ICommand<Candidate>
    {
        // Define a private, readonly field named _candidates that holds a list of Candidate objects
        private readonly List<Candidate> _candidates;

        // Define a constructor for the AddCandidateCommand class that takes a list of Candidate objects as a parameter
        public AddCandidateCommand(List<Candidate> candidates)
        {
            // Initialize the _candidates field with the list of candidates passed in as a parameter
            _candidates = candidates;
        }

        // Define a method named Execute that takes a Candidate object as a parameter and returns nothing
        public void Execute(Candidate candidate)
        {
            // Add the Candidate object passed in as a parameter to the _candidates list
            _candidates.Add(candidate);
        }
    }

}
