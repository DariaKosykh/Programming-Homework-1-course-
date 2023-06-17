using NUnit.Framework;
using System.Diagnostics.Contracts;
using static CarsLibrary.Cars;

namespace CarsLibrary.UnitTests
{
    public class Tests
    {
        [TestFixture]

        public class CarsTests
        {
            static Car car;

            [SetUp]
            public void Setup()
            {
                car = new Car("Hundai", 2000, "12345678901234567", BodyType.Sedan);
            }

            [Test]
            public void ConstructorTest()
            {

                Assert.That(car.Brand, Is.EqualTo("Hundai"));
                Assert.That(car.YearOfRelease, Is.EqualTo(2000));
                Assert.That(car.VIN, Is.EqualTo("12345678901234567"));
                Assert.That(car.BodyType, Is.EqualTo(BodyType.Sedan));

            }

            [Test]
            public void GetInfo_Car_ReturnsCorrectString()
            {
                const string expectedString = $"Brand: Hundai. Year of release: 2000. VIN: 12345678901234567. Body type: Sedan \n"
                                              + $"Price: 0. Date of sale: 01.01.0001. Customer full name: ";
                var car = new Car("Hundai", 2000, "12345678901234567", BodyType.Sedan);

                var result = car.GetInfo();

                Assert.That(result, Is.EqualTo(expectedString));
            }
        }
        public class NewCarTests
        {
            [Test]
            public void NewCar_ValidArguments_CreateNewCar()
            {
                var newCar = new NewCar("Hundai", 2000, "12345678901234567", BodyType.Sedan, "Factory 1",
                    TimeSpan.FromDays(365));

                Assert.That(newCar.Brand, Is.EqualTo("Hundai"));
                Assert.That(newCar.YearOfRelease, Is.EqualTo(2000));
                Assert.That(newCar.VIN, Is.EqualTo("12345678901234567"));
                Assert.That(newCar.BodyType, Is.EqualTo(BodyType.Sedan));
                Assert.That(newCar.Factory, Is.EqualTo("Factory 1"));
                Assert.That(newCar.GuaranteeTime, Is.EqualTo(TimeSpan.FromDays(365)));
            }

            [Test]
            public void GetInfo_NewCar_ReturnsCorrectString()
            {
                const string expectedString = $"Brand: Hundai. Year of release: 2000. VIN: 12345678901234567. Body type: Sedan \n"
                                              + $"Price: 0. Date of sale: 01.01.0001. Customer full name: \n"
                                                + "Factory: Factory 1. Guarantee time: 365 days";

                var newCar = new NewCar("Hundai", 2000, "12345678901234567", BodyType.Sedan, "Factory 1",
                    TimeSpan.FromDays(365));

                var result = newCar.GetInfo();

                Assert.That(result, Is.EqualTo(expectedString));
            }
        }
        public class UsedCarTests
        {
            [Test]
            public void UsedCar_ValidArguments_CreateCar()
            {
                var usedCar = new UsedCar("Hundai", 2000, "12345678901234567", BodyType.Sedan, 1000, CarCondition.Excellent);

                Assert.That(usedCar.Brand, Is.EqualTo("Hundai"));
                Assert.That(usedCar.YearOfRelease, Is.EqualTo(2000));
                Assert.That(usedCar.VIN, Is.EqualTo("12345678901234567"));
                Assert.That(usedCar.BodyType, Is.EqualTo(BodyType.Sedan));
                Assert.That(usedCar.Mileage, Is.EqualTo(1000));
                Assert.That(usedCar.Condition, Is.EqualTo(CarCondition.Excellent));
            }

            [Test]
            public void GetInfo_UsedCar_ReturnsCorrectString()
            {
                const string expectedString = $"Brand: Hundai. Year of release: 2000. VIN: 12345678901234567. Body type: Sedan \n"
                                              + $"Price: 0. Date of sale: 01.01.0001. Customer full name: \n"
                                              + $"Mileage: 1000. Condition: Excellent";  
                var usedCar = new UsedCar("Hundai", 2000, "12345678901234567", BodyType.Sedan, 1000, CarCondition.Excellent);

                var result = usedCar.GetInfo();

                Assert.That(result, Is.EqualTo(expectedString));
            }
        }
        public class CommissionCarTests
        {
            [Test]
            public void CommissionCar_ValidArguments_CreateCar()
            {
                var commissionCar = new CommissionCar("Hundai", 2000, "12345678901234567", BodyType.Sedan, 1000,
                    CarCondition.Excellent, "Ivanov Ivan Ivanovich", "Lenin Street 6", "123");

                Assert.That(commissionCar.Brand, Is.EqualTo("Hundai"));
                Assert.That(commissionCar.YearOfRelease, Is.EqualTo(2000));
                Assert.That(commissionCar.VIN, Is.EqualTo("12345678901234567"));
                Assert.That(commissionCar.BodyType, Is.EqualTo(BodyType.Sedan));
                Assert.That(commissionCar.Mileage, Is.EqualTo(1000));
                Assert.That(commissionCar.Condition, Is.EqualTo(CarCondition.Excellent));
                Assert.That(commissionCar.OwnerFullName, Is.EqualTo("Ivanov Ivan Ivanovich"));
                Assert.That(commissionCar.OwnerAddress, Is.EqualTo("Lenin Street 6"));
                Assert.That(commissionCar.ContractNumber, Is.EqualTo("123"));
            }

            [Test]
            public void GetInfo_CommissionCar_ReturnsCorrectString()
            {
                const string expectedString = $"Brand: Hundai. Year of release: 2000. VIN: 12345678901234567. Body type: Sedan \n"
                                              + $"Price: 0. Date of sale: 01.01.0001. Customer full name: \n"
                                              + $"Mileage: 1000. Condition: Excellent \n"
                                              + $"Owner full name:Ivanov Ivan Ivanovich . Owner address: Lenin Street 6. Contract number: 123.";;
                var commissionCar = new CommissionCar("Hundai", 2000, "12345678901234567", BodyType.Sedan, 1000,
                    CarCondition.Excellent, "Ivanov Ivan Ivanovich", "Lenin Street 6", "123");

                var result = commissionCar.GetInfo();

                Assert.That(result, Is.EqualTo(expectedString));
            }
        }


}