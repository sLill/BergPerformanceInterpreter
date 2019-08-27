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
            this.SuspendLayout();
            // 
            // cpuPerformanceControl
            // 
            this.cpuPerformanceControl.AutoSize = true;
            this.cpuPerformanceControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cpuPerformanceControl.Cores = "-";
            this.cpuPerformanceControl.Location = new System.Drawing.Point(29, 12);
            this.cpuPerformanceControl.LogicalProcessors = "-";
            this.cpuPerformanceControl.Name = "cpuPerformanceControl";
            this.cpuPerformanceControl.ParentProcess = "-";
            this.cpuPerformanceControl.Size = new System.Drawing.Size(754, 391);
            this.cpuPerformanceControl.TabIndex = 0;
            this.cpuPerformanceControl.ThreadCount = "-";
            this.cpuPerformanceControl.TotalCpu = "-";
            this.cpuPerformanceControl.TotalCpuUser = "-";
            this.cpuPerformanceControl.UpdateInterval = 0;
            this.cpuPerformanceControl.UseLocalDataSource = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 433);
            this.Controls.Add(this.cpuPerformanceControl);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Berg Performance Profiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CpuPerformanceControl cpuPerformanceControl;
    }
}

