using System;

namespace Task1
{
    /// <summary>
    /// Class for city population operations.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// Get the number of years for initialPopulation to become equal or greater than currentPopulation.
        /// </summary>
        /// <param name="initialPopulation">Population at the beginning of a year.</param>
        /// <param name="percent">Town population increasement percent per year.</param>
        /// <param name="visitors">Number of visitors per year.</param>
        /// <param name="currentPopulation">Needed populaton of a town.</param>
        /// <exception cref="ArgumentException">One or more of the passed arguments are invalid.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Passed argument is out of the acceptable range.</exception>
        /// <returns>Number of years for initialPopulation to become equal or greater than currentPopulation.</returns>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be less than or equal to zero.");
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), percent, "Percents cannot be less than 0 or more than 100.");
            }

            if (visitors < 0)
            {
                throw new ArgumentException("Number of visitors cannot be less than zero.");
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be less than or equal to zero.");
            }

            int years = 0;

            while (initialPopulation < currentPopulation)
            {
                double initialPopulationPerc = initialPopulation / 100;
                initialPopulationPerc *= percent;
                initialPopulation += (int)Math.Floor(initialPopulationPerc);
                initialPopulation += visitors;
                years++;
            }

            return years;
        }
    }
}