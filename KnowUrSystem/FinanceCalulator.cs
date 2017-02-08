using KnowUrSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KnowUrSystem
{
    public class FinanceCalulator : IFinanceCalulator
    {
        private IEnumerable<DistributionRawData> _distributions;
        private int _trades;
        private int Trades
        {
            get
            {
                if (_trades == 0)
                {
                    _trades = GetTrades();
                }

                return _trades;
            }
        }

        public FinanceCalulator(IEnumerable<DistributionRawData> distributions)
        {
            this._distributions = distributions;
        }

        public Decimal GetExpectancy()
        {
            var totalSum = _distributions.Sum(c => c.RMultiple * c.Count);
            return Math.Round(totalSum / Trades, 2);
        }

        public Decimal GetStandardDeviation()
        {
            //標準差定義 : https://goo.gl/QntJ5
            var totalSum = _distributions.Sum(c => c.RMultiple * c.Count);
            var mean = totalSum / Trades;
            var deviationFromMean = _distributions.Sum(c => (c.RMultiple - mean) * (c.RMultiple - mean) * c.Count);
            var SD = Math.Sqrt((double)deviationFromMean / Trades);
            return Math.Round((Decimal)SD, 2);
        }

        public Decimal GetWinRate()
        {
            Decimal winTimes = _distributions.Sum(c => c.RMultiple > 0 ? c.Count : 0);
            return Math.Round((winTimes / Trades) * 100, 2);
        }

        public Decimal GetWinLossRatio()
        {
            var winTimes = _distributions.Sum(c => c.RMultiple > 0 ? c.Count : 0);
            var wins = _distributions.Sum(c => c.RMultiple > 0 ? c.RMultiple * c.Count : 0);
            var loseTimes = _distributions.Sum(c => c.RMultiple < 0 ? c.Count : 0);
            var losses = _distributions.Sum(c => c.RMultiple < 0 ? c.RMultiple * c.Count : 0);
            return Math.Round((wins / winTimes) / (losses / loseTimes) * (-1), 2);
        }

        public int GetTrades()
        {
            return _distributions.Sum(c => c.Count);
        }

    }
}