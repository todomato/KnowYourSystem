using KnowUrSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowUrSystem
{
    public class FinanceCalulator
    {
        public double Expectancy { get; set; }
        public double StandardDeviation { get; set; }
        public double WinRate { get; set; }
        public double WinLossRatio { get; set; }
        public int Trades { get; set; }


        
        private IEnumerable<SettingDistribution> distributions;

        public FinanceCalulator(IEnumerable<SettingDistribution> distributions)
        {
            this.distributions = distributions;
        }


        public void CalculateExpectancy()
        {
            throw new NotImplementedException();
        }

        public void CalculateStandardDeviation()
        {
            throw new NotImplementedException();
        }

        public void CalculateWinRate()
        {
            throw new NotImplementedException();
        }

        public void CalculateWinLossRatio()
        {
            throw new NotImplementedException();
        }

        public void CalculateTrades()
        {
            throw new NotImplementedException();
        }
    }
}
