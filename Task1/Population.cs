using System;

namespace Task1
{
   /// <summary>
   /// Class "Population".
   /// </summary>
    public static class Population
    {
        /// <summary>
        /// The method, which calculates
        /// how many years does the town need to see its population greater or equal
        /// to currentPopulation inhabitants.
        /// </summary>
        /// <param name="initialPopulation"> Population at the beginning of a year.</param>
        /// <param name="percent"> Percent the population increases every year.</param>
        /// <param name="visitors"> New inhabitants per year come to live in the town.</param>
        /// <param name="currentPopulation">Number of inhabitants at the moment.</param>
        /// <returns>years does the town need to have population greater or equal to currentPopulation inhabitants.</returns>
        /// <exception cref="System.ArgumentException">Thrown when initial population, current population or count of visitors less or equals zero.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when value of percents are less then 0% or more then 100%.</exception>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (percent > 100 || percent < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "cannot be less then 0% or more then 100%.");
            }

            if (visitors < 0)
            {
                throw new ArgumentException("Count of visitors cannot be less zero.");
            }

            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be less or equals zero.");
            }

            int countOfYears = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation = initialPopulation + visitors + ((int)((initialPopulation * percent) / 100));
                countOfYears++;
            }

            return countOfYears;
        }
    }
}