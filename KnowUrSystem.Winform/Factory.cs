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
        private static IDrawdownCalculator _drawdownCalculator;
        private static IDistributionCalulator _distributionCalulator;


        internal static IFinanceCalulator GetDistributionInstance(List<DistributionRawData> distributions)
        {
           
             _distributionCalculator = new FinanceCalulator(distributions);
            return _distributionCalculator;
        }

        internal static ISimulator GetSimulator(IFinanceCalulator _distributionCalculator)
        {
            _drawdownCalculator = new DrawdownCalculator();
            _distributionCalulator = new DistributionCalulator();
            _simulator = new Simulator(_distributionCalculator, _drawdownCalculator, _distributionCalulator);
            return _simulator;
        }
    }
}
