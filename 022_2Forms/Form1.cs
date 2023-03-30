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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      this.ClientSize = new System.Drawing.Size(500, 500);

      Form2 f2 = new Form2();
      this.AddOwnedForm(f2);
      f2.Show();
    }
  }
}
