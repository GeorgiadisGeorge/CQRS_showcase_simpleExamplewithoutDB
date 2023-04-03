using CQRS_showcase.Interfaces;
using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS.AddCommands
{
    public class AddCertificateCommand : ICommand<Certificate>
    {
        private readonly List<Certificate> _certificates;

        public AddCertificateCommand(List<Certificate> certificates)
        {
            _certificates = certificates;
        }

        public void Execute(Certificate certificate)
        {
            _certificates.Add(certificate);
        }
    }

}
