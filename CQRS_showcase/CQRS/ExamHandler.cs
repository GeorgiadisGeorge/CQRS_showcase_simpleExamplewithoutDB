using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS
{
    public class ExamHandler
    {
        private readonly List<Exam> _exams;

        public ExamHandler(List<Exam> exams)
        {
            _exams = exams;
        }

        public void Handle(AddExamCommand command)
        {
            var exams = new[]
            {
                new Exam { Name = "Mathematics Exam", Date = new DateTime(2023, 4, 10), DurationMinutes = 120 },
                new Exam { Name = "Science Exam", Date = new DateTime(2023, 4, 15), DurationMinutes = 90 },
                new Exam { Name = "English Exam", Date = new DateTime(2023, 4, 20), DurationMinutes = 60 },
                new Exam { Name = "History Exam", Date = new DateTime(2023, 4, 25), DurationMinutes = 120 }
            };

            foreach (var exam in exams)
            {
                command.Execute(exam);
            }
        }

        public List<Exam> Handle(GetExamsQuery query)
        {
            return query.Execute();
        }

    }
}
