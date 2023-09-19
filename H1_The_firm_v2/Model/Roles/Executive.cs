using H1_The_firm_v2.Model.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_firm_v2.Model.Roles
{
    /// <summary>
    /// The Executive class inherits from the Manager class.
    /// The only difference between Executive and Manager is that executives get extra vacation days.
    /// Once again there is an override of ToString() which allows easy retrival of the values that Executive has.
    /// </summary>
    internal class Executive : Manager
    {
        private protected byte _additionalVacationDays;

        internal Executive(string name, string position, ushort salary, string email, int phoneNumber, CompanyVehicle vehicle, byte additionalVacationDays) : base(name, position, salary, email, phoneNumber, vehicle)
        {
            _additionalVacationDays = additionalVacationDays;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Additional vacation days: {_additionalVacationDays}\n";
        }
    }
}
