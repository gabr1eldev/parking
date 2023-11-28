using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.domain.repository
{
    public interface ParkingRepository
    {
        public List<string> vehicles();
    }
}