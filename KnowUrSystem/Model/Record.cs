using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowUrSystem.Model
{
    public class Record
    {
        public int Run { get; set; }
        public int Number { get; set; }

        public decimal CumulativeRMutiple { get; set; }

        public bool IsWinMoney { get; set; }

        public decimal RMultiple { get; set; }

        public decimal CurrentEquity { get; set; }

    }
}
