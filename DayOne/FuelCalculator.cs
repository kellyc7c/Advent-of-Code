namespace DayOne
{
    class FuelCalculator
    {
        public static int CalculateJustTheInitialFuelRequiredFromMass(int mass)
        {
            var result = mass / 3 - 2;

            if (result < 0) return 0;
            return result;
        }

        public static int CalculateAllFuelRequiredFromMass(int mass)
        {
            int totalFuel = 0;
            var newFuel = mass;

            while (newFuel > 0)
            {
                newFuel = CalculateJustTheInitialFuelRequiredFromMass(newFuel);
                totalFuel += newFuel;
            }

            return totalFuel;
        }
    }
}
