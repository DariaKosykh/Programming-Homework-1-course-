using NUnit.Framework;
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
    }
}