using CQRS_showcase.Interfaces;
using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS
{
    public class GetExamsQuery : IQuery<List<Exam>>
    {
        private readonly List<Exam> _exams;

        public GetExamsQuery(List<Exam> exams)
        {
            _exams = exams;
        }

        public List<Exam> Execute()
        {
            return _exams;
        }

    }
}
