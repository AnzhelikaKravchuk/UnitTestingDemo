using System;

namespace Task1
{
    public static class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            Validate(initialPopulation, percent, visitors, currentPopulation);

            int countYears = 0;
            while (true)
            {
                if (initialPopulation >= currentPopulation)
                {
                    return countYears;
                }
                countYears++;

                initialPopulation += (int)(percent * initialPopulation / 100);
                initialPopulation += visitors;
            }
        }

        private static void Validate(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (percent <= 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException($"Value of {nameof(percent)} cannot be" +
                    $" less then 0% or more then 100%.");
            }

            if (initialPopulation <= 0)
            {
                throw new ArgumentException($"{nameof(initialPopulation)} cannot be less or equals zero.");
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException($"{nameof(currentPopulation)} cannot be less or equals zero.");
            }

            if (visitors < 0)
            {
                throw new ArgumentException($"Count of {nameof(visitors)} cannot be less zero.");
            }
        }
    }
}