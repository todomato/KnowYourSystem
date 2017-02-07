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

        public Simulator()
        {
        }

        public Simulator(FinanceCalulator fc)
        {
            _financeCalculator = fc;
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
                if (_timesOfSimulation > 10000)
                {
                    return 10000;
                }
                return _timesOfSimulation;
            }
            set
            {
                _timesOfSimulation = value;
            }
        }

        public int TradesPerMonth { get; set; }

        private FinanceCalulator _financeCalculator { get; set; }

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
                _financeCalculator.CalculateTrades();
                _financeCalculator.CalculateWinRate();
                record.IsWinMoney = (rnd.Next(0, 100) >= _financeCalculator.WinRate) ? false : true;
                Records.Add(record);
            }
        }

        public List<double> CumulativeProbabilityConsecutiveLossesList
        {
            get
            {
                var ClsByRun = GetConsecutiveLossesList();

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
                //TODO

                var ClsByRun = GetConsecutiveLossesList();

                var result = new List<double>();
                for (int i = 1; i <= 100; i++)
                {
                    var count = ClsByRun.Where(x => x == i).Sum(c => 1);
                    var porbility = count / 100;
                    result.Add(porbility);
                }

                return result;
            }
        }

        private List<int> GetConsecutiveLossesList()
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
    }
}