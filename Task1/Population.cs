namespace Task1
{
    using System;

    /// <summary>
    /// An application entry point.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// Function that gets the number of years.
        /// </summary>
        /// <param name="initialPopulation"> The initial population of a town.</param>
        /// <param name="percent"> The percent by which the population increases each year.</param>
        /// <param name="visitors"> The number of the visitors which are coming to live in a town.</param>
        /// <param name="currentPopulation"> The current population of a town.</param>
        /// <exception cref="ArgumentException">Throws when the initial population is less or equals zero or visitors are less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Throws when the value of percents is less than 0% or more than 100%.</exception>
        /// <returns>The return value is the number of years which should pass to achieve current population of a town.</returns>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be less or equals zero.");
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "Value of percent cannot be less than 0% or more than 100%.");
            }

            if (visitors <= 0)
            {
                throw new ArgumentException("Count of visitors cannot be less than zero.");
            }

            int years = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation = initialPopulation + (int)(initialPopulation * percent / 100) + visitors;
                years++;
            }

            return years;
        }
    }
}