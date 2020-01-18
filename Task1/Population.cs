using System;

namespace Task1
{
    /// <summary>
    /// The main class of the program with GetYears method.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// Method for counting years the population reaches the currentPopulation.
        /// </summary>
        /// <param name="initialPopulation">Initial population of the town.</param>
        /// <param name="percent">Percent population increases per year.</param>
        /// <param name="visitors">New inhabitants come to live in the town.</param>
        /// <param name="currentPopulation">Population we need to reach.</param>
        /// <exception cref="System.ArgumentException">Throw when
        /// initialPopulation or percent or visitors are less than 0 or equal 0.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Throw then percent is greater than 100
        /// or less than 0.
        /// </exception>
        /// <returns>Number of years.</returns>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0 | currentPopulation <= 0 | visitors <= 0)
            {
                throw new ArgumentException("initialPopulation or currentPopulation or visitors <= 0");
            }

            if (percent < 0 | percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "percent < 0 or oercent > 100");
            }

            int i;
            double population = initialPopulation;
            for (i = 0; population <= currentPopulation; i++)
            {
                population = population * (100 + percent) / 100;
                population += visitors;
            }

            return i;
        }
    }
}