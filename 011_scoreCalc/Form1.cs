using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_scoreCalc
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
      double kor = double.Parse(txtKor.Text);
      double mat = double.Parse(txtMath.Text);
      double eng = double.Parse(txtEng.Text);

      double sum = kor + mat + eng;
      double avg = sum / 3;

      txtSum.Text = sum.ToString();
      txtAvg.Text = avg.ToString("0.0");
    }
  }
}
