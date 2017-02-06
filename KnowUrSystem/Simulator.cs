using KnowUrSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KnowUrSystem
{
    public class Simulator : ISimulator
    {
        public Simulator()
        {
        }

        public Simulator(FinanceCalulator fc)
        {
            _financeCalculator = fc;
        }

        public void Simulate()
        {
            SimulatOnce();
        }

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

        public int TradesPerMonth { get; set; }

        private int _timesOfSimulation;

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

        public int MaxNumOfConsecutiveLosses
        {
            get
            {
                List<int> cls = CalculateConsecutiveLosses(Records);
                var result = cls.Max(c => c);
                return result;
            }
        }

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

            return result;
        }

        public int AvgNumOfConsecutiveLosses
        {
            get
            {
                List<int> cls = CalculateConsecutiveLosses(Records);
                if (cls.Count > 0)
                {
                    var result = cls.Average(c => c);
                    return (int)Math.Round(result);
                }
                else
                {
                    return 0;
                }
            }
        }

        private List<Record> _records;

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

        private List<List<Record>> _runs;
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

        private FinanceCalulator _financeCalculator { get; set; }
    }
}