using System;

namespace Task1
{
    /// <summary>Provides a <see cref="GetYears(int, double, int, int)"/> method.</summary>
    public static class Population
    {
        private const int MinNumberOfPeople = 1;
        private const double MinValueOfPercents = 0.0;
        private const double MaxValueOfPercents = 100.0;

        /// <summary>Gets the number of years needed tower to see its population greater or equal to <em>currentPopulation</em> inhabitants.</summary>
        /// <param name="initialPopulation">The population at the beginning of a year.</param>
        /// <param name="percent">Part of <em>initialPopulation</em> by which the population is increasing.</param>
        /// <param name="visitors">New inhabitants per year.</param>
        /// <param name="currentPopulation">Current population inhabitants.</param>
        /// <returns>Returns the number of years.</returns>
        /// <exception cref="ArgumentException">Thrown when <em>initialPopulation</em> or <em>visitors</em> or <em>currentPopulation</em> have an invalid value.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <em>percent</em> have an invalid value.</exception>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation < MinNumberOfPeople)
            {
                throw new ArgumentException("Initial population must be greater than zero.", nameof(initialPopulation));
            }

            if (visitors < MinNumberOfPeople)
            {
                throw new ArgumentException("Number of visitors must be greater than zero. ", nameof(visitors));
            }

            if (currentPopulation < MinNumberOfPeople)
            {
                throw new ArgumentException("Current population must be greater than zero.", nameof(currentPopulation));
            }

            if (percent < MinValueOfPercents || percent > MaxValueOfPercents)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "Percent value must be in the range from 0 to 100.");
            }

            int years = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation += (int)((initialPopulation * (percent / 100)) + visitors);
                years++;
            }

            return years;
        }
    }
}