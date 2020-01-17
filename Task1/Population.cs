using System;

namespace Task1
{
    /// <summary>
    /// This class helps to find how many years does the town need to see its population greater or equal to current population.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// This method helps to count how much years must pass to get current population.
        /// </summary>
        /// <param name="initialPopulation">Amount of people, living in a town, at the beginning.</param>
        /// <param name="percent">Rate of increase of the population.</param>
        /// <param name="visitors">New inhabitants per year, which came to live in the town.</param>
        /// <param name="currentPopulation">Inhabitants of the town at the moment.</param>
        /// <returns>Amount of years the town needs to see its population greater or equal to current population.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when rate of increase is less than or equal to 0 or more than 100.</exception>
        /// <exception cref="ArgumentException">Thrown when initial population is less than 1 or current population is less than or equal to initial population or count of visitors is less than or equal to zero.</exception>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            int years = initialPopulation >= currentPopulation ? throw new ArgumentException("Current population must be more than initial population", nameof(currentPopulation)) :
                initialPopulation <= 0 ? throw new ArgumentException("Initial population must be more than 0", nameof(initialPopulation)) :
                visitors <= 0 ? throw new ArgumentException("Amount of visitors must be more than 0", nameof(visitors)) :
                percent <= 0 || percent > 100 ? throw new ArgumentOutOfRangeException(nameof(percent), "Rate of increase must be more than 0 and less than or equal to 100") : 0;

            while (initialPopulation < currentPopulation)
            {
                years++;
                initialPopulation += (int)(initialPopulation * percent / 100) + visitors;
            }

            return years;
        }
    }
}