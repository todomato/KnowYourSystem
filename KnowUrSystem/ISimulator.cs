namespace KnowUrSystem
{
    public interface ISimulator
    {
        int TradesPerMonth { get; set; }
        int TimesOfSimulation { get; set; }
        int MaxNumOfConsecutiveLosses { get; set; }
        int AvgNumOfConsecutiveLosses { get; set; }

        void Simulate();
    }
}