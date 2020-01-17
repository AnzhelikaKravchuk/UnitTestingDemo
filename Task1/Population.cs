using System;

namespace Task1
{
    /// <summary>
    /// The Population class.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// Gets the number of years it takes a population to exceed currentPopulation.
        /// </summary>
        /// <param name="initialPopulation">Initial population.</param>
        /// <param name="percent">Annual growth.</param>
        /// <param name="visitors">Number of annual visitors.</param>
        /// <param name="currentPopulation">Current population.</param>
        /// <returns>Number of years it takes a population to exceed currentPopulation.</returns>
        /// <exception cref="ArgumentException">Thrown when initial or current population
        /// is less than or equal to 0 or when the number of annual visitors is negative.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when annual growth percentage
        /// is less than 0% or greater than 100%.</exception>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            Validate(initialPopulation, percent, visitors, currentPopulation);

            return (initialPopulation <= currentPopulation) ? CalculateYears(initialPopulation, percent, visitors, currentPopulation) : 0;
        }

        private static void Validate(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException($"{nameof(initialPopulation)} cannot be less or equal to zero.");
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException($"{nameof(currentPopulation)} cannot be less or equal to zero.");
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException($"{nameof(percent)} cannot be less than 0 or greater than 100.");
            }

            if (visitors < 0)
            {
                throw new ArgumentException($"{nameof(visitors)} cannot be less than zero.");
            }
        }

        private static int CalculateYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            int counter = 0;

            while (initialPopulation <= currentPopulation)
            {
                initialPopulation += (int)((percent / 100) * initialPopulation) + visitors;
                counter++;
            }

            return counter;
        }
    }
}