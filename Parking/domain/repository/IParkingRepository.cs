using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parking.domain.model;

namespace Parking.domain.repository
{
    public interface IParkingRepository 
    {
        public List<ParkingDIO>? GetVehicles();
        public void AddVehicle(ParkingDIO vehicle);
        public void RemoveVehicle(ParkingDIO parking);
    }
}