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
        private List<double> _rMutipleDetailBox;
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
        private List<double> DistributionsDetailBox
        {
            get
            {
                if (_rMutipleDetailBox == null)
                {
                    _rMutipleDetailBox = ParseDistributionToBox();
                }

                return _rMutipleDetailBox;
            }
        }

        public FinanceCalulator(IEnumerable<DistributionRawData> distributions)
        {
            this._distributions = distributions;
        }

        public double GetExpectancy()
        {
            var totalSum = _distributions.Sum(c => c.RMultiple * c.Count);
            return Math.Round(totalSum / Trades, 2);
        }

        public double GetStandardDeviation()
        {
            //標準差定義 : https://goo.gl/QntJ5
            var totalSum = _distributions.Sum(c => c.RMultiple * c.Count);
            var mean = totalSum / Trades;
            var deviationFromMean = _distributions.Sum(c => (c.RMultiple - mean) * (c.RMultiple - mean) * c.Count);
            var SD = Math.Sqrt((double)deviationFromMean / Trades);
            return Math.Round(SD, 2);
        }

        public double GetWinRate()
        {
            double winTimes = _distributions.Sum(c => c.RMultiple > 0 ? c.Count : 0);
            return Math.Round((winTimes / Trades) * 100, 2);
        }

        public double GetWinLossRatio()
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

        public double GetRandomRMultiple(Random rnd)
        {
            //建立群體
            var box = this.DistributionsDetailBox;

            //隨機取一筆
            var rndNumber = rnd.Next(0, box.Count);

            //回傳R
            return box[rndNumber];
        }

        /// <summary>
        /// 解析R分布轉換完整R列表
        /// </summary>
        /// <returns></returns>
        private List<double> ParseDistributionToBox()
        {
            var box = new List<double>();
            foreach (var item in _distributions)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    box.Add(item.RMultiple);
                }
            }
            return box;
        }


        public double GetSQN()
        {
            var tradeSqur = Math.Sqrt(Trades);
            var distributions = _distributions.ToList();
            var count = distributions.Sum(x => x.Count);
            var mean = distributions.Sum(x => x.Count * x.RMultiple) / count;
            var sumDiffPow = 0.0;
            foreach (var item in _distributions)
            {
                var diff = mean - item.RMultiple;
                sumDiffPow += Math.Pow(diff, 2) * item.Count;
            }

            var std = Math.Sqrt(sumDiffPow / count);
            var expectancy = GetExpectancy();

            var sqn = expectancy / std * tradeSqur;
            return sqn;
        }
    }
}