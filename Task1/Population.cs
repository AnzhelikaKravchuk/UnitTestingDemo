using System;

namespace Task1
{
    /// <summary>
    /// This class is for smth.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// This method is for counting years.
        /// </summary>
        /// <param name="initialPopulation">
        /// InitialPopullation is initial number of people.
        /// </param>
        /// <param name="percent">
        /// Popullation growth.
        /// </param>
        /// <param name="visitors">
        /// Number of visitors per year.
        /// </param>
        /// <param name="currentPopulation">
        /// The number of people is planning.
        /// </param>
        /// <returns>
        /// How many years meet the requirement.
        /// </returns>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0 || visitors <= 0 || currentPopulation <= 0)
            {
                 throw new ArgumentException("Initial population cannot be less or equals zero.");
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException("Value of percents cannot be less then 0% or more then 100%.");
            }

            int sumYears = 0;

            while (initialPopulation < currentPopulation)
            {
                int counter = ((int)(initialPopulation * percent) / 100) + visitors;
                initialPopulation += counter;
                sumYears++;
            }

            return sumYears;
        }
    }
}