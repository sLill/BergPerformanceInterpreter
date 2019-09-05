using BergUI;

namespace BergPerformanceProfiler
{
    partial class MainForm
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
            this.cpuPerformanceControl = new BergUI.CpuPerformanceControl();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bergCpuMonitorDllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpuPerformanceControl
            // 
            this.cpuPerformanceControl.AutoSize = true;
            this.cpuPerformanceControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cpuPerformanceControl.CurrentThreads = "[Threads]";
            this.cpuPerformanceControl.Location = new System.Drawing.Point(12, 38);
            this.cpuPerformanceControl.Name = "cpuPerformanceControl";
            this.cpuPerformanceControl.Size = new System.Drawing.Size(754, 442);
            this.cpuPerformanceControl.TabIndex = 0;
            this.cpuPerformanceControl.TotalCpu = "-%%";
            this.cpuPerformanceControl.UpdateInterval = 0;
            this.cpuPerformanceControl.UseLocalDataSource = true;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(793, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bergCpuMonitorDllToolStripMenuItem});
            this.buildToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // bergCpuMonitorDllToolStripMenuItem
            // 
            this.bergCpuMonitorDllToolStripMenuItem.Name = "bergCpuMonitorDllToolStripMenuItem";
            this.bergCpuMonitorDllToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.bergCpuMonitorDllToolStripMenuItem.Text = "BergCpuMonitor dll";
            this.bergCpuMonitorDllToolStripMenuItem.Click += new System.EventHandler(this.BergCpuMonitorDllToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 498);
            this.Controls.Add(this.cpuPerformanceControl);
            this.Controls.Add(this.menuStripMain);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Berg Performance Profiler";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CpuPerformanceControl cpuPerformanceControl;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bergCpuMonitorDllToolStripMenuItem;
    }
}

