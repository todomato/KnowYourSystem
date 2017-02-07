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

        public int AvgNumOfConsecutiveLosses
        {
            get
            {
                var clsByRun = new List<int>();
                var cls = new List<int>();
                foreach (var record in Runs)
                {
                    cls = CalculateConsecutiveLosses(record);
                }

                var result = cls.Average(c => c);
                return (int)Math.Round(result);
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
            Random rnd = new Random();

            for (int i = 0; i < TradesPerMonth; i++)
            {
                var record = new Record();
                _financeCalculator.CalculateTrades();
                _financeCalculator.CalculateWinRate();
                record.IsWinMoney = (rnd.Next(0, 100) >= _financeCalculator.WinRate) ? false : true;
                Records.Add(record);
            }
        }
    }
}