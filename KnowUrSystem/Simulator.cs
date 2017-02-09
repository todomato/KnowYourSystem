using KnowUrSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KnowUrSystem
{
    public class Simulator : ISimulator
    {
        private List<Record> _records;

        private List<List<Record>> _runs;

        private int _timesOfSimulation;
        private IDrawdownCalculator _drawdownCalculator;
        private IFinanceCalulator _financeCalculator;
        private IDistributionCalulator _distributionCalulator;


        public Simulator()
        {
        }

        public Simulator(IFinanceCalulator fc)
        {
            _financeCalculator = fc;
        }

        public Simulator(IFinanceCalulator fc, IDrawdownCalculator dd)
        {
            _financeCalculator = fc;
            _drawdownCalculator = dd;
        }

        public Simulator(IFinanceCalulator fc, IDrawdownCalculator dd, IDistributionCalulator d)
        {
            _financeCalculator = fc;
            _drawdownCalculator = dd;
            _distributionCalulator = d;
            
        }

        public int AvgNumWeMeetConsecutiveLosses
        {
            get
            {
                var probability = this.CumulativeProbabilityConsecutiveLossesList;

                //取得接近50%的筆數
                var N = 0;
                var diffProbility = 50.0;
                for (int i = 0; i <= 99; i++)
                {
                    var temp = probability[i] - 50;
                    if (diffProbility >= Math.Abs(temp) && temp != -50)
                    {
                        N = i+1;
                        diffProbility = temp;
                    };
                }
                return N;
            }
        }

        public int MaxNumOfConsecutiveLosses
        {
            get
            {
                var clsByRun = new List<int>();
                foreach (var record in Runs)
                {
                    var cls = CalculateConsecutiveLosses(record);
                    var maxCls = cls.Max(c => c);
                    clsByRun.Add(maxCls);
                }

                return clsByRun.Max(c => c);
            }
        }

        public List<Record> Records
        {
            get
            {
                if (_records == null) _records = new List<Record>();
                return _records;
            }
            set
            {
                _records = value;
            }
        }

        public List<List<Record>> Runs
        {
            get
            {
                if (_runs == null) _runs = new List<List<Record>>();
                return _runs;
            }
            set
            {
                _runs = value;
            }
        }

        public int TimesOfSimulation
        {
            get
            {
                //if (_timesOfSimulation < 2500)
                //{
                //    return 2500;
                //}
                //else
                if (_timesOfSimulation > 100000)
                {
                    return 100000;
                }
                return _timesOfSimulation;
            }
            set
            {
                _timesOfSimulation = value;
            }
        }

        public int TradesPerMonth { get; set; }


        /// <summary>
        /// 計算連續虧損次數陣列
        /// </summary>
        /// <param name="Records"></param>
        /// <returns></returns>
        public List<int> CalculateConsecutiveLosses(List<Record> Records)
        {
            var result = new List<int>();
            var currentCounts = 0;

            foreach (var item in Records)
            {
                if (item.IsWinMoney == true && currentCounts != 0)
                {
                    result.Add(currentCounts);
                    currentCounts = 0;
                }
                else if (item.IsWinMoney == false)
                {
                    currentCounts++;
                }
            }

            if (currentCounts != 0)
            {
                result.Add(currentCounts);
            }

            //防呆
            if (result.Count == 0)
            {
                result.Add(0);
            }

            return result;
        }

        /// <summary>
        /// 模擬系統
        /// </summary>
        public void Simulate()
        {
            for (int i = 0; i < TimesOfSimulation; i++)
            {
                SimulatOnce();
                //將紀錄存為一輪
                Runs.Add(Records);
                //清除紀錄
                Records = new List<Record>();
            }
        }

        /// <summary>
        /// 執行模擬
        /// </summary>
        private void SimulatOnce()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < TradesPerMonth; i++)
            {
                var record = new Record();

                // 贏輸多少R
                record.RMultiple = _financeCalculator.GetRandomRMultiple(rnd);
                record.IsWinMoney = (record.RMultiple >= 0) ? true : false;
                record.Number = i+1;
                // 計算累計R
                record.CumulativeRMutiple = i == 0 ? record.RMultiple : record.RMultiple + Records[i - 1].CumulativeRMutiple;

                Records.Add(record);
            }
        }

        public List<double> CumulativeProbabilityConsecutiveLossesList
        {
            get
            {
                var ClsByRun = GetMaxConsecutiveLossesList();

                var result = new List<double>();
                for (int i = 1; i <= 100; i++)
                {
                    var sum = ClsByRun.Where(x => x >= i).Sum(c => 1);
                    var porbility = sum * 100.0 / ClsByRun.Count;
                    result.Add(porbility);
                }

                return result;
            }
        }


        public List<double> ProbabilityConsecutiveLossesList
        {
            get
            {
                var ClsByRun = GetAllConsecutiveLossesList();

                var result = new List<double>();
                for (int i = 1; i <= 100; i++)
                {
                    var count = ClsByRun.Where(x => x >= i).Sum(c => 1);
                    var porbility = count * 1.0 / ClsByRun.Count;
                    result.Add(porbility);
                }

                return result;
            }
        }

        private List<int> GetMaxConsecutiveLossesList()
        {
            var ClsByRun = new List<int>();
            foreach (var record in Runs)
            {
                var cls = CalculateConsecutiveLosses(record);
                var maxCls = cls.Max(c => c);
                ClsByRun.Add(maxCls);
                //foreach (var item in cls)
                //{
                //    ClsByRun.Add(item);
                //}
            }

            return ClsByRun;
        }

        private List<int> GetAllConsecutiveLossesList()
        {
            var ClsByRun = new List<int>();
            foreach (var record in Runs)
            {
                var cls = CalculateConsecutiveLosses(record);
                foreach (var item in cls)
                {
                    ClsByRun.Add(item);
                }
            }

            return ClsByRun;
        }


        public double GetMaxDD()
        {
            return _drawdownCalculator.GetMaxDD(Runs);
        }

        public double GetAvgDD()
        {
            return _drawdownCalculator.GetAvgDD(Runs);
        }


        public double GetMaxExpectancy()
        {
            var expectancys = CalculateExpectancy();
            return Math.Round(expectancys.Max(m => m),2);
        }

     

        public double GetAvgExpectancy()
        {
            var expectancys = CalculateExpectancy();
            return Math.Round(expectancys.Average(m => m), 2);

        }

        public double GetExpectancy(double probability)
        {
            var expectancys = CalculateExpectancy();
            var grouped = expectancys.GroupBy(x => x, (x, g) =>
                new ExpectModel { Expectancy = x, Count = g.Count() })
                .OrderBy(c => c.Expectancy)
                .ToList();

            //probability
            var probabilitys = new List<ExpectModel>();
            foreach (var item in grouped)
            {
                var count = grouped.Where(x => x.Expectancy >= item.Expectancy)
                    .Sum(c => c.Count);
                var porb = count * 1.0 / expectancys.Count;
                var expectModel = new ExpectModel()
                {
                    CumulativeProbability = porb,
                    Expectancy = item.Expectancy
                };
                probabilitys.Add(expectModel);
            }

            //取得接近50%的筆數
            var X = 0;
            var percentage = probability/100.0;
            var diffProbility = percentage;
            for (int i = 0; i < probabilitys.Count; i++)
            {
                var temp = probabilitys[i].CumulativeProbability - percentage;
                if (diffProbility >= Math.Abs(temp) && temp > 0)
                {
                    X = i + 1;
                    diffProbility = temp;
                };
            }

            return probabilitys[X].Expectancy;

        }

        private List<double> CalculateExpectancy()
        {
            var expectancys = new List<double>();
            foreach (var records in Runs)
            {
                var expect = records.Sum(x => x.RMultiple) / records.Count;
                expectancys.Add(expect);
            }
            return expectancys;
        }

        public int GetNumberOfTradesForConfidence(double prob)
        {
            var distributions = _distributionCalulator.CalculateLossDistributionProbability(Runs);

            //取得接近信心X%的筆數
            var N = 0;
            var probability = 1 - prob / 100.0; //轉成失敗率
            var diffProbility = probability;
            for (int i = 0; i < distributions.Count; i++)
            {
                var temp = distributions[i] - probability;
                if (diffProbility >= Math.Abs(temp) && temp != probability*-1)
                {
                    N = i;
                    diffProbility = temp;
                };
            }
            return N + 1;
        }
    }
}