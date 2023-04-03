using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.Models
{
    public class Exam
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int DurationMinutes { get; set; }
    }
}
