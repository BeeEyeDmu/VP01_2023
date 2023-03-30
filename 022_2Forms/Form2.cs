using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_2Forms
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();

      this.ClientSize = new System.Drawing.Size(300, 200);
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      CenterToParent();
    }
  }
}
