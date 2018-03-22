namespace Dash
{
  partial class Form1
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
      this._pnHeader = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this._pnHeader.SuspendLayout();
      this.SuspendLayout();
      // 
      // _pnHeader
      // 
      this._pnHeader.BackColor = System.Drawing.Color.DarkSlateGray;
      this._pnHeader.Controls.Add(this.button1);
      this._pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this._pnHeader.Location = new System.Drawing.Point(0, 0);
      this._pnHeader.Name = "_pnHeader";
      this._pnHeader.Size = new System.Drawing.Size(1045, 80);
      this._pnHeader.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.button1.Location = new System.Drawing.Point(991, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(42, 36);
      this.button1.TabIndex = 0;
      this.button1.Text = "X";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(1045, 664);
      this.Controls.Add(this._pnHeader);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this._pnHeader.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel _pnHeader;
    private System.Windows.Forms.Button button1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
  }
}

