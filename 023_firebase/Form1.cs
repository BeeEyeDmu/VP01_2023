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
    DataTable dt = new DataTable();

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

      dt.Columns.Add("Id");
      dt.Columns.Add("학번");
      dt.Columns.Add("이름");
      dt.Columns.Add("전화번호");

      dataGridView1.DataSource = dt;
      export();
    }

    // 비동기 프로그램(async ~ await)
    private async void btnInsert_Click(object sender, EventArgs e)
    {
      // 카운터 수정
      FirebaseResponse resp 
        = await client.GetAsync("VP01_Counter/nPhones");
      Counter c = resp.ResultAs<Counter>();
      MessageBox.Show(c.cnt.ToString());

      var data = new Data
      {
        //Id = txtId.Text,
        Id = (c.cnt + 1).ToString(),
        SId = txtSId.Text,
        Name = txtName.Text,
        Phone = txtPhone.Text
      };
      //SetResponse response =
      //  await client.SetAsync("VP01_Phonebook/" + txtId.Text, data);
      SetResponse response =
        await client.SetAsync("VP01_Phonebook/" + data.Id, data);

      Data result = response.ResultAs<Data>();
      MessageBox.Show("Data Inserted : Id = " + result.Id);

      // Counter 값을 증가시켜 firebase에 저장
      var obj = new Counter
      {
        cnt = c.cnt + 1
      };
      SetResponse r 
        = await client.SetAsync("VP01_Counter/nPhones", obj);

      export();
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

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
      var data = new Data
      {
        Id = txtId.Text,
        SId = txtSId.Text,
        Name = txtName.Text,
        Phone = txtPhone.Text
      };

      FirebaseResponse response = await 
        client.UpdateAsync("VP01_Phonebook/" + txtId.Text, data);
      Data result = response.ResultAs<Data>();
      MessageBox.Show("Data updated at : " + result.Id);
      export();
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
      FirebaseResponse response 
        = await client.DeleteAsync("VP01_Phonebook/" + txtId.Text);
      
      MessageBox.Show("Data deleted at : " + txtId.Text);
      export();
    }

    private void btnViewAll_Click(object sender, EventArgs e)
    {
      
      export();
    }

    private async void export()
    {
      dt.Rows.Clear();

      int i = 0;
      FirebaseResponse res 
        = await client.GetAsync("VP01_Counter/nPhones");
      Counter obj = res.ResultAs<Counter>();
      int cnt = obj.cnt;

      while( i != cnt)
      {
        i++;
        FirebaseResponse resp
          = await client.GetAsync("VP01_Phonebook/" + i);
        Data d = resp.ResultAs<Data>();

        // 체크
        if (d != null)
        {
          DataRow row = dt.NewRow();
          row["Id"] = d.Id;
          row["학번"] = d.SId;
          row["이름"] = d.Name;
          row["전화번호"] = d.Phone;

          dt.Rows.Add(row);
        }
      }
    }

    // 모두 삭제(확인이 필요)
    private async void btnDeleteAll_Click(object sender, EventArgs e)
    {
      DialogResult answer = MessageBox.Show(
        "저장된 데이터가 모두 삭제됩니다. 계속하시겠습니까?",
        "Warning!", MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

      if (answer == DialogResult.No)
        return;

      // firebase의 Counter/cnt 값을 0으로 바꾼다
      var obj = new Counter
      {
        cnt = 0
      };

      SetResponse res 
        = await client.SetAsync("VP01_Counter/nPhones", obj);

      FirebaseResponse response
        = await client.DeleteAsync("VP01_Phonebook");

      dt.Rows.Clear();
      export();
      MessageBox.Show("All data deleted! \n/VP01_Phonebook deleted!");
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dgv = (DataGridView)sender;
      txtId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
      txtSId.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
      txtName.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
      txtPhone.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
    }
  }
}
