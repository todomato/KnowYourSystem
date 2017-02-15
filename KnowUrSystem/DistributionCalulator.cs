using KnowUrSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KnowUrSystem
{
    public class DistributionCalulator : IDistributionCalulator
    {
        private int _simulateTimes;
        private int _trades;

        public DistributionCalulator()
        {
        }

        public DistributionCalulator(int times, int trades)
        {
            this._simulateTimes = times;
            this._trades = trades;
        }

        public List<decimal> CalculateLossDistributionProbability(List<List<Record>> runs)
        {
            //計算N筆交易累積R倍數賠的佔模擬次數的比例
            var probabilitys = new List<decimal>();
            var trades = runs.Select(x => x.Count).First();
            int simulateCount = runs.Count;

            for (int i = 0; i < trades; i++)
            {
                var lossbox = 0;
                foreach (var records in runs)
                {
                    //if (records[i].CumulativeRMutiple < 0 &&
                    //    records[i].IsThroughNewPeak == false)
                    if (records[i].CumulativeRMutiple < 0 )
                    {
                        lossbox++;
                    }
                }

                var lossProb = (decimal)lossbox / simulateCount;
                probabilitys.Add(lossProb);
            }

            return probabilitys;
        }

     
    }
}