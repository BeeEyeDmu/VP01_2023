namespace _021_adClock
{
  partial class Form2
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.디지털시계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.디지털시계ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.아날로그시계ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.디지털시계ToolStripMenuItem,
            this.종료ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(497, 24);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // 디지털시계ToolStripMenuItem
      // 
      this.디지털시계ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.디지털시계ToolStripMenuItem1,
            this.아날로그시계ToolStripMenuItem1});
      this.디지털시계ToolStripMenuItem.Name = "디지털시계ToolStripMenuItem";
      this.디지털시계ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.디지털시계ToolStripMenuItem.Text = "시계 타입";
      // 
      // 디지털시계ToolStripMenuItem1
      // 
      this.디지털시계ToolStripMenuItem1.Name = "디지털시계ToolStripMenuItem1";
      this.디지털시계ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
      this.디지털시계ToolStripMenuItem1.Text = "디지털 시계";
      this.디지털시계ToolStripMenuItem1.Click += new System.EventHandler(this.디지털시계ToolStripMenuItem1_Click);
      // 
      // 아날로그시계ToolStripMenuItem1
      // 
      this.아날로그시계ToolStripMenuItem1.Name = "아날로그시계ToolStripMenuItem1";
      this.아날로그시계ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
      this.아날로그시계ToolStripMenuItem1.Text = "아날로그 시계";
      this.아날로그시계ToolStripMenuItem1.Click += new System.EventHandler(this.아날로그시계ToolStripMenuItem1_Click);
      // 
      // 종료ToolStripMenuItem
      // 
      this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
      this.종료ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.종료ToolStripMenuItem.Text = "종료";
      this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(400, 219);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(0, 12);
      this.label1.TabIndex = 3;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(497, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.Name = "Form2";
      this.Text = "Form2";
      this.Load += new System.EventHandler(this.Form2_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 디지털시계ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 디지털시계ToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem 아날로그시계ToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label label1;
  }
}