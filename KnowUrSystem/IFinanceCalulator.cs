﻿using System;
namespace KnowUrSystem
{
    public interface IFinanceCalulator
    {
        double GetExpectancy();
        double GetStandardDeviation();
        int GetTrades();
        double GetWinLossRatio();
        double GetWinRate();

        double GetRandomRMultiple(Random rnd);
    }
}
