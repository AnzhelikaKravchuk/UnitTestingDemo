using System;

namespace Task1
{
    /// <summary>
    /// Class for counting the years of the towm.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// Counts years for which the town need to see its population greater of equal to currentPopulation.
        /// </summary>
        /// <param name="initialPopulation">The population at the beginning of the year.</param>
        /// <param name="percent">Percent of the per year population increasing.</param>
        /// <param name="visitors">New inhabitants per year.</param>
        /// <param name="currentPopulation">Population.</param>
        /// <exception cref="System.ArgumentException">Thrown when initialPopulation, currentPopulation or visitors are less or equal zero.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the percent value doesn't satusfy the possible values(from 0 to 100).</exception>
        /// <returns>Years.</returns>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be less or equals zero.", nameof(initialPopulation));
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException("Value of percents cannot be less then 0% or more then 100%.", nameof(percent));
            }

            if (visitors < 0)
            {
                throw new ArgumentException("Count of visitors cannot be less zero.", nameof(visitors));
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be less or equals zero.", nameof(currentPopulation));
            }

            int yearCount = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation += (int)((percent * initialPopulation / 100) + visitors);
                yearCount++;
            }

            return yearCount;
        }
    }
}