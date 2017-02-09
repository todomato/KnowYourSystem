using KnowUrSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowUrSystem
{
    public class DrawdownCalculator : IDrawdownCalculator
    {

        public double GetMaxDD(IEnumerable<Record> records)
        {
            var drawdowns = CalculateDrawdown(records);
            var result = drawdowns.Max(c => c);
            return result * -1;
        }

        public double GetMaxDD(IEnumerable<IEnumerable<Record>> runs)
        {
            var maxDDByRun = new List<double>();
            foreach (var record in runs)
            {
                maxDDByRun.Add(GetMaxDD(record));
            }
            return maxDDByRun.Min(c => c);
        }

        public double GetAvgDD(List<List<Record>> runs)
        {
            var DDByRun = new List<double>();
            foreach (var record in runs)
            {
                var result = GetMaxDD(record);
                DDByRun.Add(result);
            }

            //累計機率
            var probability = CalculateCumulativeProbabilityOfDD(DDByRun);
            //單獨運算DD機率
            //var probability = CalculateProbabilityOfDD(DDByRun);

            //取得接近50%的筆數
            var R = 0;
            var diffProbility = 50.0;
            for (int i = 0; i <= 99; i++)
            {
                var temp = probability[i] - 50;
                if (diffProbility >= Math.Abs(temp) && temp != -50)
                {
                    R = i + 1;
                    diffProbility = temp;
                };
            }
            return R * -1;
        }


        public List<double> CalculteCumulativeRmutiple(List<Record> records)
        {
            var result = new List<double>();
            var length = records.Count;


            // 出現交易沒有創新高的機率
            var currentR = 0.0; //目前位置
            for (int i = 0; i < length; i++)
            {
                //現況
                currentR += records[i].RMultiple;
                result.Add(currentR);
            }

            return result;
        }

        public int GetNumberThroughNewPeak(List<List<Record>> runs, double confidence)
        {
            //計算N筆交易累積R倍數賠的佔模擬次數的比例
            var probabilitys = new List<double>();
            var trades = runs.Select(x => x.Count).First();
            int simulateCount = runs.Count;

            for (int i = 0; i < trades; i++)
            {
                var lossbox = 0;
                foreach (var records in runs)
                {
                    if (records[i].CumulativeRMutiple < 0 && 
                        records[i].IsThroughNewPeak == false)
	                {
                        lossbox++;
	                }
                    
                }

                var lossProb = (double)lossbox / simulateCount;
                probabilitys.Add(1-lossProb);
            }

            //取得特定信心程度%創新高的次數
            var N = 0;
            var diffProbility = confidence;
            for (int i = 0; i <= trades; i++)
            {
                var temp = probabilitys[i] * 100 ;
                if (diffProbility >= Math.Abs(temp))
                {
                    N = i + 1;
                };
            }
            return N;
        }



        /// <summary>
        /// 計算DD累計機率
        /// </summary>
        /// <param name="DDByRun"></param>
        /// <returns></returns>
        private static List<double> CalculateCumulativeProbabilityOfDD(List<double> DDByRun)
        {
            var result = new List<double>();
            for (int i = 0; i >= -120; i--)
            {
                var sum = DDByRun.Where(x => x <= i).Sum(c => 1);
                var porbility = sum * 100.0 / DDByRun.Count;
                result.Add(porbility);
            }
            return result;
        }

        /// <summary>
        /// 計算DD單次機率
        /// </summary>
        /// <param name="DDByRun"></param>
        /// <returns></returns>
        private static List<double> CalculateProbabilityOfDD(List<double> DDByRun)
        {
            var result = new List<double>();
            for (int i = 0; i >= -120; i--)
            {
                var sum = DDByRun.Where(x => x == i).Sum(c => 1);
                var porbility = sum * 100.0 / DDByRun.Count;
                result.Add(porbility);
            }
            return result;
        }

        /// <summary>
        /// 計算最高點下跌的距離陣列
        /// </summary>
        /// <param name="Records"></param>
        /// <returns></returns>
        private List<double> CalculateDrawdown(IEnumerable<Record> records)
        {
            var result = new List<double>();
            var currentR = 0.0;
            var high = 0.0;
            var drawdown = 0.0;

            foreach (var item in records)
            {
                //紀錄當前位置
                currentR += item.RMultiple;

                //判斷高點
                if (high <= currentR)
                {
                    //過前高
                    high = currentR;
                    if (drawdown != 0.0)
                    {
                        result.Add(drawdown);
                        drawdown = 0.0;
                    }
                }

                //判斷下降距離
                if (drawdown < high - currentR)
                {
                     //過前低
                    drawdown = high - currentR;
                }
               
            }

            if (drawdown != 0.0)
            {
                result.Add(drawdown);
            }

            //防呆
            if (result.Count == 0)
            {
                result.Add(0.0);
            }

            return result;
        }















 
    }
}
