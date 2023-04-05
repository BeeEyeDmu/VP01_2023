using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace _023_firebase
{
  public partial class Form1 : Form
  {
    IFirebaseConfig config = new FirebaseConfig
    {
      AuthSecret = "GrhH4F0XaH46BdrTMVhz2VWTbWN5iBS3XNg4aCuE",
      BasePath = "https://csfirebase-e3e0d-default-rtdb.firebaseio.com/"
    };

    IFirebaseClient client;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      client = new FireSharp.FirebaseClient(config);
      if (client != null)
        MessageBox.Show("Connection 성공!");
    }

    // 비동기 프로그램(async ~ await)
    private async void btnInsert_Click(object sender, EventArgs e)
    {
      var data = new Data
      {
        Id = txtId.Text,
        SId = txtSId.Text,
        Name = txtName.Text,
        Phone = txtPhone.Text
      };
      SetResponse response =
        await client.SetAsync("VP01_Phonebook/" + txtId.Text, data);

      Data result = response.ResultAs<Data>();
      MessageBox.Show("Data Inserted : Id = " + result.Id);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtId.Text = "";
      txtSId.Text = "";
      txtName.Text = "";
      txtPhone.Text = "";
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
      FirebaseResponse response
        = await client.GetAsync("VP01_Phonebook/" + txtId.Text);
      Data obj = response.ResultAs<Data>();

      txtId.Text = obj.Id;
      txtSId.Text = obj.SId;
      txtName.Text = obj.Name;
      txtPhone.Text = obj.Phone;
    }
  }
}
