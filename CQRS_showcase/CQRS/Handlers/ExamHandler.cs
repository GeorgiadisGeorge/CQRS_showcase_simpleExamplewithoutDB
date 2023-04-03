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
    public class ExamHandler
    {
        // Field to hold a list of exams
        private readonly List<Exam> _exams;

        // Constructor to initialize the field
        public ExamHandler(List<Exam> exams)
        {
            _exams = exams;
        }

        // Method to add exams to the list using an AddExamCommand object
        public void Handle(AddExamCommand command)
        {
            // Create an array of exam objects
            var exams = new[]
            {
            new Exam { Name = "Mathematics Exam", Date = new DateTime(2023, 4, 10), DurationMinutes = 120 },
            new Exam { Name = "Science Exam", Date = new DateTime(2023, 4, 15), DurationMinutes = 90 },
            new Exam { Name = "English Exam", Date = new DateTime(2023, 4, 20), DurationMinutes = 60 },
            new Exam { Name = "History Exam", Date = new DateTime(2023, 4, 25), DurationMinutes = 120 }
        };

            // Loop through the exams and execute the AddExamCommand with each exam object
            foreach (var exam in exams)
            {
                command.Execute(exam);
            }
        }

        // Method to retrieve a list of exams using a GetExamsQuery object
        public List<Exam> Handle(GetExamsQuery query)
        {
            return query.Execute();
        }
    }

}
