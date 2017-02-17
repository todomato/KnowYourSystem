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
        private static ISimulator _simulator;


        internal static IFinanceCalulator GetDistributionInstance(List<DistributionRawData> distributions)
        {
           
             _distributionCalculator = new FinanceCalulator(distributions);
            return _distributionCalculator;
        }

        internal static ISimulator GetSimulator(IFinanceCalulator _distributionCalculator)
        {

            _simulator = new Simulator(_distributionCalculator);
            return _simulator;
        }
    }
}
