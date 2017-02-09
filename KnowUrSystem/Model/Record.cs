﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowUrSystem.Model
{
    public class Record
    {
        public int Number { get; set; }

        public double CumulativeRMutiple { get; set; }

        public bool IsWinMoney { get; set; }

        public double RMultiple { get; set; }

        public bool IsThroughNewPeak { get; set; }
    }
}
