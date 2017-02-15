using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowUrSystem.Model
{
    public class Summary
    {
        public int Trades { get; set; }
        public decimal WinRatio { get; set; }

        public decimal WinLossRatio { get; set; }

        public decimal Expectancy { get; set; }

        public int LossingStreaks { get; set; }

        public decimal AvgDrawdown { get; set; }

        public int BreakEvenTrades { get; set; }

        public decimal EndingGain { get; set; }

        public decimal YearlyGain { get; set; }

        public decimal GainDrawdownRatio { get; set; }

        public decimal PeakGain { get; set; }
    }
}
