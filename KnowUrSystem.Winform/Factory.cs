using KnowUrSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowUrSystem.Winform
{
    public class Factory
    {
        private static IFinanceCalulator _distributionCalculator;

        internal static IFinanceCalulator GetDistributionInstance(List<DistributionRawData> distributions)
        {
           
             _distributionCalculator = new FinanceCalulator(distributions);

            return _distributionCalculator;
        }
    }
}
