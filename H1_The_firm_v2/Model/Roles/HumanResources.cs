using H1_The_firm_v2.Model.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_firm_v2.Model.Roles
{
    /// <summary>
    /// This class inherits from Employee. 
    /// The only difference between an employee and HumanResources is the specialization field.
    /// This field is the specialized branch that the employed HR person has. 
    /// Again theres is an override of ToString() which allows the data to exit this class.
    /// </summary>
    internal class HumanResources : Employee
    {
        private protected string _specialization;

        internal HumanResources(string name, string position, ushort salary, string email, int phoneNumber, string specialization) : base(name, position, salary, email, phoneNumber)
        {
            _specialization = specialization;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Specialization: {_specialization}\n";
        }
    }
}
