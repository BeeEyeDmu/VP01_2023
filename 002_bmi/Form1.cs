using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_bmi
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double height = double.Parse(txtHeight.Text);
      double weight = double.Parse(txtWeight.Text);
      double bmi 
        = weight / (height / 100 * height / 100);
      
      lblBMI.Text = String.Format("BMI = {0:F2}", bmi);
      if (bmi < 20)
      {
        lblResult.Text = "저체중";
        pictureBox1.BackColor = Color.Blue;
      }
      else if (bmi < 25)
      {
        lblResult.Text = "정상체중";
        pictureBox1.BackColor = Color.Green;
      }
      else if (bmi < 30)
      {
        lblResult.Text = "경도비만";
        pictureBox1.BackColor = Color.Orange;
      }
      else if (bmi < 40)
      {
        lblResult.Text = "비만";
        pictureBox1.BackColor = Color.OrangeRed;
      }
      else
      {
        lblResult.Text = "고도비만";
        pictureBox1.BackColor = Color.Red;
      }
    }

  }
}
