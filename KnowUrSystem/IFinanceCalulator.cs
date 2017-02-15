using System;
namespace KnowUrSystem
{
    public interface IFinanceCalulator
    {
        decimal GetExpectancy();
        decimal GetStandardDeviation();
        int GetTrades();
        decimal GetWinLossRatio();
        decimal GetWinRate();
        decimal GetSQN();

        decimal GetRandomRMultiple(Random rnd);
    }
}
