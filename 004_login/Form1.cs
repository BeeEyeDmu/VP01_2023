using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_login
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    // Id가 abcd이고 password가 1234
    private void btnLogin_Click(object sender, EventArgs e)
    {
      if (txtName.Text == "abcd" && txtPassword.Text == "1234")
        txtResult.Text = "로그인 성공";
      else
        txtResult.Text = "로그인 실패";
    }
  }
}
