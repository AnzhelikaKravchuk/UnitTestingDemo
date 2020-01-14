using System;

namespace Task1
{
    /// <summary>
    /// Contains methods for working with populations.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// considers how many years will pass until the population reaches a given value
        /// </summary>
        /// <param name="initialPopulation">initial amount of the population</param>
        /// <param name="percent">percent of how the population grows year after year</param>
        /// <param name="visitors">count of subjects that migrates into the population every year</param>
        /// <param name="currentPopulation">value which population must reach</param>
        /// <returns>count of years</returns>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be less or equals zero.");
            }
            else if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException("Value of percents cannot be less then 0% or more then 100%.");
            }
            else if (visitors < 0)
            {
                throw new ArgumentException("Count of visitors cannot be less zero.");
            }
            else if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be less or equals zero.");
            }
            else
            {
                double populationIncreaseRate = 1d + percent / 100d;
                int years = 0;
                for (double nextYearPopulation = initialPopulation; nextYearPopulation < currentPopulation; years++)
                {
                    nextYearPopulation = nextYearPopulation * populationIncreaseRate + visitors;
                }
                return years;
            }
        }
    }
}