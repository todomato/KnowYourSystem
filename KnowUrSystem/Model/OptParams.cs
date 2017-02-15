using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowUrSystem.Model
{
    public class OptParams
    {

        public decimal MaxRisk { get; set; }

        public decimal Ruin { get; set; }

        public decimal Retirement { get; set; }

        public int InitEquity { get; set; }

        public decimal IncrementSize { get; set; }
    }
}
