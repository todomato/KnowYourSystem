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
        private List<decimal> _rMutipleDetailBox;
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
        private List<decimal> DistributionsDetailBox
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

        public decimal GetExpectancy()
        {
            var totalSum = _distributions.Sum(c => c.RMultiple * c.Count);
            return Math.Round(totalSum / Trades, 2);
        }

        public decimal GetStandardDeviation()
        {
            //標準差定義 : https://goo.gl/QntJ5
            var totalSum = _distributions.Sum(c => c.RMultiple * c.Count);
            var mean = totalSum / Trades;
            var deviationFromMean = _distributions.Sum(c => (c.RMultiple - mean) * (c.RMultiple - mean) * c.Count);
            var SD = Math.Sqrt((double)deviationFromMean / Trades);
            return (decimal)Math.Round(SD, 2);
        }

        public decimal GetWinRate()
        {
            decimal winTimes = _distributions.Sum(c => c.RMultiple > 0 ? c.Count : 0);
            return Math.Round((winTimes / Trades) * 100, 2);
        }

        public decimal GetWinLossRatio()
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

        public decimal GetRandomRMultiple(Random rnd)
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
        private List<decimal> ParseDistributionToBox()
        {
            var box = new List<decimal>();
            foreach (var item in _distributions)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    box.Add(item.RMultiple);
                }
            }
            return box;
        }


        public decimal GetSQN()
        {
            var tradeSqur = (decimal)Math.Sqrt(Trades);
            var distributions = _distributions.ToList();
            var count = distributions.Sum(x => x.Count);
            var mean = distributions.Sum(x => x.Count * x.RMultiple) / count;
            var sumDiffPow = 0.0;
            foreach (var item in _distributions)
            {
                var diff = mean - item.RMultiple;
                sumDiffPow += Math.Pow((double)diff, 2) * item.Count;
            }

            var std = (decimal)Math.Sqrt(sumDiffPow / count);
            var expectancy = GetExpectancy();

            var sqn = (expectancy / std * tradeSqur);
            return sqn;
        }
    }
}