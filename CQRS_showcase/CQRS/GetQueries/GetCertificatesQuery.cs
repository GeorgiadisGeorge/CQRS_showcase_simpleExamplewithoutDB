using CQRS_showcase.Interfaces;
using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS.GetQueries
{
    // Define a public class named GetCertificatesQuery that implements the IQuery<List<Certificate>> interface
    public class GetCertificatesQuery : IQuery<List<Certificate>>
    {
        // Define a private, readonly field named _certificates that holds a list of Certificate objects
        private readonly List<Certificate> _certificates;

        // Define a constructor for the GetCertificatesQuery class that takes a list of Certificate objects as a parameter
        public GetCertificatesQuery(List<Certificate> certificates)
        {
            // Initialize the _certificates field with the list of certificates passed in as a parameter
            _certificates = certificates;
        }

        // Define a method named Execute that returns a list of Certificate objects
        public List<Certificate> Execute()
        {
            // Return the _certificates field, which holds the list of certificates
            return _certificates;
        }
    }


}
