using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_Labels
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      label1.Text = "";
      label2.Text = "";
      button1.Text = "라파엘로, 아테네 학당";
      this.Text = "Label Control";
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      label1.Text = "라파엘로 산지오, 이탈리아, 르네상스 3대 거장";
      label2.Text ="르네상스 시대의 거장인 라파엘로 산치오가 교황 율리오 2세의 주문으로 27세인 1509~1510년에 바티칸 사도 궁전 내부의 방들 가운데서 교황의 개인 서재인 '서명의 방(Stanza della Segnatura)'에 그린 프레스코화.\n"+
        "서명의 방의 네 벽면은 각각 철학, 신학, 법, 예술을 주제로 " +
        "벽화가 그려졌는데 이중에서 아테네 학당은 철학을 상징하는 " +
        "그림이다.가로 823.5cm, 세로 579.5cm 크기의 벽면에 모두 54명의 철학자가 배치되어 있다. 철학자들이 모여서 토론하고 있는 공간은 이 벽화가 그려질 당시 도나토 브라만테가 설계해 막 공사에 착수한 성 베드로 대성당의 내부를 모티브로 1점 투시도법을 사용해 묘사되었다. 벽기둥 양쪽에 있는 두 석상은 왼쪽이 아폴론, 오른쪽이 아테나이다. 아폴론과 아테나는 이성과 지혜를 상징하는 신이므로 그림의 의미에 적합한 소재라 할 수 있다.";
    }
  }
}
