using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.domain.exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string msg ) : base(msg) 
        {
            
        }
    }
}