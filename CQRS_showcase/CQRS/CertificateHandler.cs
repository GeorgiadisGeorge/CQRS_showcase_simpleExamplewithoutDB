using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS
{
    public class CertificateHandler
    {
        private readonly List<Certificate> _certificates;

        public CertificateHandler(List<Certificate> certificates)
        {
            _certificates = certificates;
        }

        public void Handle(AddCertificateCommand command)
        {
            var certificates = new[]
            {
            new Certificate { Name = "C# Foundation", Description = "Certification for developing basic knowledge of dot net framework" },
            new Certificate { Name = "C# Advanced", Description = "Certification for developing advanced knowledge of dot net framework" },
            new Certificate { Name = "English B1", Description = "Certification for advanced English Language" }
        };

            foreach (var certificate in certificates)
            {
                command.Execute(certificate);
            }
        }

        public List<Certificate> Handle(GetCertificatesQuery query)
        {
            return query.Execute();
        }
    }

}
