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
        private decimal _avgDD;
        private IDrawdownCalculator _drawdownCalculator;
        private IFinanceCalulator _financeCalculator;
        private IDistributionCalulator _distributionCalulator;
        private decimal _avgExpectancy;
        private decimal _avgEndGain;
        private decimal _maxEndGain;

        #region 建構子

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

        #endregion 建構子

        #region 屬性

        public int AvgNumWeMeetConsecutiveLosses
        {
            get
            {
                var probability = this.CumulativeProbabilityConsecutiveLossesList;

                //取得接近50%的筆數
                var N = 0;
                var diffProbility = 50.0m;
                for (int i = 0; i <= 99; i++)
                {
                    var temp = probability[i] - 50;
                    if (diffProbility >= Math.Abs(temp) && temp != -50)
                    {
                        N = i + 1;
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

        public int TradesPerYearly { get; set; }

        #endregion 屬性

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
            for (int i = 0; i < TradesPerYearly; i++)
            {
                var record = new Record();

                // 贏輸多少R
                record.RMultiple = _financeCalculator.GetRandomRMultiple(rnd);
                record.IsWinMoney = (record.RMultiple >= 0) ? true : false;
                record.Number = i + 1;
                // 計算算術平均數累計R
                record.CumulativeRMutiple = i == 0 ? record.RMultiple : record.RMultiple + Records[i - 1].CumulativeRMutiple;

                Records.Add(record);
            }
        }

        public List<decimal> CumulativeProbabilityConsecutiveLossesList
        {
            get
            {
                var ClsByRun = GetMaxConsecutiveLossesList();
                ClsByRun.Sort();
                var result = new List<decimal>();
                for (int i = 1; i <= 100; i++)
                {
                    var sum = ClsByRun.Where(x => x >= i).Sum(c => 1);
                    var porbility = sum * 100.0m / ClsByRun.Count;
                    result.Add(porbility);
                }

                return result;
            }
        }

        public List<decimal> ProbabilityConsecutiveLossesList
        {
            get
            {
                var ClsByRun = GetAllConsecutiveLossesList();

                var result = new List<decimal>();
                for (int i = 1; i <= 100; i++)
                {
                    var count = ClsByRun.Where(x => x >= i).Sum(c => 1);
                    var porbility = (decimal)( count * 1.0 / ClsByRun.Count);
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

        public decimal GetMaxDD()
        {
            return _drawdownCalculator.GetMaxDD(Runs);
        }

        public decimal GetAvgDD()
        {
            if (_avgDD == 0)
            {
                this._avgDD = _drawdownCalculator.GetAvgDD(Runs);
            }

            return _avgDD;
        }

        public decimal GetMaxExpectancy()
        {
            var expectancys = CalculateExpectancy();
            return Math.Round(expectancys.Max(m => m), 2);
        }

        public decimal GetAvgExpectancy()
        {
            if (_avgExpectancy == 0)
            {
                var expectancys = CalculateExpectancy();
                this._avgExpectancy = Math.Round(expectancys.Average(m => m), 2);
            }

            return this._avgExpectancy;
        }

        public decimal GetExpectancy(decimal probability)
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
                var porb = count * 1.0m / expectancys.Count;
                var expectModel = new ExpectModel()
                {
                    CumulativeProbability = porb,
                    Expectancy = item.Expectancy
                };
                probabilitys.Add(expectModel);
            }

            //取得接近50%的筆數
            var X = 0;
            var percentage = probability / 100.0m;
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

        private List<decimal> CalculateExpectancy()
        {
            var expectancys = new List<decimal>();
            foreach (var records in Runs)
            {
                var expect = records.Sum(x => x.RMultiple) / records.Count;
                expectancys.Add(expect);
            }
            return expectancys;
        }

        public int GetNumberOfTradesForConfidence(decimal prob)
        {
            var distributions = _distributionCalulator.CalculateLossDistributionProbability(Runs);

            //取得接近信心X%的筆數
            var N = 0;
            var probability = 1 - prob / 100.0m; //轉成失敗率
            var diffProbility = probability;
            for (int i = 0; i < distributions.Count; i++)
            {
                var temp = distributions[i] - probability;
                if (diffProbility >= Math.Abs(temp) && temp != probability * -1)
                {
                    N = i;
                    diffProbility = temp;
                };
            }
            return N + 1;
        }

        public decimal GetAvgEndGain()
        {
            if (_avgEndGain == 0)
            {
                var endGains = new List<decimal>();
                foreach (var records in Runs)
                {
                    endGains.Add(records.Last().CumulativeRMutiple);
                }

                this._avgEndGain = endGains.Average();
            }

            return _avgEndGain;
        }

        public decimal GetMaxEndGain()
        {
            if (_maxEndGain == 0)
            {
                var endGains = new List<decimal>();
                foreach (var records in Runs)
                {
                    endGains.Add(records.Last().CumulativeRMutiple);
                }

                this._maxEndGain = endGains.Max();
            }

            return _maxEndGain;
        }

        public Summary GetSimulateResult(int confidence = 95)
        {
            var result = new Summary();
            result.Trades = this.TradesPerYearly;
            result.WinLossRatio = _financeCalculator.GetWinLossRatio();
            result.Expectancy = this.GetAvgExpectancy();
            //TODO
            //result.WinRatio = GetSystemWinRatio();    //可能是達成目標的機率

            result.LossingStreaks = this.AvgNumWeMeetConsecutiveLosses;
            result.AvgDrawdown = this.GetAvgDD();
            //TODO
            result.PeakGain = 0.0m;
            result.EndingGain = this.GetAvgEndGain();
            result.BreakEvenTrades = GetNumberOfTradesForConfidence(confidence);
            result.GainDrawdownRatio = Math.Abs(result.EndingGain / result.AvgDrawdown);
            result.YearlyGain = this.TradesPerYearly * _financeCalculator.GetExpectancy();

            return result;
        }

        public OptReport SimulateOpt(OptParams param)
        {
            //模擬系統參數
            this.Simulate();

            //模擬增幅部位
            var reports = new List<OptResult>();
            for (decimal position = param.IncrementSize; position < param.MaxRisk; position += param.IncrementSize)
            {
                OptResult allprob = GetAllProbability(this.Runs, param, position);
                reports.Add(allprob);
            }

            //計算Opt結果
            var optReport = new OptReport();
            optReport.MaxReturn = reports.Where(c => c.MaxGain == reports.Max(x => x.MaxGain)).FirstOrDefault();

            optReport.MedReturn = reports.Where(c => c.MedGain == reports.Max(x => x.MedGain)).FirstOrDefault();

            optReport.OptReturn = reports.Where(c => c.RetireProbability == reports.Max(x => x.RetireProbability)).FirstOrDefault();

            optReport.LessOneRuin = reports.Where(c => c.RuinProbability <= 0.01).OrderByDescending(c => c.RuinProbability).FirstOrDefault();

            optReport.BestRetireRuinRatio = reports
                .Where(c => (double)c.RetireProbability - c.RuinProbability
                    == reports.Max(x => (double)x.RetireProbability - x.RuinProbability))
                .FirstOrDefault();

            return optReport;
        }

        private OptResult GetAllProbability(List<List<Record>> runs, OptParams param, decimal position)
        {
            //過濾Data ruin後的資料不算
            var newRuns = FilterRuin(runs, param, position/100);
            //var newRuns = runs; //不停損

            //運算
            var result = new OptResult();
            result.BetSize = position;
            var ruinCount = 0;
            var arriveCount = 0;
            var endGains = new List<decimal>();
            var maxGain = 0.0m;
            var retirementGoal = param.InitEquity * (1 + param.Retirement / 100);
            var ruinGoal = param.InitEquity * (1 + param.Ruin / 100);
            foreach (var records in newRuns)
            {
                var endGain = records.Where(c => c.Number == records.Max(j => j.Number)).Single().CurrentEquity;
                endGains.Add(endGain);
                
                //有達到retire目標 & 剔除ruin
                if (endGain >= retirementGoal)
                {
                    arriveCount++;
                }

                //有達到ruin
                if (endGain <= ruinGoal)
                {
                    ruinCount++;
                    continue;
                }

                //判斷最大值
                if (maxGain < endGain)
                {
                    maxGain = endGain;
                }

            }

            //機率
            result.RetireProbability = (decimal)arriveCount / newRuns.Count;
            result.RuinProbability = (double)ruinCount / newRuns.Count;
            result.AvgGain = (endGains.Average() - param.InitEquity)  / param.InitEquity;
            result.MaxGain = (maxGain- param.InitEquity) / param.InitEquity;
            endGains.Sort();
            result.MedGain = (endGains[newRuns.Count / 2 - 1] - param.InitEquity) / param.InitEquity;

            return result;
        }

        private List<List<Record>> FilterRuin(List<List<Record>> runs, OptParams param, decimal position)
        {
            var ruinGoal = param.InitEquity *(1 + param.Ruin/100);
            var result = new List<List<Record>>();

            //過濾ruin資料
            //計算淨值
            foreach (var records in runs)
            {
                var containers = new List<Record>();
                int i = 0;
                foreach (var record in records)
                {
                    if (i == 0)
                    {
                        record.CurrentEquity = param.InitEquity * (1 + position * record.RMultiple);
                    }
                    else
                    {
                        record.CurrentEquity = 
                            records[i - 1].CurrentEquity * (1 + position * record.RMultiple);
                    }


                    //ruin
                    if (record.CurrentEquity <= ruinGoal)
                    {
                        containers.Add(record);
                        break;
                    }
                    containers.Add(record);
                    i++;
                }
                result.Add(containers);
            }
            return result;
        }
    }
}