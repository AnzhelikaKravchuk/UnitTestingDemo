using System;

namespace Task1
{
    public static class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be less or equals zero.", nameof(initialPopulation));
            }

            if(percent<0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException("Value of percents cannot be less then 0% or more then 100%.", nameof(percent));
            }

            if (visitors < 0)
            {
                throw new ArgumentException("Count of visitors cannot be less zero.", nameof(visitors));
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be less or equals zero.", nameof(currentPopulation));
            }

            int yearCount = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation += (int)((percent * initialPopulation) / 100 + visitors);
                yearCount++;
            }

            return yearCount;
        }
    }
}