﻿using KnowUrSystem.Model;
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
        public Form1()
        {
            InitializeComponent();

            //設定 Chart
            Chart1.BackColor = System.Drawing.Color.Gray;  

            Title title = new Title();
            title.Text = "Trade Distributin";
            title.Alignment = ContentAlignment.MiddleCenter;
            title.Font = new System.Drawing.Font("Trebuchet MS", 11F, FontStyle.Bold);
            Chart1.Titles.Add(title);

            Chart1.Legends.Add("Legends1"); //圖例集合
            //設定 Legends------------------------------------------------------------------------               
            Chart1.Legends["Legends1"].DockedToChartArea = "ChartArea1"; //顯示在圖表內
            //Chart1.Legends["Legends1"].Docking = Docking.Bottom; //自訂顯示位置
            Chart1.Legends["Legends1"].BackColor = Color.FromArgb(64, 64, 64); //背景色
            //斜線背景
            Chart1.Legends["Legends1"].BackHatchStyle = ChartHatchStyle.DarkDownwardDiagonal;
            Chart1.Legends["Legends1"].BorderWidth = 1;
            Chart1.Legends["Legends1"].BorderColor = Color.FromArgb(200, 200, 200);
        }

       

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
        }

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

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            var distributions = new List<DistributionRawData>();

            // 加入分佈
            for (int i = 1; i <= 9; i++)
            {
                TextBox txtBox = this.tab_distribution.Controls["txt_c" + i.ToString()] as TextBox;
                TextBox txtBox2 = this.tab_distribution.Controls["txt_r" + i.ToString()] as TextBox;
                int num1 = 0;
                double num2 = 0.0;

                if (int.TryParse(txtBox.Text, out num1) && double.TryParse(txtBox2.Text, out num2))
                {
                    distributions.Add(new DistributionRawData() { Count = num1, RMultiple = num2 });
                }
            }

            SetChart(distributions);

            // 取得計算機
            this._financeCalulator = Factory.GetDistributionInstance(distributions);

            // 試算結果
            lbl_expectancy.Text = _financeCalulator.GetExpectancy().ToString();
            lbl_std.Text = _financeCalulator.GetStandardDeviation().ToString();
            lbl_win.Text = _financeCalulator.GetWinRate().ToString();
            lbl_winlossRatio.Text = _financeCalulator.GetWinLossRatio().ToString();
            lbl_trades.Text = _financeCalulator.GetTrades().ToString();
            lbl_sqn.Text = Math.Round(_financeCalulator.GetSQN(), 2).ToString();
        }

        private void SetChart(List<DistributionRawData> distributions)
        {
            Chart1.Series[0].Points.Clear();

            distributions = distributions.OrderBy( c => c.RMultiple).ToList();

            string[] titleArr = { "R 分佈" };
            //Data Y
            int[] yValues = distributions.Select(x => x.Count).ToArray();

            //Data 對應X座標
            List<double> xValue = distributions.Select(x => x.RMultiple).ToList();


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
            Chart1.Series["Series1"].Legend = "Legends1";
            Chart1.Series["Series1"].LegendText = titleArr[0];
            Chart1.Series["Series1"].LabelFormat = "#.##"; //小數點
            Chart1.Series["Series1"].MarkerSize = 15; //Label 範圍大小
            Chart1.Series["Series1"].LabelForeColor = Color.FromArgb(255, 255, 255); //字體顏色
            //字體設定
            Chart1.Series["Series1"].Font = new System.Drawing.Font("Trebuchet MS", 10, System.Drawing.FontStyle.Bold);
            //Label 背景色
            Chart1.Series["Series1"].LabelBackColor = Color.FromArgb(64, 64, 64);
            Chart1.Series["Series1"].Color = Color.FromArgb(240, 65, 140, 240); //背景色
            Chart1.Series["Series1"].IsValueShownAsLabel = true; // Show data points labels


            Chart1.ChartAreas[0].AxisX.Interval = 2;   //設置X軸坐標的間隔為1
            Chart1.ChartAreas[0].AxisX.IntervalOffset = 1;  //設置X軸坐標偏移為1
            Chart1.ChartAreas[0].AxisX.LabelStyle.IsStaggered = false;   //設置是否交錯顯示,比如數據多的時間分成兩行來顯示
        }
    }
}