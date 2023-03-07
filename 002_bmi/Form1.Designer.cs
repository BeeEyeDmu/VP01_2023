namespace _002_bmi
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(37, 49);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "키(cm)";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(100, 46);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 21);
      this.textBox1.TabIndex = 1;
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(100, 81);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 21);
      this.textBox2.TabIndex = 3;
      this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(37, 84);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 12);
      this.label2.TabIndex = 2;
      this.label2.Text = "체중(kg)";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(100, 118);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(100, 30);
      this.button1.TabIndex = 4;
      this.button1.Text = "BMI";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(39, 182);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(0, 12);
      this.label3.TabIndex = 5;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(264, 253);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "BMI 계산기";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label3;
  }
}

