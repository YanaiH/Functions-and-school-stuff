using System;
namespace functionsSchoolStuff
{
    class YearRain
    {
        private int year;
        private int[] rainEachMonth;

        public YearRain(int year, int[] rainEachMonth)
        {
            this.year = year;
            if (rainEachMonth.Length == 12)
            {
                this.rainEachMonth = rainEachMonth;
            }
        }

        public int RainiestMonth()
        {
            int rainiest = 0;
            for (int i = 0; i < 12; i++)
            {
                if (rainEachMonth[i]>rainiest)
                {
                    rainiest = rainEachMonth[i];
                }
            }
            return rainiest;
        }

        public double AverageRain()
        {
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum = sum + rainEachMonth[i];
            }
            return sum / 12;
        }

        public bool Were5DryOrMore()
        {
            int dryCount = 0;
            for (int i = 0; i < 12; i++)
            {
                if (rainEachMonth[i] == 0)
                {
                    dryCount++;
                }
            }
            if (dryCount >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
