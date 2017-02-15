using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowUrSystem.Model
{
    public class OptReport
    {
        public OptResult MaxReturn { get; set; }
        public OptResult MedReturn { get; set; }

        public OptResult OptReturn { get; set; }

        public OptResult LessOneRuin { get; set; }

        public OptResult BestRetireRuinRatio { get; set; }

    }

    public class OptResult
    {
        public decimal RetireProbability { get; set; }
        public double RuinProbability { get; set; }
        public decimal AvgGain { get; set; }
        public decimal MaxGain { get; set; }
        public decimal MedGain { get; set; }
        public decimal BetSize { get; set; }

    }
}
