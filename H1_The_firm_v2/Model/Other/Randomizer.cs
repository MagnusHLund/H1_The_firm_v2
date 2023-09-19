using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_firm_v2.Model.Other
{
    internal class Randomizer
    {
        /// <summary>
        /// This string array is used to generate first names for the workers in the company
        /// </summary>
        internal string[] firstNames = {
            "Emma",
            "Liam",
            "Olivia",
            "Noah",
            "Ava",
            "Oliver",
            "Mikkel",
            "Shazil",
            "Lucas",
            "Yordan",
            "Magnus",
            "Kris",
            "Camilla",
            "Benjamin",
            "Daniel",
            "Rasmus",
            "Andrew",
            "Rune",
            "Jonas",
            "William",
            "Samuel"
        };

        /// <summary>
        /// The lastNames string array is used to generate last names, for the workers in the company
        /// </summary>
        internal string[] lastNames = {
            "Jensen",
            "Nielsen",
            "Hansen",
            "Pedersen",
            "Petersen",
            "Lund",
            "Andersen",
            "Krøll",
            "Kristensen",
            "Ryskjær",
            "Knudsen",
            "Rasmussen",
            "Larsen",
            "Poulsen",
            "Jørgensen"
        };

        /// <summary>
        /// Specializations string array is used to give a HR person a specialization.
        /// </summary>
        internal string[] specializations =
        {
            "Talent Acquisition Specialist",
            "Employee Relations Specialist",
            "Compensation and Benefits Analyst",
            "HR Generalist",
            "Training and Development Specialist",
            "HR Information Systems Specialist",
            "Diversity, Equity, and Inclusion Specialist",
            "Labor Relations Specialist",
            "HR Compliance Officer",
            "Organizational Development Specialist",
            "Health and Wellness Coordinator",
            "Global HR Specialist",
            "Workforce Planning Specialist",
            "HR Consultant",
            "HR Analytics Specialist",
            "Benefits Communication Specialist"
        };

        /// <summary>
        /// Roles for normal employees
        /// </summary>
        internal string[] roles =
        {
            "Network administrator",
            "Software developer",
            "IT supporter",
            "Database administrator",
            "Cybersecurity analyst",
            "Web developer",
            "Marketing coordinator",
            "Digital marketing specialist",
            "Market research analyst",
            "Marketing communications specialist",
            "Public Relations Specialist",
            "Accountant",
            "Financial analyst",
            "Tax specialist",
            "Budget analyst",            
            "Sales representative",
            "Account executive",
            "Sales coordinator",
            "Sales Operations Manager",
            "Customer Success Manager"
        };
    }
}
