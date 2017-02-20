using KnowUrSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowUrSystem
{
    public interface IDrawdownCalculator
    {
        decimal GetMaxDD(IEnumerable<Record> records);
        decimal GetMaxDD(IEnumerable<IEnumerable<Record>> runs);

        decimal GetAvgDD(List<List<Record>> runs);

        List<decimal> GetDrawdownProbabilityList(IEnumerable<IEnumerable<Record>> runs);

    }
}
