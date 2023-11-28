using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.domain.model
{
    public class Vehicles
    {
        private List<Object>? _vehicles;

        public Vehicles() {}

        public Vehicles(List<Object> vehicles) {
            this._vehicles = vehicles;
        }
    }
}