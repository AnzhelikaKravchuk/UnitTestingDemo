using System;

namespace Task1
{
    public static class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            // put your code here

            if (initialPopulation <=0)
            {
                throw new ArgumentException("Initial population cannot be less or equals zero.");
            }

            if (percent < 0d || percent > 100d )
            {
                throw new ArgumentOutOfRangeException("Value of percents cannot be less then 0 % or more then 100 %.");
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
                initialPopulation += (int)(initialPopulation * percent/100d) + visitors;
            }

            return years;
        }
    }
}