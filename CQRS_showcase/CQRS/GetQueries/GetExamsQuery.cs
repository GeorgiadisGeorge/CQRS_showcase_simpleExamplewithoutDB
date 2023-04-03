using CQRS_showcase.Interfaces;
using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS.GetQueries
{
    // Define a public class named GetExamsQuery that implements the IQuery<List<Exam>> interface
    public class GetExamsQuery : IQuery<List<Exam>>
    {
        // Define a private, readonly field named _exams that holds a list of Exam objects
        private readonly List<Exam> _exams;

        // Define a constructor for the GetExamsQuery class that takes a list of Exam objects as a parameter
        public GetExamsQuery(List<Exam> exams)
        {
            // Initialize the _exams field with the list of exams passed in as a parameter
            _exams = exams;
        }

        // Define a method named Execute that returns a list of Exam objects
        public List<Exam> Execute()
        {
            // Return the _exams field, which holds the list of exams
            return _exams;
        }
    }

}
