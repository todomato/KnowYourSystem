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
        List<decimal> CumulativeProbabilityConsecutiveLossesList { get; }

        List<decimal> ProbabilityConsecutiveLossesList { get; }

        void Simulate();

        List<int> CalculateConsecutiveLosses(List<Record> Records);

        decimal GetMaxExpectancy();

        decimal GetAvgExpectancy();

        Summary GetSimulateResult(int confidence);


        OptReport SimulateOpt(OptParams _param);

        decimal GetAvgDD();

        decimal GetMaxDD();

        List<decimal> GetDrawdownProbabilityList();
        int GetNumberOfTradesForConfidence(decimal prob);

        List<decimal> GetTradesOfLossDistributionProbabilityList();

        Dictionary<decimal, decimal> GetExpectancyList();
    }
}