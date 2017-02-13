using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowUrSystem.Model
{
    public class Summary
    {
        public int Trades { get; set; }
        public double WinRatio { get; set; }

        public double WinLossRatio { get; set; }

        public double Expectancy { get; set; }

        public object LossingStreaks { get; set; }

        public double AvgDrawdown { get; set; }

        public int BreakEvenTrades { get; set; }

        public double EndingGain { get; set; }

        public object YearlyGain { get; set; }

        public double GainDrawdownRatio { get; set; }

        public double PeakGain { get; set; }
    }
}
