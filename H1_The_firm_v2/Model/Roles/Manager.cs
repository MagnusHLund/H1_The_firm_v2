using H1_The_firm_v2.Model.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_firm_v2.Model.Roles
{
    /// <summary>
    /// The Manager class is the middle man between Executive and Employee.
    /// Managers are allowed to have company vehicles, which is the only difference between Manager and Employee. 
    /// The ToString() override has been updated to fit the new vehicle add-on.
    /// </summary>
    internal class Manager : Employee
    {
        private protected CompanyVehicle _vehicle;

        internal Manager(string name, string position, ushort salary, string email, int phoneNumber, CompanyVehicle vehicle) : base(name, position, salary, email, phoneNumber)
        {
            _vehicle = vehicle;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Company Vehicle: {_vehicle.Model}\n";
        }
    }
}
