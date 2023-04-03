using CQRS_showcase.Interfaces;
using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS.AddCommands
{
    // Define a public class named AddCertificateCommand that implements the ICommand<Certificate> interface
    public class AddCertificateCommand : ICommand<Certificate>
    {
        // Define a private, readonly field named _certificates that holds a list of Certificate objects
        private readonly List<Certificate> _certificates;

        // Define a constructor for the AddCertificateCommand class that takes a list of Certificate objects as a parameter
        public AddCertificateCommand(List<Certificate> certificates)
        {
            // Initialize the _certificates field with the list of certificates passed in as a parameter
            _certificates = certificates;
        }

        // Define a method named Execute that takes a Certificate object as a parameter and returns nothing
        public void Execute(Certificate certificate)
        {
            // Add the Certificate object passed in as a parameter to the _certificates list
            _certificates.Add(certificate);
        }
    }


}
