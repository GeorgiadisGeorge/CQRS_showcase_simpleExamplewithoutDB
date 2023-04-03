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
    public class CertificateHandler
    {
        // Private field to hold certificates list
        private readonly List<Certificate> _certificates;

        // Constructor to initialize certificates field
        public CertificateHandler(List<Certificate> certificates)
        {
            _certificates = certificates;
        }

        // Method to handle AddCertificateCommand
        public void Handle(AddCertificateCommand command)
        {
            // Create an array of certificates
            var certificates = new[]
            {
            new Certificate { Name = "C# Foundation", Description = "Certification for developing basic knowledge of dot net framework" },
            new Certificate { Name = "C# Advanced", Description = "Certification for developing advanced knowledge of dot net framework" },
            new Certificate { Name = "English B1", Description = "Certification for advanced English Language" }
        };

            // Loop through the certificates and execute the AddCertificateCommand for each certificate
            foreach (var certificate in certificates)
            {
                command.Execute(certificate);
            }
        }

        // Method to handle GetCertificatesQuery
        public List<Certificate> Handle(GetCertificatesQuery query)
        {
            // Execute the GetCertificatesQuery and return the result
            return query.Execute();
        }
    }


}
