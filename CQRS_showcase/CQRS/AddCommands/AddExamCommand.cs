using CQRS_showcase.Interfaces;
using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS.AddCommands
{
    // Define a public class named AddExamCommand that implements the ICommand<Exam> interface
    public class AddExamCommand : ICommand<Exam>
    {
        // Define a private, readonly field named _exams that holds a list of Exam objects
        private readonly List<Exam> _exams;

        // Define a constructor for the AddExamCommand class that takes a list of Exam objects as a parameter
        public AddExamCommand(List<Exam> exams)
        {
            // Initialize the _exams field with the list of exams passed in as a parameter
            _exams = exams;
        }

        // Define a method named Execute that takes an Exam object as a parameter and returns nothing
        public void Execute(Exam exam)
        {
            // Add the Exam object passed in as a parameter to the _exams list
            _exams.Add(exam);
        }
    }

}
