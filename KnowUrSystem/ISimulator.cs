using KnowUrSystem.Model;
using System;
using System.Collections.Generic;

namespace KnowUrSystem
{
    public interface ISimulator
    {

        List<List<Record>> Runs { get; set; }

        int TradesPerMonth { get; set; }

        int TimesOfSimulation { get; set; }

        int MaxNumOfConsecutiveLosses { get; }
        int AvgNumOfConsecutiveLosses { get;  }

        void Simulate();

        List<int> CalculateConsecutiveLosses(List<Record> Records);
    }
}