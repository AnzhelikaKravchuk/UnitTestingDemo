using System;

namespace Task1
{
    /// <summary>
    /// Includes GetYears method.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// This method counts how many years passed before initial population reached current value.
        /// </summary>
        /// <param name="initialPopulation">Initial population of a town/country.</param>
        /// <param name="percent">By how many percents initial population increases.</param>
        /// <param name="visitors">How many new inhabitants have come.</param>
        /// <param name="currentPopulation">Current population of a town/country.</param>
        /// <returns>How many years passed before initial population reached current value.</returns>
        /// <exception cref="ArgumentException()">In case amount of people is less or equals zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException()">If percentage is below zero or above 100.</exception>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0 || visitors < 0 || currentPopulation <= 0)
            {
                throw new ArgumentException(string.Empty);
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(string.Empty);
            }

            int result_years = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation += (int)(initialPopulation * percent / 100) + visitors;
                result_years++;
            }

            return result_years;
        }
    }
}