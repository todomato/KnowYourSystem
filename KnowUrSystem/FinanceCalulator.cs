using KnowUrSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KnowUrSystem
{
    public class FinanceCalulator
    {
        public Decimal Expectancy { get; set; }
        public Decimal StandardDeviation { get; set; }
        public Decimal WinRate { get; set; }
        public Decimal WinLossRatio { get; set; }
        public int Trades { get; set; }

        private IEnumerable<SettingDistribution> distributions;

        public FinanceCalulator(IEnumerable<SettingDistribution> distributions)
        {
            this.distributions = distributions;
        }

        public void CalculateExpectancy()
        {
            var totalSum = distributions.Sum(c => c.RMultiple * c.Count);
            this.Expectancy = Math.Round(totalSum / this.Trades, 2);
        }

        public void CalculateStandardDeviation()
        {
            //標準差定義 : https://goo.gl/QntJ5
            var totalSum = distributions.Sum(c => c.RMultiple * c.Count);
            var mean = totalSum / this.Trades;
            var deviationFromMean = distributions.Sum(c => (c.RMultiple - mean) * (c.RMultiple - mean) * c.Count);
            var SD = Math.Sqrt((double)deviationFromMean / this.Trades);
            this.StandardDeviation = Math.Round((Decimal)SD, 2);
        }

        public void CalculateWinRate()
        {
            Decimal winTimes = distributions.Sum(c => c.RMultiple > 0 ? c.Count : 0);
            this.WinRate = Math.Round((winTimes / this.Trades) * 100, 2);
        }

        public void CalculateWinLossRatio()
        {
            var winTimes = distributions.Sum(c => c.RMultiple > 0 ? c.Count : 0);
            var wins = distributions.Sum(c => c.RMultiple > 0 ? c.RMultiple * c.Count : 0);
            var loseTimes = distributions.Sum(c => c.RMultiple < 0 ? c.Count : 0);
            var losses = distributions.Sum(c => c.RMultiple < 0 ? c.RMultiple * c.Count : 0);
            this.WinLossRatio = Math.Round((wins / winTimes) / (losses / loseTimes) * (-1), 2);
        }

        public void CalculateTrades()
        {
            this.Trades = distributions.Sum(c => c.Count);
        }
    }
}