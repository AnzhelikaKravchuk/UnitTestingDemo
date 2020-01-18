using System;

namespace Task1
{
    /// <summary>
    /// Population class which contains method to calculate how many years does the town need to see its population greater or equal to currentPopulation inhabitants.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// Calculate how many years does the town need to see its population greater or equal to currentPopulation inhabitants.
        /// </summary>
        /// <param name="initialPopulation">initial number of inhabitants.</param>
        /// <param name="percent">percentage increase in inhabitants per year.</param>
        /// <param name="visitors">visitors which will come to live in the town every year.</param>
        /// <param name="currentPopulation">current number of inhabitants.</param>
        /// <exception cref="ArgumentException">When currentPopulation, initialPopulation or visitors less or equals to zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">When value of percents less then 0% or more then 100%.</exception>
        /// <returns>Count of years that the town need to see its population greater or equal to currentPopulation inhabitants.</returns>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be less or equals zero.");
            }

            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be less or equals zero.");
            }

            if (visitors <= 0)
            {
                throw new ArgumentException("Count of visitors cannot be less or equals zero.");
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), percent, "Value of percents cannot be less then 0% or more then 100%.");
            }

            int yearsCount = 0;
            int initPopulation = initialPopulation;
            int currPopulation = currentPopulation;
            while (initPopulation < currPopulation)
            {
                initPopulation += (int)((initPopulation / 100) * percent);
                initPopulation += visitors;
                yearsCount++;
            }

            return yearsCount;
        }
    }
}