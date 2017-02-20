using KnowUrSystem.Model;
using KnowUrSystem.Winform.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;

namespace KnowUrSystem.Winform
{
    public partial class Form1 : Form
    {
        private IFinanceCalulator _financeCalulator;
        private ISimulator _simulator;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            var distributions = new List<DistributionRawData>();

            // 加入分佈
            for (int i = 1; i <= 9; i++)
            {
                TextBox txtBox = this.tab_distribution.Controls["txt_c" + i.ToString()] as TextBox;
                TextBox txtBox2 = this.tab_distribution.Controls["txt_r" + i.ToString()] as TextBox;
                int num1 = 0;
                decimal num2 = 0.0m;

                if (int.TryParse(txtBox.Text, out num1) && decimal.TryParse(txtBox2.Text, out num2))
                {
                    distributions.Add(new DistributionRawData() { Count = num1, RMultiple = num2 });
                }
            }

            SetChart(distributions);

            // 取得計算機
            this._financeCalulator = Factory.GetDistributionInstance(distributions);

            // 試算Trade Distribution結果
            lbl_expectancy.Text = _financeCalulator.GetExpectancy().ToString();
            lbl_std.Text = _financeCalulator.GetStandardDeviation().ToString();
            lbl_win.Text = _financeCalulator.GetWinRate().ToString();
            lbl_winlossRatio.Text = _financeCalulator.GetWinLossRatio().ToString();
            lbl_trades.Text = _financeCalulator.GetTrades().ToString();
            lbl_sqn.Text = Math.Round(_financeCalulator.GetSQN(), 2).ToString();

            // 建立模擬器  TODO 放到模擬頁面,參數也需要更換
            this._simulator = Factory.GetSimulator(this._financeCalulator);
            _simulator.TimesOfSimulation = 10000;
            _simulator.TradesPerYearly = 120;
            this._simulator.Simulate();

            // 更新Loosing Streaks 
            this.lbl_avgconsecutivelosses.Text = this._simulator.AvgNumWeMeetConsecutiveLosses.ToString();
            this.lbl_maxconsecutivelosses.Text = this._simulator.MaxNumOfConsecutiveLosses.ToString();
            var probabilityConsecutiveLossesList = this._simulator.CumulativeProbabilityConsecutiveLossesList;
            SetCLChart(probabilityConsecutiveLossesList);
            SetLSListview(probabilityConsecutiveLossesList);

            // Drawdown Depth
            this.lbl_avgDrawdown.Text = Math.Round(this._simulator.GetAvgDD(), 2).ToString();
            this.lbl_MaxDrawdown.Text = Math.Round(this._simulator.GetMaxDD(), 0).ToString();
            // 更新 Drawdown Depth
            var ddList = this._simulator.GetDrawdownProbabilityList();
            SetDDChart(ddList);
            SetDDListview(ddList);


            // 95%信心程度 創equity新高的交易次數
            this.lbl_99confidence.Text = this._simulator.GetNumberOfTradesForConfidence(99).ToString();
            this.lbl_95confidence.Text = this._simulator.GetNumberOfTradesForConfidence(95).ToString();
            var ddurationList = this._simulator.GetTradesOfLossDistributionProbabilityList();

            SetDurationChart(ddurationList);
            SetDDurationListview(ddurationList);

        }


