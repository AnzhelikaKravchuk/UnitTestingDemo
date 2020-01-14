using System;

namespace Task1
{
    public static class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            // put your code here
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be less or equals zero.");
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException("Value of percents cannot be less then 0% or more then 100%.", new Exception());
            }

            if (visitors < 0)
            {
                throw new ArgumentException("Count of visitors cannot be less zero.");
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be less or equals zero.");
            }

            int counter = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation += (int)(initialPopulation / 100 * percent) + visitors;
                counter++;
            }

            return counter;
        }
    }
}