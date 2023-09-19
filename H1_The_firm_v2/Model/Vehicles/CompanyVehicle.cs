using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_firm_v2.Model.Other
{
    /// <summary>
    /// This class contains a bunch of properties, which define a vehicle.
    /// </summary>
    internal class CompanyVehicle
    {
        private string _vehicleModel;
        private float _distanceDriven;
        private string _licensePlate;
        private string _color;
        private bool _inUse;

        internal string Model
        {
            get { return _vehicleModel; }
            set { _vehicleModel = value; }
        }

        internal float DistanceDriven
        {
            get { return _distanceDriven; }
            set { _distanceDriven = value; }
        }

        internal string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        internal string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        internal bool InUse
        {
            get { return _inUse; }
            set { _inUse = value; }
        }
    }
}
