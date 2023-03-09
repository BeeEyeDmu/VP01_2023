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
      this.txtHeight = new System.Windows.Forms.TextBox();
      this.txtWeight = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnCalc = new System.Windows.Forms.Button();
      this.lblBMI = new System.Windows.Forms.Label();
      this.lblResult = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
      // txtHeight
      // 
      this.txtHeight.Location = new System.Drawing.Point(100, 46);
      this.txtHeight.Name = "txtHeight";
      this.txtHeight.Size = new System.Drawing.Size(100, 21);
      this.txtHeight.TabIndex = 1;
      this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtWeight
      // 
      this.txtWeight.Location = new System.Drawing.Point(100, 81);
      this.txtWeight.Name = "txtWeight";
      this.txtWeight.Size = new System.Drawing.Size(100, 21);
      this.txtWeight.TabIndex = 3;
      this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
      // btnCalc
      // 
      this.btnCalc.Location = new System.Drawing.Point(100, 118);
      this.btnCalc.Name = "btnCalc";
      this.btnCalc.Size = new System.Drawing.Size(100, 30);
      this.btnCalc.TabIndex = 4;
      this.btnCalc.Text = "BMI";
      this.btnCalc.UseVisualStyleBackColor = true;
      this.btnCalc.Click += new System.EventHandler(this.button1_Click);
      // 
      // lblBMI
      // 
      this.lblBMI.AutoSize = true;
      this.lblBMI.Location = new System.Drawing.Point(39, 182);
      this.lblBMI.Name = "lblBMI";
      this.lblBMI.Size = new System.Drawing.Size(0, 12);
      this.lblBMI.TabIndex = 5;
      // 
      // lblResult
      // 
      this.lblResult.AutoSize = true;
      this.lblResult.Location = new System.Drawing.Point(39, 212);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(0, 12);
      this.lblResult.TabIndex = 6;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(176, 165);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(45, 59);
      this.pictureBox1.TabIndex = 7;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(264, 253);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.lblBMI);
      this.Controls.Add(this.btnCalc);
      this.Controls.Add(this.txtWeight);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtHeight);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "BMI 계산기";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtHeight;
    private System.Windows.Forms.TextBox txtWeight;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnCalc;
    private System.Windows.Forms.Label lblBMI;
    private System.Windows.Forms.Label lblResult;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

