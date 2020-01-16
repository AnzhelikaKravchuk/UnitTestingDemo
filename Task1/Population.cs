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
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be zero or below.", nameof(initialPopulation));
            }

            if (visitors < 0)
            {
                throw new ArgumentException("Annual visitors cannot be less than zero", nameof(visitors));
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be zero or below.", nameof(currentPopulation));
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "Percent rate cannot be below 0 or above 100.");
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