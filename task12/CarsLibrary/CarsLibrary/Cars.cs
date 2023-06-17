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

            public virtual string GetInfo()
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
        public class NewCar : Car
        {
            public string Factory { get; set; }

            public TimeSpan GuaranteeTime { get; set; }

            public NewCar(string brand, int yearOfRelease, string vin, BodyType bodyType, string factory,
                TimeSpan guaranteeTime) : base(brand, yearOfRelease, vin, bodyType)
            {
                Factory = factory;
                GuaranteeTime = guaranteeTime;
            }

            public override string GetInfo()
            {
                return base.GetInfo() + $"\n Factory: {Factory}. Guarantee time: {GuaranteeTime.TotalDays} days";
            }
        }
        public enum CarCondition
        {
            Excellent,
            Good,
            Bad
        }

        public class UsedCar : Car
        {
            public double Mileage { get; set; }

            public CarCondition Condition { get; set; }

            public UsedCar(string brand, int yearOfRelease, string vin, BodyType bodyType, double mileage, CarCondition condition) : base(brand, yearOfRelease, vin,
                bodyType)
            {
                Mileage = mileage;
                Condition = condition;
            }

            private string GetConditionString()
            {
                var condition = "";
                if (Condition == CarCondition.Excellent)
                    condition = "Excellent";
                else if (Condition == CarCondition.Good)
                    condition = "Good";
                else if (Condition == CarCondition.Bad)
                    condition = "Bad";
                return $"\n Mileage: {Mileage}. Condition: {Condition}";
            }

        }
        public class CommissionCar : UsedCar
        {
            public string OwnerFullName { get; set; }

            public string OwnerAddress { get; set; }

            public string ContractNumber { get; set; }

            public CommissionCar(string brand, int yearOfRelease, string vin, BodyType bodyType, double mileage,
                CarCondition condition, string ownerFullName, string ownerAddress, string contractNumber) : base(brand,
                yearOfRelease, vin, bodyType, mileage, condition)
            {
                OwnerFullName = ownerFullName;
                OwnerAddress = ownerAddress;
                ContractNumber = contractNumber;
            }

            public override string GetInfo()
            {
                return base.GetInfo() +
                       $"\n Owner full name: {OwnerFullName}. Owner address: {OwnerAddress}. Contract number: {ContractNumber}.";
            }
        }
    }
}

