﻿namespace BruTileDemoCF
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.MainMenu mainMenu1;

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
        this.mainMenu1 = new System.Windows.Forms.MainMenu();
        this.mapControl1 = new BruTileClient.MapControl();
        this.ZoomOut = new System.Windows.Forms.Button();
        this.zoomIn = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // mapControl1
        // 
        this.mapControl1.Location = new System.Drawing.Point(0, 0);
        this.mapControl1.Name = "mapControl1";
        this.mapControl1.Size = new System.Drawing.Size(240, 268);
        this.mapControl1.TabIndex = 0;
        this.mapControl1.Text = "mapControl1";
        // 
        // ZoomOut
        // 
        this.ZoomOut.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
        this.ZoomOut.Location = new System.Drawing.Point(8, 230);
        this.ZoomOut.Name = "ZoomOut";
        this.ZoomOut.Size = new System.Drawing.Size(30, 30);
        this.ZoomOut.TabIndex = 1;
        this.ZoomOut.Text = "-";
        this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
        // 
        // zoomIn
        // 
        this.zoomIn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
        this.zoomIn.Location = new System.Drawing.Point(43, 230);
        this.zoomIn.Name = "zoomIn";
        this.zoomIn.Size = new System.Drawing.Size(30, 30);
        this.zoomIn.TabIndex = 1;
        this.zoomIn.Text = "+";
        this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoScroll = true;
        this.ClientSize = new System.Drawing.Size(240, 268);
        this.Controls.Add(this.zoomIn);
        this.Controls.Add(this.ZoomOut);
        this.Controls.Add(this.mapControl1);
        this.Menu = this.mainMenu1;
        this.Name = "Form1";
        this.Text = "Form1";
        this.ResumeLayout(false);

    }

    #endregion

    private BruTileClient.MapControl mapControl1;
    private System.Windows.Forms.Button ZoomOut;
    private System.Windows.Forms.Button zoomIn;
  }
}
