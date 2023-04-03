using CQRS_showcase.Interfaces;
using CQRS_showcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.CQRS.GetQueries
{
    public class GetCertificatesQuery : IQuery<List<Certificate>>
    {
        private readonly List<Certificate> _certificates;

        public GetCertificatesQuery(List<Certificate> certificates)
        {
            _certificates = certificates;
        }

        public List<Certificate> Execute()
        {
            return _certificates;
        }
    }

}
