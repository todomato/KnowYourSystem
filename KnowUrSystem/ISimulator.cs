using KnowUrSystem.Model;
using System;
using System.Collections.Generic;

namespace KnowUrSystem
{
    public interface ISimulator
    {

        List<List<Record>> Runs { get; set; }

        int TradesPerYearly { get; set; }

        int TimesOfSimulation { get; set; }

        int MaxNumOfConsecutiveLosses { get; }
        int AvgNumWeMeetConsecutiveLosses { get;  }
        List<double> CumulativeProbabilityConsecutiveLossesList { get; }

        List<double> ProbabilityConsecutiveLossesList { get; }

        void Simulate();

        List<int> CalculateConsecutiveLosses(List<Record> Records);

        double GetMaxExpectancy();

        double GetAvgExpectancy();

        Summary GetSimulateResult(int confidence);

    }
}