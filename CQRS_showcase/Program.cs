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

            // Define an empty list of Candidate objects
            List<Candidate> candidates = new List<Candidate>();

            // Create a CandidateHandler object and pass the list of candidates to it
            CandidateHandler handler = new CandidateHandler(candidates);

            // Add a new candidate to the list of candidates using an AddCandidateCommand object
            handler.Handle(new AddCandidateCommand(candidates));

            // Get all the candidates from the list of candidates using a GetCandidatesQuery object
            List<Candidate> allCandidates = handler.Handle(new GetCandidatesQuery(candidates));

            // Print out the heading for the list of candidates
            Console.WriteLine("Candidates");
            Console.WriteLine("-----------------------------------------------");

            // Loop through each candidate in the list of candidates and print out their name, age, and experience
            foreach (Candidate candidate in allCandidates)
            {
                Console.WriteLine($"Name = {candidate.Name}, Age = {candidate.Age}, Experience = {candidate.Experience}");
            }

            Console.WriteLine("-----------------------------------------------");


            Console.WriteLine("Certificates");
            Console.WriteLine("-----------------------------------------------");

            // Define an empty list of Certificate objects
            var certificates = new List<Certificate>();

            // Create a CertificateHandler object and pass the list of certificates to it
            var certificateHandler = new CertificateHandler(certificates);

            // Add a new certificate to the list of certificates using an AddCertificateCommand object
            certificateHandler.Handle(new AddCertificateCommand(certificates));

            // Get all the certificates from the list of certificates using a GetCertificatesQuery object
            var query = new GetCertificatesQuery(certificates);
            var retrievedCertificates = certificateHandler.Handle(query);

            // Loop through each certificate in the list of certificates and print out its name and description
            foreach (var certificate in retrievedCertificates)
            {
                Console.WriteLine($"Certificate Name: {certificate.Name}, Description: {certificate.Description}");
            }
            Console.WriteLine("-----------------------------------------------");

            // Define an empty list of Exam objects
            var exams = new List<Exam>();
            // Create an ExamHandler object and pass the list of exams to it
            var examHandler = new ExamHandler(exams);
            // Add a new exam to the list of exams using an AddExamCommand object
            examHandler.Handle(new AddExamCommand(exams));

            // Get all the exams from the list of exams using a GetExamsQuery object
            var examquery = new GetExamsQuery(exams);
            var retrievedExams = examHandler.Handle(examquery);

            Console.WriteLine("Exams");
            Console.WriteLine("-----------------------------------------------");

            // Loop through each exam in the list of exams and print out its name, date, and duration
            foreach (var exam in exams)
            {
                Console.WriteLine($"Name: {exam.Name}, Date: {exam.Date.ToShortDateString()}, Duration: {exam.DurationMinutes} minutes");
            }


        }
    }
}