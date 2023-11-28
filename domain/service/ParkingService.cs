using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto.domain.model;

namespace projeto.domain.service
{
    public interface ParkingService
    {
        public string addVehicle();
        public string removeVehicle();
        public List<Parking> listVehicle();
    }
}