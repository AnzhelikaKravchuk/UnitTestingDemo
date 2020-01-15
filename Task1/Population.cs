using System;

namespace Task1
{
    /// <summary>
    /// The class Population.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// Function to calculate how many years needed to increase
        /// population to currentPopulation.
        /// </summary>
        /// <param name="initialPopulation">Initial population of town.</param>
        /// <param name="percent">Percent to increase count of people per year.</param>
        /// <param name="visitors">Imigrants which come per year.</param>
        /// <param name="currentPopulation">Current population of town.</param>
        /// <returns>The count of years needed to reach currentPopulation.</returns>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            /// <exception cref="ArgumentException"> this params
            /// <paramref name="initialPopulation"/>
            /// <paramref name="currentPopulation"/>
            /// <paramref name="visitors"/>
            /// cannot accept value less or equal to zero.
            /// </exception>
            if (initialPopulation <= 0 || currentPopulation <= 0 || visitors <= 0)
            {
                throw new ArgumentException(string.Empty);
            }

            /// <exception cref="ArgumentOutOfRangeException"> this params
            /// <paramref name="percent"/>
            /// cannot accept value less than 0 or greater than > 100.
            /// </exception>
            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(string.Empty);
            }

            int years = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation += ((int)(initialPopulation * percent / 100)) + visitors;
                years++;
            }

            return years;
            throw new NotImplementedException();
        }
    }
}