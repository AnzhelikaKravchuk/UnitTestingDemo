using System;

namespace Task1
{
    /// <summary>
    /// The class Population.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// Function to calculate how many years needed to increase
        /// population to currentPopulation.
        /// </summary>
        /// <param name="initialPopulation">Initial population of town.</param>
        /// <param name="percent">Percent to increase count of people per year.</param>
        /// <param name="visitors">Imigrants which come per year.</param>
        /// <param name="currentPopulation">Current population of town.</param>
        /// <returns>The count of years needed to reach currentPopulation.</returns>
        /// <exception cref="ArgumentException">Thrown when initialPopulation or currentPopulation or visitors less or equal to zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when percent is less than zero or greater than hundred.</exception>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Value cannot be greater than zero.", nameof(initialPopulation));
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Value cannot be greater than zero.", nameof(currentPopulation));
            }

            if (visitors <= 0)
            {
                throw new ArgumentException("Value cannot be greater than zero.", nameof(visitors));
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent));
            }

            int years = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation += ((int)(initialPopulation * percent / 100)) + visitors;
                years++;
            }

            return years;
        }
    }
}