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
      ChartSetting();
    }

    private void ChartSetting()
    {
      chart1.ChartAreas[0].AxisX.Minimum = -20;
      chart1.ChartAreas[0].AxisX.Maximum = 20;
      chart1.ChartAreas[0].AxisX.Interval = 2;
      chart1.ChartAreas[0].AxisX.MajorGrid.LineColor 
        = Color.Gray;
      chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle 
        = ChartDashStyle.Dash;
    }
  }
}
