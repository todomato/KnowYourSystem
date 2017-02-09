using KnowUrSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowUrSystem
{
    public interface IDrawdownCalculator
    {
        double GetMaxDD(IEnumerable<Record> records);
        double GetMaxDD(IEnumerable<IEnumerable<Record>> runs);

        double GetAvgDD(List<List<Record>> Runs);


    }
}
