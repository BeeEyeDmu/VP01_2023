using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_chart2
{
  public partial class Form1 : Form
  {
    // 생성자 : 객체가 생성될 때 자동으로 호출되는 함수(메소드)
    public Form1()
    {
      InitializeComponent();

      this.Text = "Chart 연습";

      ChartSetting();
      
    }

    private void ChartSetting()
    {
      chart1.Titles.Add("입력 숫자 표시 차트");
      chart1.Series[0].LegendText = "숫자";
      chart1.ChartAreas[0].AxisX.Minimum = 0;
      chart1.ChartAreas[0].AxisX.Maximum = 10;
      chart1.ChartAreas[0].AxisY.Minimum = 0;
      chart1.ChartAreas[0].AxisY.Maximum = 1000;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      chart1.Series[0].Points.Add(int.Parse(textBox1.Text));
    }
  }
}
