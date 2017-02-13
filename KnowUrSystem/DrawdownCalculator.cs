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
                //TODO check 平均下跌 是否是用最大下跌的平均
                var result = GetMaxDD(record);
                DDByRun.Add(result);
            }

            var avg = DDByRun.Average(x => x);
            return avg;

            ////累計機率
            //var probability = CalculateCumulativeProbabilityOfDD(DDByRun);
            ////單獨運算DD機率 
            ////var probability = CalculateProbabilityOfDD(DDByRun);

            ////取得接近50%的筆數
            //var R = 0;
            //var diffProbility = 50.0;
            //for (int i = 0; i <= 99; i++)
            //{
            //    var temp = probability[i] - 50;
            //    if (diffProbility >= Math.Abs(temp) && temp != -50)
            //    {
            //        R = i + 1;
            //        diffProbility = temp;
            //    };
            //}
            //return R * -1;
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
