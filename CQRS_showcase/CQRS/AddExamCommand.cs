using CQRS_showcase.Interfaces;
using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS
{
    public class AddExamCommand : ICommand<Exam>
    {
        private readonly List<Exam> _exams;

        public AddExamCommand(List<Exam> exams)
        {
            _exams = exams;
        }

        public void Execute(Exam exam)
        {
            _exams.Add(exam);
        }

    }
}
