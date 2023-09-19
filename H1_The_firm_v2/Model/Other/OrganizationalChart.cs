using H1_The_firm_v2.Model.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_firm_v2.Model.Other
{
    /// <summary>
    /// This class is just a model class that contains a list, of all workers in the company.
    /// Once an employee, CEO, HR, etc gets created, it will be placed inside this list of employees.
    /// At the end of the program, the output will be provided based on the workers inside this list.
    /// </summary>
    internal class OrganizationalChart
    {
        internal List<Employee> workers = new();
    }
}
