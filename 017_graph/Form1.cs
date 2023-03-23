using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _017_graph
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Text = "Graph usng Chart Control";
      ChartSetting();
      SeriesData();
    }

    private void SeriesData()
    {
      for(double x = -20; x <= 20; x += 0.1)
      {
        double y = Math.Sin(x) / x;
        double z = Math.Cos(x) / x;

        chart1.Series[0].Points.AddXY(x, y);  // sin(x)/x
        chart1.Series[1].Points.AddXY(x, z);  // cos(x)/x
      }
    }

    private void ChartSetting()
    {
      // 배경색
      chart1.ChartAreas[0].BackColor = Color.Black;

      // x축을 설정
      chart1.ChartAreas[0].AxisX.Minimum = -20;
      chart1.ChartAreas[0].AxisX.Maximum = 20;
      chart1.ChartAreas[0].AxisX.Interval = 2;
      chart1.ChartAreas[0].AxisX.MajorGrid.LineColor 
        = Color.Gray;
      chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle 
        = ChartDashStyle.Dash;

      // y축을 설정
      chart1.ChartAreas[0].AxisY.Minimum = -2;
      chart1.ChartAreas[0].AxisY.Maximum = 2;
      chart1.ChartAreas[0].AxisY.Interval = 0.5;
      chart1.ChartAreas[0].AxisY.MajorGrid.LineColor
        = Color.Gray;
      chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle
        = ChartDashStyle.Dash;

      // Series[0] 설정 : sin(x)/x
      chart1.Series[0].ChartType = SeriesChartType.Line;
      chart1.Series[0].Color = Color.LightGreen;
      chart1.Series[0].BorderWidth = 2;
      chart1.Series[0].LegendText = "sin(x)/x";

      // Series[1] 추가
      chart1.Series.Add("Series2");

      // Series[1] 설정 : cos(x)/x
      chart1.Series[1].ChartType = SeriesChartType.Line;
      chart1.Series[1].Color = Color.Orange;
      chart1.Series[1].BorderWidth = 2;
      chart1.Series[1].LegendText = "cos(x)/x";
    }
  }
}
