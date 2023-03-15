using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_basicControls
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (txtName.Text != "")
        lblOutput.Text = txtName.Text + "님! 안녕하세요!";
      else
        MessageBox.Show("이름을 입력하세요", "Warning");
    }
  }
}
