using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_MessageBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      MessageBox.Show("간단한 메시지박스");

      MessageBox.Show("그 다음 간단한 메시지 박스", "Title");

      DialogResult result = MessageBox.Show("배경색을 바꿀까요?",
        "Question", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question);

      if (result == DialogResult.Yes)
        this.BackColor = Color.Aqua;
      
    }
  }
}
