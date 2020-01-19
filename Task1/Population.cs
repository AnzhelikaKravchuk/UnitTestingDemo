// <copyright file="Population.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Task1
{
    using System;

    /// <summary >
    /// Сlass Population.
    /// </summary >
    public static class Population
    {
        /// <summary >
        /// Algorith of finding time to reach the current population level.
        /// </summary >
        /// <param  name = " initialPopulation " > Initial population value. </param >
        /// <param  name = " percent " > Population growth rate. </param >
        /// <param  name = " visitors " > Number of visitors. </param >
        /// <param  name = " currentPopulation " > Current population. </param >
        /// <exception cref="System.ArgumentException">Throw when
        /// initialPopulation or percent or visitors are less than 0 or equal 0.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Throw then percent is greater than 100
        /// or less than 0.
        /// </exception>
        /// <returns>Time to reach the current population level.  </returns>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be less or equals zero.");
            }

            if (percent <= 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "Value of percents cannot be less then 0% or more then 100%.");
            }

            if (visitors < 0)
            {
                throw new ArgumentException("Count of visitors cannot be less zero.");
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be less or equals zero.");
            }

            int result = 0;
            while (currentPopulation > initialPopulation)
            {
                initialPopulation += (int)(initialPopulation * percent / 100) + visitors;
                result++;
            }

            return result;
        }
    }
}