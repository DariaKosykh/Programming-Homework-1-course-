using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibrary
{
    public class Cars
    {
        public enum BodyType
        {
            Sedan,
            Hatchback,
            StationWagon,
            Cabriolet
        }

        public class Car
        {
            public readonly string VIN;

            public string Brand { get; set; }

            public int YearOfRelease { get; set; }

            public BodyType BodyType { get; set; }

            public decimal Price { get; set; }

            public DateTime DateOfSale { get; set; }

            public string CustomerFullName { get; set; }

            public Car(string brand, int yearOfRelease, string vin, BodyType bodyType)
            {
                Brand = brand;
                if (yearOfRelease <= 0)
                    throw new ArgumentException();
                YearOfRelease = yearOfRelease;

                if (vin.Length != 17)
                    throw new ArgumentException();
                VIN = vin;
                BodyType = bodyType;
            }

            public string GetInfo()
            {
                var body = "";
                if (BodyType == BodyType.Sedan)
                    body = "Sedan";
                else if (BodyType == BodyType.Hatchback)
                    body = "Hatchback";
                else if (BodyType == BodyType.StationWagon)
                    body = "StationWagon";
                else if (BodyType == BodyType.Cabriolet)
                    body = "Cabriolet";
                return $"Brand: {Brand}. Year of release: {YearOfRelease}. VIN: {VIN}. Body type: {BodyType}\n" +
                       $"Price: {Price}. Date of sale: {DateOfSale.ToShortDateString()}. Customer full name: {CustomerFullName}";
            }
        }
    }
}

