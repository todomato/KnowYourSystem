namespace KnowUrSystem.Winform
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tab_distribution = new System.Windows.Forms.TabPage();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_sqn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_winlossRatio = new System.Windows.Forms.Label();
            this.lbl_trades = new System.Windows.Forms.Label();
            this.lbl_std = new System.Windows.Forms.Label();
            this.lbl_win = new System.Windows.Forms.Label();
            this.lbl_expectancy = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_simulate = new System.Windows.Forms.Button();
            this.btn_example = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_rmutiple = new System.Windows.Forms.Label();
            this.txt_r8 = new System.Windows.Forms.TextBox();
            this.txt_c8 = new System.Windows.Forms.TextBox();
            this.txt_r9 = new System.Windows.Forms.TextBox();
            this.txt_c9 = new System.Windows.Forms.TextBox();
            this.txt_r6 = new System.Windows.Forms.TextBox();
            this.txt_c6 = new System.Windows.Forms.TextBox();
            this.txt_r7 = new System.Windows.Forms.TextBox();
            this.txt_c7 = new System.Windows.Forms.TextBox();
            this.txt_r4 = new System.Windows.Forms.TextBox();
            this.txt_c4 = new System.Windows.Forms.TextBox();
            this.txt_r5 = new System.Windows.Forms.TextBox();
            this.txt_c5 = new System.Windows.Forms.TextBox();
            this.txt_r3 = new System.Windows.Forms.TextBox();
            this.txt_c3 = new System.Windows.Forms.TextBox();
            this.txt_r2 = new System.Windows.Forms.TextBox();
            this.txt_c2 = new System.Windows.Forms.TextBox();
            this.txt_r1 = new System.Windows.Forms.TextBox();
            this.txt_c1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_CL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_maxconsecutivelosses = new System.Windows.Forms.Label();
            this.lbl_avgconsecutivelosses = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tab_drawdown = new System.Windows.Forms.TabPage();
            this.tab_duration = new System.Windows.Forms.TabPage();
            this.tab_expectancy = new System.Windows.Forms.TabPage();
            this.tab_summary = new System.Windows.Forms.TabPage();
            this.N = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabcontrol.SuspendLayout();
            this.tab_distribution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CL)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tab_distribution);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Controls.Add(this.tab_drawdown);
            this.tabcontrol.Controls.Add(this.tab_duration);
            this.tabcontrol.Controls.Add(this.tab_expectancy);
            this.tabcontrol.Controls.Add(this.tab_summary);
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(815, 605);
            this.tabcontrol.TabIndex = 0;
            // 
            // tab_distribution
            // 
            this.tab_distribution.BackColor = System.Drawing.Color.DimGray;
            this.tab_distribution.Controls.Add(this.Chart1);
            this.tab_distribution.Controls.Add(this.lbl_sqn);
            this.tab_distribution.Controls.Add(this.label8);
            this.tab_distribution.Controls.Add(this.lbl_winlossRatio);
            this.tab_distribution.Controls.Add(this.lbl_trades);
            this.tab_distribution.Controls.Add(this.lbl_std);
            this.tab_distribution.Controls.Add(this.lbl_win);
            this.tab_distribution.Controls.Add(this.lbl_expectancy);
            this.tab_distribution.Controls.Add(this.btn_calculate);
            this.tab_distribution.Controls.Add(this.label6);
            this.tab_distribution.Controls.Add(this.label5);
            this.tab_distribution.Controls.Add(this.label4);
            this.tab_distribution.Controls.Add(this.label3);
            this.tab_distribution.Controls.Add(this.label2);
            this.tab_distribution.Controls.Add(this.label1);
            this.tab_distribution.Controls.Add(this.btn_simulate);
            this.tab_distribution.Controls.Add(this.btn_example);
            this.tab_distribution.Controls.Add(this.btn_clear);
            this.tab_distribution.Controls.Add(this.lbl_count);
            this.tab_distribution.Controls.Add(this.lbl_rmutiple);
            this.tab_distribution.Controls.Add(this.txt_r8);
            this.tab_distribution.Controls.Add(this.txt_c8);
            this.tab_distribution.Controls.Add(this.txt_r9);
            this.tab_distribution.Controls.Add(this.txt_c9);
            this.tab_distribution.Controls.Add(this.txt_r6);
            this.tab_distribution.Controls.Add(this.txt_c6);
            this.tab_distribution.Controls.Add(this.txt_r7);
            this.tab_distribution.Controls.Add(this.txt_c7);
            this.tab_distribution.Controls.Add(this.txt_r4);
            this.tab_distribution.Controls.Add(this.txt_c4);
            this.tab_distribution.Controls.Add(this.txt_r5);
            this.tab_distribution.Controls.Add(this.txt_c5);
            this.tab_distribution.Controls.Add(this.txt_r3);
            this.tab_distribution.Controls.Add(this.txt_c3);
            this.tab_distribution.Controls.Add(this.txt_r2);
            this.tab_distribution.Controls.Add(this.txt_c2);
            this.tab_distribution.Controls.Add(this.txt_r1);
            this.tab_distribution.Controls.Add(this.txt_c1);
            this.tab_distribution.Location = new System.Drawing.Point(4, 22);
            this.tab_distribution.Name = "tab_distribution";
            this.tab_distribution.Padding = new System.Windows.Forms.Padding(3);
            this.tab_distribution.Size = new System.Drawing.Size(807, 579);
            this.tab_distribution.TabIndex = 0;
            this.tab_distribution.Text = "Trade Distribution";
            // 
            // Chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(267, 238);
            this.Chart1.Name = "Chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(498, 300);
            this.Chart1.TabIndex = 41;
            this.Chart1.Text = "chart1";
            // 
            // lbl_sqn
            // 
            this.lbl_sqn.AutoSize = true;
            this.lbl_sqn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_sqn.Location = new System.Drawing.Point(398, 177);
            this.lbl_sqn.Name = "lbl_sqn";
            this.lbl_sqn.Size = new System.Drawing.Size(18, 20);
            this.lbl_sqn.TabIndex = 40;
            this.lbl_sqn.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(340, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "SQN :";
            // 
            // lbl_winlossRatio
            // 
            this.lbl_winlossRatio.AutoSize = true;
            this.lbl_winlossRatio.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_winlossRatio.Location = new System.Drawing.Point(398, 121);
            this.lbl_winlossRatio.Name = "lbl_winlossRatio";
            this.lbl_winlossRatio.Size = new System.Drawing.Size(18, 20);
            this.lbl_winlossRatio.TabIndex = 38;
            this.lbl_winlossRatio.Text = "0";
            // 
            // lbl_trades
            // 
            this.lbl_trades.AutoSize = true;
            this.lbl_trades.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_trades.Location = new System.Drawing.Point(398, 149);
            this.lbl_trades.Name = "lbl_trades";
            this.lbl_trades.Size = new System.Drawing.Size(18, 20);
            this.lbl_trades.TabIndex = 37;
            this.lbl_trades.Text = "0";
            // 
            // lbl_std
            // 
            this.lbl_std.AutoSize = true;
            this.lbl_std.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_std.Location = new System.Drawing.Point(398, 70);
            this.lbl_std.Name = "lbl_std";
            this.lbl_std.Size = new System.Drawing.Size(18, 20);
            this.lbl_std.TabIndex = 36;
            this.lbl_std.Text = "0";
            // 
            // lbl_win
            // 
            this.lbl_win.AutoSize = true;
            this.lbl_win.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_win.Location = new System.Drawing.Point(398, 95);
            this.lbl_win.Name = "lbl_win";
            this.lbl_win.Size = new System.Drawing.Size(18, 20);
            this.lbl_win.TabIndex = 35;
            this.lbl_win.Text = "0";
            // 
            // lbl_expectancy
            // 
            this.lbl_expectancy.AutoSize = true;
            this.lbl_expectancy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_expectancy.Location = new System.Drawing.Point(398, 42);
            this.lbl_expectancy.Name = "lbl_expectancy";
            this.lbl_expectancy.Size = new System.Drawing.Size(18, 20);
            this.lbl_expectancy.TabIndex = 32;
            this.lbl_expectancy.Text = "0";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(31, 462);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(126, 35);
            this.btn_calculate.TabIndex = 30;
            this.btn_calculate.Text = "試算";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(345, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "STD :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(315, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "#Trades :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(327, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Win % :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(263, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Win/Loss Ratio :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(290, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Expectancy :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(34, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "DISTRIBUTION";
            // 
            // btn_simulate
            // 
            this.btn_simulate.Location = new System.Drawing.Point(31, 503);
            this.btn_simulate.Name = "btn_simulate";
            this.btn_simulate.Size = new System.Drawing.Size(126, 35);
            this.btn_simulate.TabIndex = 23;
            this.btn_simulate.Text = "Simulate";
            this.btn_simulate.UseVisualStyleBackColor = true;
            // 
            // btn_example
            // 
            this.btn_example.Location = new System.Drawing.Point(31, 403);
            this.btn_example.Name = "btn_example";
            this.btn_example.Size = new System.Drawing.Size(126, 35);
            this.btn_example.TabIndex = 22;
            this.btn_example.Text = "Example";
            this.btn_example.UseVisualStyleBackColor = true;
            this.btn_example.Click += new System.EventHandler(this.btn_example_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(31, 362);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(126, 35);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_count.Location = new System.Drawing.Point(47, 40);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(56, 20);
            this.lbl_count.TabIndex = 20;
            this.lbl_count.Text = "Count";
            // 
            // lbl_rmutiple
            // 
            this.lbl_rmutiple.AutoSize = true;
            this.lbl_rmutiple.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_rmutiple.Location = new System.Drawing.Point(137, 40);
            this.lbl_rmutiple.Name = "lbl_rmutiple";
            this.lbl_rmutiple.Size = new System.Drawing.Size(81, 20);
            this.lbl_rmutiple.TabIndex = 19;
            this.lbl_rmutiple.Text = "R Mutiple";
            // 
            // txt_r8
            // 
            this.txt_r8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_r8.Location = new System.Drawing.Point(131, 259);
            this.txt_r8.Name = "txt_r8";
            this.txt_r8.Size = new System.Drawing.Size(100, 22);
            this.txt_r8.TabIndex = 17;
            // 
            // txt_c8
            // 
            this.txt_c8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_c8.Location = new System.Drawing.Point(25, 259);
            this.txt_c8.Name = "txt_c8";
            this.txt_c8.Size = new System.Drawing.Size(100, 22);
            this.txt_c8.TabIndex = 16;
            // 
            // txt_r9
            // 
            this.txt_r9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_r9.Location = new System.Drawing.Point(131, 287);
            this.txt_r9.Name = "txt_r9";
            this.txt_r9.Size = new System.Drawing.Size(100, 22);
            this.txt_r9.TabIndex = 15;
            // 
            // txt_c9
            // 
            this.txt_c9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_c9.Location = new System.Drawing.Point(25, 287);
            this.txt_c9.Name = "txt_c9";
            this.txt_c9.Size = new System.Drawing.Size(100, 22);
            this.txt_c9.TabIndex = 14;
            // 
            // txt_r6
            // 
            this.txt_r6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_r6.Location = new System.Drawing.Point(131, 203);
            this.txt_r6.Name = "txt_r6";
            this.txt_r6.Size = new System.Drawing.Size(100, 22);
            this.txt_r6.TabIndex = 13;
            // 
            // txt_c6
            // 
            this.txt_c6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_c6.Location = new System.Drawing.Point(25, 203);
            this.txt_c6.Name = "txt_c6";
            this.txt_c6.Size = new System.Drawing.Size(100, 22);
            this.txt_c6.TabIndex = 12;
            // 
            // txt_r7
            // 
            this.txt_r7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_r7.Location = new System.Drawing.Point(131, 231);
            this.txt_r7.Name = "txt_r7";
            this.txt_r7.Size = new System.Drawing.Size(100, 22);
            this.txt_r7.TabIndex = 11;
            // 
            // txt_c7
            // 
            this.txt_c7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_c7.Location = new System.Drawing.Point(25, 231);
            this.txt_c7.Name = "txt_c7";
            this.txt_c7.Size = new System.Drawing.Size(100, 22);
            this.txt_c7.TabIndex = 10;
            // 
            // txt_r4
            // 
            this.txt_r4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_r4.Location = new System.Drawing.Point(131, 147);
            this.txt_r4.Name = "txt_r4";
            this.txt_r4.Size = new System.Drawing.Size(100, 22);
            this.txt_r4.TabIndex = 9;
            // 
            // txt_c4
            // 
            this.txt_c4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_c4.Location = new System.Drawing.Point(25, 147);
            this.txt_c4.Name = "txt_c4";
            this.txt_c4.Size = new System.Drawing.Size(100, 22);
            this.txt_c4.TabIndex = 8;
            // 
            // txt_r5
            // 
            this.txt_r5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_r5.Location = new System.Drawing.Point(131, 175);
            this.txt_r5.Name = "txt_r5";
            this.txt_r5.Size = new System.Drawing.Size(100, 22);
            this.txt_r5.TabIndex = 7;
            // 
            // txt_c5
            // 
            this.txt_c5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_c5.Location = new System.Drawing.Point(25, 175);
            this.txt_c5.Name = "txt_c5";
            this.txt_c5.Size = new System.Drawing.Size(100, 22);
            this.txt_c5.TabIndex = 6;
            // 
            // txt_r3
            // 
            this.txt_r3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_r3.Location = new System.Drawing.Point(131, 119);
            this.txt_r3.Name = "txt_r3";
            this.txt_r3.Size = new System.Drawing.Size(100, 22);
            this.txt_r3.TabIndex = 5;
            // 
            // txt_c3
            // 
            this.txt_c3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_c3.Location = new System.Drawing.Point(25, 119);
            this.txt_c3.Name = "txt_c3";
            this.txt_c3.Size = new System.Drawing.Size(100, 22);
            this.txt_c3.TabIndex = 4;
            // 
            // txt_r2
            // 
            this.txt_r2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_r2.Location = new System.Drawing.Point(131, 91);
            this.txt_r2.Name = "txt_r2";
            this.txt_r2.Size = new System.Drawing.Size(100, 22);
            this.txt_r2.TabIndex = 3;
            // 
            // txt_c2
            // 
            this.txt_c2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_c2.Location = new System.Drawing.Point(25, 91);
            this.txt_c2.Name = "txt_c2";
            this.txt_c2.Size = new System.Drawing.Size(100, 22);
            this.txt_c2.TabIndex = 2;
            // 
            // txt_r1
            // 
            this.txt_r1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_r1.Location = new System.Drawing.Point(131, 63);
            this.txt_r1.Name = "txt_r1";
            this.txt_r1.Size = new System.Drawing.Size(100, 22);
            this.txt_r1.TabIndex = 1;
            // 
            // txt_c1
            // 
            this.txt_c1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_c1.Location = new System.Drawing.Point(25, 63);
            this.txt_c1.Name = "txt_c1";
            this.txt_c1.Size = new System.Drawing.Size(100, 22);
            this.txt_c1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.chart3);
            this.tabPage2.Controls.Add(this.chart_CL);
            this.tabPage2.Controls.Add(this.lbl_maxconsecutivelosses);
            this.tabPage2.Controls.Add(this.lbl_avgconsecutivelosses);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lossing Streaks";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.N,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(428, 161);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(138, 373);
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chart3
            // 
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(41, 19);
            this.chart3.Name = "chart3";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(322, 256);
            this.chart3.TabIndex = 44;
            this.chart3.Text = "chart3";
            // 
            // chart_CL
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_CL.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_CL.Legends.Add(legend3);
            this.chart_CL.Location = new System.Drawing.Point(41, 293);
            this.chart_CL.Name = "chart_CL";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_CL.Series.Add(series3);
            this.chart_CL.Size = new System.Drawing.Size(322, 241);
            this.chart_CL.TabIndex = 43;
            this.chart_CL.Text = "chart2";
            // 
            // lbl_maxconsecutivelosses
            // 
            this.lbl_maxconsecutivelosses.AutoSize = true;
            this.lbl_maxconsecutivelosses.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_maxconsecutivelosses.Location = new System.Drawing.Point(643, 110);
            this.lbl_maxconsecutivelosses.Name = "lbl_maxconsecutivelosses";
            this.lbl_maxconsecutivelosses.Size = new System.Drawing.Size(18, 20);
            this.lbl_maxconsecutivelosses.TabIndex = 42;
            this.lbl_maxconsecutivelosses.Text = "0";
            // 
            // lbl_avgconsecutivelosses
            // 
            this.lbl_avgconsecutivelosses.AutoSize = true;
            this.lbl_avgconsecutivelosses.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_avgconsecutivelosses.Location = new System.Drawing.Point(643, 73);
            this.lbl_avgconsecutivelosses.Name = "lbl_avgconsecutivelosses";
            this.lbl_avgconsecutivelosses.Size = new System.Drawing.Size(18, 20);
            this.lbl_avgconsecutivelosses.TabIndex = 40;
            this.lbl_avgconsecutivelosses.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(424, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Max # consecutive losses ：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(424, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Avg # consecutive losses ：";
            // 
            // tab_drawdown
            // 
            this.tab_drawdown.BackColor = System.Drawing.Color.DimGray;
            this.tab_drawdown.Location = new System.Drawing.Point(4, 22);
            this.tab_drawdown.Name = "tab_drawdown";
            this.tab_drawdown.Padding = new System.Windows.Forms.Padding(3);
            this.tab_drawdown.Size = new System.Drawing.Size(807, 579);
            this.tab_drawdown.TabIndex = 2;
            this.tab_drawdown.Text = "Drawdown Depth";
            // 
            // tab_duration
            // 
            this.tab_duration.BackColor = System.Drawing.Color.DimGray;
            this.tab_duration.Location = new System.Drawing.Point(4, 22);
            this.tab_duration.Name = "tab_duration";
            this.tab_duration.Padding = new System.Windows.Forms.Padding(3);
            this.tab_duration.Size = new System.Drawing.Size(807, 579);
            this.tab_duration.TabIndex = 3;
            this.tab_duration.Text = "Drawdown Duration";
            // 
            // tab_expectancy
            // 
            this.tab_expectancy.BackColor = System.Drawing.Color.DimGray;
            this.tab_expectancy.Location = new System.Drawing.Point(4, 22);
            this.tab_expectancy.Name = "tab_expectancy";
            this.tab_expectancy.Padding = new System.Windows.Forms.Padding(3);
            this.tab_expectancy.Size = new System.Drawing.Size(807, 579);
            this.tab_expectancy.TabIndex = 4;
            this.tab_expectancy.Text = "Expectancy";
            // 
            // tab_summary
            // 
            this.tab_summary.BackColor = System.Drawing.Color.DimGray;
            this.tab_summary.Location = new System.Drawing.Point(4, 22);
            this.tab_summary.Name = "tab_summary";
            this.tab_summary.Padding = new System.Windows.Forms.Padding(3);
            this.tab_summary.Size = new System.Drawing.Size(807, 579);
            this.tab_summary.TabIndex = 5;
            this.tab_summary.Text = "Summary";
            // 
            // N
            // 
            this.N.Text = "N";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "%";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 604);
            this.Controls.Add(this.tabcontrol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Know Ur System";
            this.tabcontrol.ResumeLayout(false);
            this.tab_distribution.ResumeLayout(false);
            this.tab_distribution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tab_distribution;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tab_drawdown;
        private System.Windows.Forms.TabPage tab_duration;
        private System.Windows.Forms.TabPage tab_expectancy;
        private System.Windows.Forms.TabPage tab_summary;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_simulate;
        private System.Windows.Forms.Button btn_example;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_rmutiple;
        private System.Windows.Forms.TextBox txt_r8;
        private System.Windows.Forms.TextBox txt_c8;
        private System.Windows.Forms.TextBox txt_r9;
        private System.Windows.Forms.TextBox txt_c9;
        private System.Windows.Forms.TextBox txt_r6;
        private System.Windows.Forms.TextBox txt_c6;
        private System.Windows.Forms.TextBox txt_r7;
        private System.Windows.Forms.TextBox txt_c7;
        private System.Windows.Forms.TextBox txt_r4;
        private System.Windows.Forms.TextBox txt_c4;
        private System.Windows.Forms.TextBox txt_r5;
        private System.Windows.Forms.TextBox txt_c5;
        private System.Windows.Forms.TextBox txt_r3;
        private System.Windows.Forms.TextBox txt_c3;
        private System.Windows.Forms.TextBox txt_r2;
        private System.Windows.Forms.TextBox txt_c2;
        private System.Windows.Forms.TextBox txt_r1;
        private System.Windows.Forms.TextBox txt_c1;
        private System.Windows.Forms.Label lbl_winlossRatio;
        private System.Windows.Forms.Label lbl_trades;
        private System.Windows.Forms.Label lbl_std;
        private System.Windows.Forms.Label lbl_win;
        private System.Windows.Forms.Label lbl_expectancy;
        private System.Windows.Forms.Label lbl_sqn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CL;
        private System.Windows.Forms.Label lbl_maxconsecutivelosses;
        private System.Windows.Forms.Label lbl_avgconsecutivelosses;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader N;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

