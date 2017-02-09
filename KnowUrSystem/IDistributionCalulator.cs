using KnowUrSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowUrSystem
{
    public interface IDistributionCalulator
    {

        List<double> CalculateLossDistributionProbability(List<List<Record>> Runs);

    }
}
