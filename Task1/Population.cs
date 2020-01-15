using System;

namespace Task1
{
    /// <summary>
    /// The main class of the project.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// Counts how many years will pass before the population reaches the desired size.
        /// </summary>
        /// <param name="initialPopulation">The initial number of settlers. </param>
        /// <param name="percent">Population growth rate percent. </param>
        /// <param name="visitors">The number of people coming every year. </param>
        /// <param name="currentPopulation">Required size of population. </param>
        /// <returns>Сount of years. </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Occurs when percent values are out of the range of 0 to 100.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// Occurs when initialPopulation less or equal zero or
        /// count of visitors less than zero or
        /// current population less or equals zero.
        /// </exception>
        /// <example>
        /// <code>
        /// int year = GetYears(1500, 5, 100, 5000)
        /// </code>
        /// </example>
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

            int counter = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation += (int)(initialPopulation / 100 * percent) + visitors;
                counter++;
            }

            return counter;
        }
    }
}