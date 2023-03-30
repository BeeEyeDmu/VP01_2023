using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_adClock
{
  public partial class Form2 : Form
  {
    bool aFlag = false;   // analog 시계를 표시하는 깃발
    const int clientSize = 450;

    public Form2()
    {
      InitializeComponent();
      this.Text = "Analog/Digital Clock by bikang";
      this.ClientSize
        = new Size(clientSize,
              clientSize + menuStrip1.Height);
      this.BackColor = Color.White;
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      timer1.Enabled = true;
      timer1.Interval = 1000; // 1초
      timer1.Tick += Timer1_Tick;

      label1.Font
        = new Font("맑은 고딕", 20, FontStyle.Bold);
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      if (aFlag == false) // 디지털 시계
      {
        label1.Text = DateTime.Now.ToString();
        label1.Location = new Point(
          ClientSize.Width / 2 - label1.Width / 2,
          ClientSize.Height / 2 - label1.Height / 2);
      }
    }

    private void 디지털시계ToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      aFlag = false;
    }

    private void 아날로그시계ToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Form1 form = new Form1();
      this.Hide();
      form.ShowDialog();
    }

    private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
