using System;

namespace Task1
{
    /// <summary>
    /// Class that discribeы population.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// Сonsiders how many years the town needs to see its population greater or equal to currentPopulation inhabitants.
        /// </summary>
        /// <param name="initialPopulation">the population at the beginning of a year.</param>
        /// <param name="percent">number of regular increase in residents.</param>
        /// <param name="visitors">new inhabitants per year.</param>
        /// <param name="currentPopulation">current population inhabitants.</param>
        /// <returns>How many years does the town need to see its population greater or equal to currentPopulation inhabitants.</returns>
        /// <exception cref="System.ArgumentException">Thrown when initial population, current population or count of visitors less or equals zero.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when value of percents are less then 0% or more then 100%.</exception>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be less or equals zero.", nameof(visitors));
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be less or equals zero.", nameof(visitors));
            }

            if (visitors < 0)
            {
                throw new ArgumentException("Count of visitors cannot be less zero.", nameof(visitors));
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "Value of percents cannot be less then 0% or more then 100%.");
            }

            double peopleCount = initialPopulation;
            int years = 0;
            while (peopleCount < currentPopulation)
            {
                years++;
                peopleCount += (peopleCount * percent / 100) + visitors;
            }

            return years;
        }
    }
}