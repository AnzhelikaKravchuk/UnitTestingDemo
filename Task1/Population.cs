using System;

namespace Task1
{
    /// <summary>
    /// Contains methods for working with populations.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// considers how many years will pass until the population reaches a given value.
        /// </summary>
        /// <param name="initialPopulation">initial amount of the population. </param>
        /// <param name="percent">percent of how the population grows year after year. </param>
        /// <param name="visitors">count of subjects that migrates into the population every year. </param>
        /// <param name="currentPopulation">value which population must reach. </param>
        /// <returns>count of years. </returns>
        /// <example>
        /// <code>
        /// int c = Population.GetYears(1, 2, 3, 4);
        /// if (c > 2)
        /// Console.WriteLine($"{c} years");
        /// </code>
        /// </example>
        /// <exception cref="System.ArgumentException">Thrown when initialPopulation less or equal zero or
        /// count of visitors less than zero or
        /// current population less or equals zero.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when percent value less than 0 or more than 100.
        /// </exception>
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

            if (visitors <= 0)
            {
                throw new ArgumentException("Count of visitors cannot be less zero.");
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be less or equals zero.");
            }

            double populationIncreaseRate = 1d + (percent / 100d);
            int years = 0;
            for (double nextYearPopulation = initialPopulation; nextYearPopulation < currentPopulation; years++)
            {
                nextYearPopulation = (nextYearPopulation * populationIncreaseRate) + visitors;
            }

            return years;
        }
    }
}