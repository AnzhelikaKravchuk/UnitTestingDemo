using System;

namespace Task1
{
    public static class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (visitors < 0) throw new ArgumentException("Count of visitors cannot be less zero.");
            if ((percent > 100) || (percent < 0)) throw new ArgumentOutOfRangeException("Value of percents cannot be less then 0% or more then 100%.");
            if (initialPopulation <= 0) throw new ArgumentException("Initial population cannot be less or equals zero.");
            
            int countOfYears = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation = initialPopulation + visitors + ((int)((initialPopulation * percent) / 100));
                countOfYears++;
            }
            return countOfYears;
            throw new NotImplementedException();
        }
    }
}