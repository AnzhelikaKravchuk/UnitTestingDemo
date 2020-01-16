using System;

namespace Task1
{
    /// <summary>
    /// Class containing population data processing methods.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// Method that calculates years quantity does the town need to see its population greater or equal to currentPopulation inhabitants.
        /// </summary>
        /// <param name="initialPopulation"> Population at the beginning of a year. </param>
        /// <param name="percent"> Population growth percentage per year. </param>
        /// <param name="visitors"> New inhabitants per year. </param>
        /// <param name="currentPopulation"> Current population. </param>
        /// <returns> Years quantity. </returns>
        /// <exception type = "ArgumentException"> initialPopulation, currentPopulation is less or equals zero. -or- visitors is is less than zero.</exception>
        /// <exception type = "ArgumentOutOfRangeException"> percents is less then 0 % or more then 100 %.</exception>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be less or equals zero.");
            }

            if (percent < 0d || percent > 100d)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "Value of percents cannot be less then 0 % or more then 100 %.");
            }

            if (visitors < 0)
            {
                throw new ArgumentException("Count of visitors cannot be less zero.");
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be less or equals zero.");
            }

            int years = 0;

            while (initialPopulation <= currentPopulation)
            {
                years++;
                initialPopulation += (int)(initialPopulation * percent / 100d) + visitors;
            }

            return years;
        }
    }
}