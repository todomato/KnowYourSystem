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
        public double RetireProbability { get; set; }
        public double RuinProbability { get; set; }
        public double AvgGain { get; set; }
        public double MedGain { get; set; }
        public double BetSize { get; set; }

    }
}
