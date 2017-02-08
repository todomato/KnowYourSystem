using System;
namespace KnowUrSystem
{
    public interface IFinanceCalulator
    {
        Decimal GetExpectancy();
        Decimal GetStandardDeviation();
        int GetTrades();
        Decimal GetWinLossRatio();
        Decimal GetWinRate();

    }
}
