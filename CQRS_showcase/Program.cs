using CQRS_showcase.CQRS;
using CQRS_showcase.CQRS.AddCommands;
using CQRS_showcase.CQRS.GetQueries;
using CQRS_showcase.CQRS.Handlers;
using CQRS_showcase.Models;

namespace CQRS_showcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // create a list of candidates
            List<Candidate> candidates = new List<Candidate>();

            // create a handler for the candidates
            CandidateHandler handler = new CandidateHandler(candidates);

            // add some candidates
            handler.Handle(new AddCandidateCommand(candidates));

            // get all candidates and console write their names
            List<Candidate> allCandidates = handler.Handle(new GetCandidatesQuery(candidates));


            Console.WriteLine("Candidates");
            Console.WriteLine("-----------------------------------------------");
            foreach (Candidate candidate in allCandidates)
            {
                Console.WriteLine($"Name = {candidate.Name}, Age = {candidate.Age}, Experience = {candidate.Experience}");
            }

            Console.WriteLine("-----------------------------------------------");


            Console.WriteLine("Certificates");
            Console.WriteLine("-----------------------------------------------");
            // create a list of certificates and add some certificates
            var certificates = new List<Certificate>();
            var certificateHandler = new CertificateHandler(certificates);
            certificateHandler.Handle(new AddCertificateCommand(certificates));

            // retrieve the list of certificates and print each one to the console
            var query = new GetCertificatesQuery(certificates);
            var retrievedCertificates = certificateHandler.Handle(query);

            
            foreach (var certificate in retrievedCertificates)
            {
                Console.WriteLine($"Certificate Name: {certificate.Name}, Description: {certificate.Description}");
            }
            Console.WriteLine("-----------------------------------------------");


            var exams = new List<Exam>(); // Assuming you have initialized and added exams to this list.
            var examHandler = new ExamHandler(exams);
            examHandler.Handle(new AddExamCommand(exams));

            var examquery = new GetExamsQuery(exams);
            var retrievedExams = examHandler.Handle(examquery);

            Console.WriteLine("Exams");
            Console.WriteLine("-----------------------------------------------");
            foreach (var exam in exams)
            {
                Console.WriteLine($"Name: {exam.Name}, Date: {exam.Date.ToShortDateString()}, Duration: {exam.DurationMinutes} minutes");
            }


        }
    }
}