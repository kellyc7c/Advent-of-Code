using FluentAssertions;
using NUnit.Framework;

namespace DayOne
{
    [TestFixture]
    public class FuelCalculatorTests
    {
        [Test]
        public void WithMassOfTwelve_CalculateFuelReturnsTwo()
        {
            var fuelRequired = FuelCalculator.CalculateJustTheInitialFuelRequiredFromMass(12);

            fuelRequired.Should().Be(2);
        }

        [Test]
        public void WithMassOfFourteen_CalculateFuelReturnsTwo()
        {
            var fuelRequired = FuelCalculator.CalculateJustTheInitialFuelRequiredFromMass(14);

            fuelRequired.Should().Be(2);
        }

        [Test]
        public void WithMassOf1969_CalculateFuelReturns654()
        {
            var fuelRequired = FuelCalculator.CalculateJustTheInitialFuelRequiredFromMass(1969);

            fuelRequired.Should().Be(654);
        }

        [Test]
        public void WithMassOf100756_CalculateFuelReturns33583()
        {
            var fuelRequired = FuelCalculator.CalculateJustTheInitialFuelRequiredFromMass(100756);

            fuelRequired.Should().Be(33583);
        }

        [Test]
        public void WithMassOf5_CalculateFuelReturns0()
        {
            var fuelRequired = FuelCalculator.CalculateJustTheInitialFuelRequiredFromMass(5);

            fuelRequired.Should().Be(0);
        }

        [Test]
        public void WithMassOfMinusSix_CalculateFuelReturns0()
        {
            var fuelRequired = FuelCalculator.CalculateJustTheInitialFuelRequiredFromMass(-6);

            fuelRequired.Should().Be(0);
        }

        [Test]
        public void WithMassOf14_CalculateAllFuelReturns2()
        {
            var fuelRequired = FuelCalculator.CalculateAllFuelRequiredFromMass(14);

            fuelRequired.Should().Be(2);
        }

        [Test]
        public void WithMassOf1969_CalculateAllFuelReturns966()
        {
            var fuelRequired = FuelCalculator.CalculateAllFuelRequiredFromMass(1969);

            fuelRequired.Should().Be(966);
        }

        [Test]
        public void WithMassOf100756_CalculateAllFuelReturns50346()
        {
            var fuelRequired = FuelCalculator.CalculateAllFuelRequiredFromMass(100756);

            fuelRequired.Should().Be(50346);
        }
    }
}
