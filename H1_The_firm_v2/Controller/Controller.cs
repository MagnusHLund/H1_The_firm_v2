using H1_The_firm_v2.Model.Other;
using H1_The_firm_v2.Model.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace H1_The_firm_v2.Controller
{
    internal class Controller
    {
        private Random random = new Random();
        private Randomizer randomizer = new Randomizer();
        private OrganizationalChart employees = new();
        private View.View view = new();
        
        /// <summary>
        /// This is the entry point for the controller class.
        /// It is responsible for creating different kinds of employee types, which represents a company.
        /// Once all the employee types have been created, it runs the Output method, which outputs all the created employees.
        /// </summary>
        internal void Start()
        {
            CreateExecutive();
            CreateManager();
            CreateHR();
            CreateEmployee();

            Output();
        }

        /// <summary>
        /// This method creates each executive in the company.
        /// It provides values for values for name, position, salary, email, phone number, additional vacation days and a vehicle.
        /// The vehicle can be any of 10 types, which are predefined in the VehicleList class.
        /// </summary>
        private void CreateExecutive()
        {
            string position = "";
            ushort salary;

            // For loop runs 5 times because there is 5 executives in this company.
            for(int i = 0; i < 5; i++)
            {
                // Generates a name, using a method within this class.
                string name = NameGenerator();

                // Gives the correct job position, based on the value of the 'i' variable.
                if (i == 0)
                {
                    position = "CEO";
                }
                else if (i == 1)
                {
                    position = "CFO";
                }
                else if (i == 2)
                {
                    position = "COO";
                }
                else if (i == 3)
                {
                    position = "CMO";
                } 
                else if (i == 4)
                {
                    position = "CTO";
                }

                // Gives a random salary. The range is based on if they job role is CEO or not.
                if(position == "CEO")
                {
                    salary = (ushort)random.Next(400000, 500000);
                }
                else
                {
                    salary = (ushort)random.Next(250000, 400000);
                }

                // The company email becomes their name, without the space  between first and last name @Company.com.
                string email = $"{name.Replace(" ", "")}@Company.com";

                // A random 8 digit phone number is assigned to the executive.
                int phoneNum = random.Next(10000000, 99999999);

                // Exectives have extra vacation days. These days can be between 10 and 20.
                byte additionalVacation = (byte)random.Next(10, 20);

                // The executive gets all their values, through the constructor. The company vehicle will be assigned through the return in the CreateCar method.
                // Once the executive has been created, it gets added to the list of workers in the company. 
                Executive executive = new(name, position, salary, email, phoneNum, CreateCar(), additionalVacation);
                employees.workers.Add(executive);
            }
        }

        /// <summary>
        /// This method creates a manager. The steps are essentially the same as the executive worker creation,
        /// Therefore i wont go in much dept since its directly above this method.
        /// This method now uses the variable from the foor loop 'i' to decide which manager the worker is.
        /// The worker then gets a bunch of different values for their variables, which are used when they get created.
        /// Just like the executive, the managers also have company vehicles, but no extra vacation.
        /// Once created, the manager gets put in the employees list.
        /// </summary>
        private void CreateManager()
        {
            string position = "";

            for (int i = 0; i < 4; i++)
            {
                string name = NameGenerator();

                if (i == 0)
                {
                    position = "IT manager";
                }
                else if (i == 1)
                {
                    position = "Marketing manager";
                }
                else if (i == 2)
                {
                    position = "Finance manager";
                }
                else if (i == 3)
                {
                    position = "Sales manager";
                }

                ushort salary = (ushort)random.Next(100000, 250000);

                string email = $"{name.Replace(" ", "")}@Company.com";
                int phoneNum = random.Next(10000000, 99999999);

                Manager manager = new(name, position, salary, email, phoneNum, CreateCar());
                employees.workers.Add(manager);
            }
        }

        /// <summary>
        /// This method creates 2 HR people. 
        /// Unlike previous creation methods, this method calls the randomizer class, 
        /// to decide which specialization the HR person has.
        /// Otherwise its the same as previous creation methods.
        /// </summary>
        private void CreateHR()
        {
            for (int i = 0; i < 2; i++)
            {
                string name = NameGenerator();

                string position = "Human resources";

                ushort salary = (ushort)random.Next(30000, 75000);

                string email = $"{name.Replace(" ", "")}@Company.com";
                int phoneNum = random.Next(10000000, 99999999);

                string specialization = randomizer.specializations[random.Next(0, 16)];

                HumanResources hr = new(name, position, salary, email, phoneNum, specialization);
                employees.workers.Add(hr);
            }
        }

        /// <summary>
        /// CreateEmployees is the last creation method. 
        /// This method creates 20 employees, which all get a random job position. 
        /// A job position could be within marketing, IT, sales or even something else.
        /// All the job positions are within the Randomizer class, in the 'Roles' array.
        /// Once again, it looks very alike the other creation methods.
        /// </summary>
        private void CreateEmployee()
        {
            for (int i = 0; i < 20; i++)
            {
                string name = NameGenerator();

                string position = randomizer.roles[random.Next(0, 20)];

                ushort salary = (ushort)random.Next(25000, 100000);

                string email = $"{name.Replace(" ", "")}@Company.com";
                int phoneNum = random.Next(10000000, 99999999);

                Employee employee = new(name, position, salary, email, phoneNum);
                employees.workers.Add(employee);
            }
        }

        /// <summary>
        /// This method creates 2 variables 'first' and 'last'. 
        /// These names represent first and last names. 
        /// The method uses a random value to determine which first and last name the employee should have.
        /// Once the 2 variables have a value each, it returns the values combined, which becomes the full name.
        /// </summary>
        /// <returns></returns>
        private string NameGenerator()
        {
            string first = randomizer.firstNames[random.Next(0, 21)];
            string last = randomizer.lastNames[random.Next(0, 15)];

            return $"{first} {last}";
        }

        /// <summary>
        /// CreateCar() retrieves any car which is not currently in use. 
        /// This company has 10 company vehicles, which is plenty for them.
        /// This method retrieves a car based on a random number. 
        /// If the car is already in use, then the while loop runs again and gets another number.
        /// The loop repeats over and over, until a vehicle which is not in use, has been found.
        /// This vehicle then gets assigned to the manager or executive and "InUse" becomes true.
        /// </summary>
        /// <returns></returns>
        private CompanyVehicle CreateCar()
        {
            CompanyVehicle vehicle = new CompanyVehicle();
            VehicleList vehicles = new VehicleList();

            while (true)
            {
                int rdm = random.Next(0, 10);
                vehicle = vehicles.vehicles[rdm];

                if (!vehicle.InUse)
                {
                    vehicle.InUse = true;
                    return vehicle;
                }
            }
        }

        /// <summary>
        /// This method runs at the end of the program.
        /// It has a for loop which goes through each worker in the employee list.
        /// Each employee then gets an ID, which is also displayed when the message gets output to the view.
        /// </summary>
        private void Output()
        {
            for( int i = 0; i < employees.workers.Count; i++ )
            {
                view.ColorChange(i);

                view.Message($"Employee ID: {i}{employees.workers[i]}");
            }
        }
    }
}
