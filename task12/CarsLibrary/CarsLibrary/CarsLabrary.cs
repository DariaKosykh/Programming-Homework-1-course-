using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibrary
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
                body = "Седан";
            else if (BodyType == BodyType.Hatchback)
                body = "Хэтчбак";
            else if (BodyType == BodyType.StationWagon)
                body = "Уневирсал";
            else if (BodyType == BodyType.Cabriolet)
                body = "Кабриолет";
            return $"Марка: {Brand}. Год выпуска: {YearOfRelease}. VIN: {VIN}. Тип кузова: {BodyType}\n" +
                   $"Цена: {Price}. Дата продажи: {DateOfSale.ToShortDateString()}. ФИО покупателя: {CustomerFullName}";
        }




    }
