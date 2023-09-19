using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_firm_v2.Model.Other
{
    /// <summary>
    /// This class contains a list which has 10 vehicles. These are the 10 vehicles that the company has.
    /// These cars can then be used by managers and executives, once the car is assigned to them.
    /// </summary>
    internal class VehicleList
    {
        internal List<CompanyVehicle> vehicles = new()
        {
            new CompanyVehicle
            {
                Model = "Toyota Camry",
                DistanceDriven = 564565.1f,
                LicensePlate = "HB64525",
                Color = "Pink",
            },
            new CompanyVehicle
            {
                Model = "Ford F-150",
                DistanceDriven = 58392.5f,
                LicensePlate = "JF84297",
                Color = "blue",
            },
            new CompanyVehicle
            {
                Model = "Honda Civic",
                DistanceDriven = 23457.6f,
                LicensePlate = "GS83408",
                Color = "blue",
            },
            new CompanyVehicle
            {
                Model = "Chevrolet Silverado",
                DistanceDriven = 67233.7f,
                LicensePlate = "KH93135",
                Color = "Yellow",
            },
            new CompanyVehicle
            {
                Model = "Volkswagen Golf",
                DistanceDriven = 69420.1f,
                LicensePlate = "FJ69420",
                Color = "Lime green",
            },
            new CompanyVehicle
            {
                Model = "BMW 3 Series",
                DistanceDriven = 43812.8f,
                LicensePlate = "AE43921",
                Color = "black",
            },
            new CompanyVehicle
            {
                Model = "Mercedes-Benz E-Class",
                DistanceDriven = 23541.6f,
                LicensePlate = "UI32590",
                Color = "White",
            },
            new CompanyVehicle
            {
                Model = "Jeep Wrangle",
                DistanceDriven = 12421.3f,
                LicensePlate = "JW64120",
                Color = "Red",
            },
            new CompanyVehicle
            {
                Model = "Tesla Model 3",
                DistanceDriven = 23411.1f,
                LicensePlate = "TM12345",
                Color = "Orange",
            },
            new CompanyVehicle
            {
                Model = "Nissan Rogue",
                DistanceDriven = 9954.3f,
                LicensePlate = "BR80085",
                Color = "Black",
            },
        };
    }
}
