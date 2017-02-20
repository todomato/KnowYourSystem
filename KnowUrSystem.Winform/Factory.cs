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


        internal static IFinanceCalulator GetDistributionInstance(List<DistributionRawData> distributions)
        {
           
             _distributionCalculator = new FinanceCalulator(distributions);
            return _distributionCalculator;
        }

        internal static ISimulator GetSimulator(IFinanceCalulator _distributionCalculator)
        {
            _drawdownCalculator = new DrawdownCalculator();
            _simulator = new Simulator(_distributionCalculator, _drawdownCalculator);
            return _simulator;
        }
    }
}
