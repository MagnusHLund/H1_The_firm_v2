using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_firm_v2.Model.Roles
{
    /// <summary>
    /// Creates a base class which have the basic variables for an employee at this company.
    /// It also has an override ToString() method which allows easy retrieval of data from this class.
    /// </summary>
    internal class Employee
    {
        private protected string _name;
        private protected string _position;
        private protected ushort _salary;
        private protected string _email;
        private protected int _phone;

        internal Employee(string name, string position, ushort salary, string email, int phone)
        {
            _name = name;
            _position = position;
            _salary = salary;
            _email = email;
            _phone = phone;
        }

        public override string ToString()
        {
            return $"\n{_position}:\n" +
                $"Name: {_name}\n" +
                $"Salary: {_salary} dkk per month\n" +
                $"Email: {_email}\n" +
                $"phone: {_phone}\n";
        }
    }
}
