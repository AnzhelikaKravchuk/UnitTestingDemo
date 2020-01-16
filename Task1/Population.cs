using System;

namespace Task1
{
    /// <summary>
    /// The Population class.
    /// Contains all methods for performing calculating of population.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// Counts how many years does the town need to pass to reach currentPopulation value.
        /// </summary>
        /// <param name="initialPopulation">Initial population of a town.</param>
        /// <param name="percent">Initial population increasing percents per year.</param>
        /// <param name="visitors">Visitors of a town per year.</param>
        /// <param name="currentPopulation">Current population of a town.</param>
        /// <exception cref="ArgumentException()">Handle to avoid amount of people is less or equals zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException()">Handle to avoid value of percents is not in [0..100] range.</exception>
        /// <returns>
        /// How many years does the town need to pass to reach currentPopulation value.
        /// </returns>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be less or equals zero.");
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "Value of percents cannot be less then 0% or more then 100%.");
            }

            if (visitors < 0)
            {
                throw new ArgumentException("Count of visitors cannot be less zero.");
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be less or equals zero.");
            }

            int years = 0;
            double population = initialPopulation;

            while (population < currentPopulation)
            {
                population = (population * (1 + (percent / 100))) + visitors;
                years++;
            }

            return years;
        }
    }
}