        #region Trade Distribution
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }

        private void btn_example_Click(object sender, EventArgs e)
        {
            txt_c1.Text = "2";
            txt_c2.Text = "1";
            txt_c3.Text = "7";

            txt_r1.Text = "10.00";
            txt_r2.Text = "-5.00";
            txt_r3.Text = "-1.00";
        }



        private void SetChart(List<DistributionRawData> distributions)
        {
            //設定 Chart
            Chart1.BackColor = System.Drawing.Color.Gray;

            Title title = new Title();
            title.Text = "Trade Distributin";
            title.Alignment = ContentAlignment.MiddleCenter;
            title.Font = new System.Drawing.Font("Trebuchet MS", 11F, FontStyle.Bold);
            if (Chart1.Titles.Count == 0)
            {
                Chart1.Titles.Add(title);
            }


            Chart1.Series[0].Points.Clear();

            distributions = distributions.OrderBy(c => c.RMultiple).ToList();

            string[] titleArr = { "R 分佈" };
            //Data Y
            int[] yValues = distributions.Select(x => x.Count).ToArray();

            //Data 對應X座標
            List<double> xValue = distributions.Select(x => (double)x.RMultiple).ToList();


            //設定 ChartArea----------------------------------------------------------------------

            //-----------------------------設定3D------------------------------//
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = false; //3D效果
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.IsClustered = true; //並排顯示
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Rotation = 40; //垂直角度
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Inclination = 50; //水平角度
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.PointDepth = 2; //數據條厚度
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.WallWidth = 0; //外牆寬度
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.LightStyle = LightStyle.Realistic; //光源
            //-----------------------------設定3D------------------------------//

            Chart1.ChartAreas["ChartArea1"].BackColor = Color.FromArgb(64, 64, 64); //背景色
            Chart1.ChartAreas["ChartArea1"].AxisX.Enabled = AxisEnabled.True;
            Chart1.ChartAreas["ChartArea1"].AxisX2.Enabled = AxisEnabled.False; //隱藏 X2 標示
            Chart1.ChartAreas["ChartArea1"].AxisY2.Enabled = AxisEnabled.False; //隱藏 Y2 標示
            Chart1.ChartAreas["ChartArea1"].AxisY2.MajorGrid.Enabled = false;   //隱藏 Y2 軸線
            Chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(150, 150, 150);//X 軸線顏色
            Chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(150, 150, 150);//Y 軸線顏色


            Chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "#.##";//設定小數點

            //設定 Series-----------------------------------------------------------------------
            //Chart1.Series["Series1"].ChartType = SeriesChartType.Line; //直條圖(Column),折線圖(Line),橫條圖(Bar)
            //Chart1.Series["Series2"].ChartType = SeriesChartType.Line; //直條圖(Column),折線圖(Line),橫條圖(Bar)
            //Chart1.Series["Series1"].ChartType = SeriesChartType.Bar; //橫條圖

            Chart1.Series["Series1"].Points.DataBindXY(xValue, yValues);//Series1的XY數值放入圖中
            Chart1.Series["Series1"]["PixelPointWidth"] = "5";


            //remove legend labels
            Chart1.Series[0].IsVisibleInLegend = false;
            Chart1.ChartAreas[0].AxisX.Interval = 2;   //設置X軸坐標的間隔為1
            Chart1.ChartAreas[0].AxisX.IntervalOffset = 1;  //設置X軸坐標偏移為1
            Chart1.ChartAreas[0].AxisX.LabelStyle.IsStaggered = false;   //設置是否交錯顯示,比如數據多的時間分成兩行來顯示
        }
        #endregion

        #region Loosing Streaks
        private void SetCLChart(List<decimal> consecutiveLossesList)
        {
            //設定 Chart
            chart_LS_CL.BackColor = System.Drawing.Color.Gray;

            Title title = new Title();
            title.Text = "Loosing Streaks";
            title.Alignment = ContentAlignment.MiddleCenter;
            title.Font = new System.Drawing.Font("Trebuchet MS", 11F, FontStyle.Bold);
            if (chart_LS_CL.Titles.Count == 0)
            {
                chart_LS_CL.Titles.Add(title);
            }

            chart_LS_CL.Series[0].Points.Clear();
            //Data Y
            decimal[] yValues = consecutiveLossesList.Take(60).ToArray();
            //Data 對應X座標
            var list = new List<decimal>();
            for (int i = 0; i < 60; i++)
            {
                list.Add(i);
            }
            List<decimal> xValue = list;


            //設定 ChartArea----------------------------------------------------------------------


            //-----------------------------設定3D------------------------------//

            chart_LS_CL.ChartAreas["ChartArea1"].BackColor = Color.FromArgb(64, 64, 64); //背景色
            chart_LS_CL.ChartAreas["ChartArea1"].AxisX.Enabled = AxisEnabled.True;
            chart_LS_CL.ChartAreas["ChartArea1"].AxisX2.Enabled = AxisEnabled.False; //隱藏 X2 標示
            chart_LS_CL.ChartAreas["ChartArea1"].AxisY2.Enabled = AxisEnabled.False; //隱藏 Y2 標示
            chart_LS_CL.ChartAreas["ChartArea1"].AxisY2.MajorGrid.Enabled = false;   //隱藏 Y2 軸線
            chart_LS_CL.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(150, 150, 150);//X 軸線顏色
            chart_LS_CL.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(150, 150, 150);//Y 軸線顏色
            chart_LS_CL.ChartAreas["ChartArea1"].AxisY.Maximum = 100;


            chart_LS_CL.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "#.##";//設定小數點

            //設定 Series-----------------------------------------------------------------------
            chart_LS_CL.Series["Series1"].ChartType = SeriesChartType.Line; //直條圖(Column),折線圖(Line),橫條圖(Bar)
            //chart_CL.Series["Series2"].ChartType = SeriesChartType.Line; //直條圖(Column),折線圖(Line),橫條圖(Bar)
            //chart_CL.Series["Series1"].ChartType = SeriesChartType.Bar; //橫條圖

            chart_LS_CL.Series["Series1"].Points.DataBindXY(xValue, yValues);//Series1的XY數值放入圖中
            chart_LS_CL.Series["Series1"]["PixelPointWidth"] = "5";

            //remove legend labels
            chart_LS_CL.Series[0].IsVisibleInLegend = false;
            chart_LS_CL.ChartAreas[0].AxisX.Interval = 10;   //設置X軸坐標的間隔為1
            chart_LS_CL.ChartAreas[0].AxisX.IntervalOffset = 1;  //設置X軸坐標偏移為1
            chart_LS_CL.ChartAreas[0].AxisX.LabelStyle.IsStaggered = false;   //設置是否交錯顯示,比如數據多的時間分成兩行來顯示
        }

        private void SetLSListview(List<decimal> probabilityConsecutiveLossesList)
        {

            // Loosing Streaks ListView 更新資料
            //http://csharp.net-informations.com/gui/cs-listview.htm
            for (int i = 1; i <= 60; i++)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(probabilityConsecutiveLossesList[i].ToString());
                list_loosing.Items.Add(lvi);
            }
        }

        #endregion

        #region Drawdown Depth
        private void SetDDChart(List<decimal> drawdownList)
        {
            //設定 Chart
            chart_DD_CD.BackColor = System.Drawing.Color.Gray;

            Title title = new Title();
            title.Text = "Drawdown Depth";
            title.Alignment = ContentAlignment.MiddleCenter;
            title.Font = new System.Drawing.Font("Trebuchet MS", 11F, FontStyle.Bold);
            if (chart_DD_CD.Titles.Count == 0)
            {
                chart_DD_CD.Titles.Add(title);
            }
            chart_DD_CD.Series[0].Points.Clear();

            //Data Y
            decimal[] yValues = drawdownList.ToArray();
            //Data 對應X座標
            var list = new List<decimal>();
            var count = drawdownList.Count * -1;
            for (int i = -1; i >= count; i--)
            {
                list.Add(i);
            }
            List<decimal> xValue = list;


            //設定 ChartArea----------------------------------------------------------------------
            chart_DD_CD.ChartAreas["ChartArea1"].BackColor = Color.FromArgb(64, 64, 64); //背景色
            chart_DD_CD.ChartAreas["ChartArea1"].AxisX.Enabled = AxisEnabled.True;
            chart_DD_CD.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(150, 150, 150);//X 軸線顏色
            chart_DD_CD.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(150, 150, 150);//Y 軸線顏色
            chart_DD_CD.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "#.##";//設定小數點
            chart_DD_CD.ChartAreas["ChartArea1"].AxisY.Maximum = 100;

            //設定 Series-----------------------------------------------------------------------
            chart_DD_CD.Series["Series1"].ChartType = SeriesChartType.Line; //直條圖(Column),折線圖(Line),橫條圖(Bar)
            chart_DD_CD.Series["Series1"].Points.DataBindXY(xValue, yValues);//Series1的XY數值放入圖中
            chart_DD_CD.Series["Series1"]["PixelPointWidth"] = "5";

            //remove legend labels
            chart_DD_CD.Series[0].IsVisibleInLegend = false;
            chart_DD_CD.ChartAreas[0].AxisX.Interval = 10;   //設置X軸坐標的間隔為1
            chart_DD_CD.ChartAreas[0].AxisX.IntervalOffset = 3;  //設置X軸坐標偏移為1
            chart_DD_CD.ChartAreas[0].AxisX.LabelStyle.IsStaggered = false;   //設置是否交錯顯示,比如數據多的時間分成兩行來顯示
        }

        private void SetDDListview(List<decimal> ddList)
        {
            for (int i = 1; i <= 60; i++)
            {
                ListViewItem lvi = new ListViewItem((i*-1).ToString());
                lvi.SubItems.Add(ddList[i].ToString());
                list_drawdown.Items.Add(lvi);
            }
        }
        #endregion

        #region Drawdown Duration
        private void SetDurationChart(List<decimal> ddurationList)
        {
            //設定 Chart
            chart_confidence.BackColor = System.Drawing.Color.Gray;

            Title title = new Title();
            title.Text = "Drawdown Duration";
            title.Alignment = ContentAlignment.MiddleCenter;
            title.Font = new System.Drawing.Font("Trebuchet MS", 11F, FontStyle.Bold);
            if (chart_confidence.Titles.Count == 0)
            {
                chart_confidence.Titles.Add(title);
            }
            chart_confidence.Series[0].Points.Clear();

            //Data Y
            decimal[] yValues = ddurationList.ToArray();
            //Data 對應X座標
            var list = new List<decimal>();
            for (int i = 1; i <= ddurationList.Count; i++)
            {
                list.Add(i);
            }
            List<decimal> xValue = list;


            //設定 ChartArea----------------------------------------------------------------------
            chart_confidence.ChartAreas["ChartArea1"].BackColor = Color.FromArgb(64, 64, 64); //背景色
            chart_confidence.ChartAreas["ChartArea1"].AxisX.Enabled = AxisEnabled.True;
            chart_confidence.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(150, 150, 150);//X 軸線顏色
            chart_confidence.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(150, 150, 150);//Y 軸線顏色
            chart_confidence.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "#.##";//設定小數點
            chart_confidence.ChartAreas["ChartArea1"].AxisY.Maximum = 100;

            //設定 Series-----------------------------------------------------------------------
            chart_confidence.Series["Series1"].ChartType = SeriesChartType.Point; //直條圖(Column),折線圖(Line),橫條圖(Bar)
            chart_confidence.Series["Series1"].Points.DataBindXY(xValue, yValues);//Series1的XY數值放入圖中
            chart_confidence.Series["Series1"]["PixelPointWidth"] = "5";

            //remove legend labels
            chart_confidence.Series[0].IsVisibleInLegend = false;
            chart_confidence.ChartAreas[0].AxisX.Interval = 10;   //設置X軸坐標的間隔為1
            chart_confidence.ChartAreas[0].AxisX.IntervalOffset = 3;  //設置X軸坐標偏移為1
            chart_confidence.ChartAreas[0].AxisX.LabelStyle.IsStaggered = false;   //設置是否交錯顯示,比如數據多的時間分成兩行來顯示
        }

        private void SetDDurationListview(List<decimal> ddurationList)
        {
            var count = ddurationList.Count;
            for (int i = 0; i <= count; i+= 7)
            {
                ListViewItem lvi = new ListViewItem((i+1).ToString());
                lvi.SubItems.Add((ddurationList[i]).ToString());
                List_confidence.Items.Add(lvi);
            }
        }


        #endregion
    }
}