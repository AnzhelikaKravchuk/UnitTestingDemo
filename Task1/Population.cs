using System;

namespace Task1
{
    /// <summary>
    /// This is Population class.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// This method returns the number of years that a city needs for its population to increase.
        /// </summary>
        /// <param name="initialPopulation">InitialPopulation is the population at the beginning of a year.</param>
        /// <param name="percent">The percentage by which the population increases per year.</param>
        /// <param name="visitors">Number of visitors per year.</param>
        /// <param name="currentPopulation">Current population of the city.</param>
        /// <returns>Number of years.</returns>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException("Invalid percent parameters.");
            }

            if (initialPopulation <= 0 || visitors <= 0 || currentPopulation <= 0)
            {
                throw new ArgumentException("Invalid parameters of current population, initial population or visitors");
            }

            int years = 0;
            double newPopulation;

            while (initialPopulation <= currentPopulation)
            {
                newPopulation = visitors + (initialPopulation * (1 + (percent / 100)));
                initialPopulation = Convert.ToInt32(newPopulation);
                years++;
            }

            return years;
        }
    }
}