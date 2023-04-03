using CQRS_showcase.CQRS;
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

            foreach (Candidate candidate in allCandidates)
            {
                Console.WriteLine($"Name = {candidate.Name}, Age = {candidate.Age}, Experience = {candidate.Experience}");
            }

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


        }
    }
}