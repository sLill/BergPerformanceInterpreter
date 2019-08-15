using BergUI;

namespace BergPerformanceInterpreter
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
            this.cpuPerformanceControl1 = new BergUI.CpuPerformanceControl();
            this.SuspendLayout();
            // 
            // cpuPerformanceControl1
            // 
            this.cpuPerformanceControl1.AutoSize = true;
            this.cpuPerformanceControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cpuPerformanceControl1.Cores = "-";
            this.cpuPerformanceControl1.Location = new System.Drawing.Point(29, 12);
            this.cpuPerformanceControl1.LogicalProcessors = "-";
            this.cpuPerformanceControl1.Name = "cpuPerformanceControl1";
            this.cpuPerformanceControl1.Size = new System.Drawing.Size(754, 369);
            this.cpuPerformanceControl1.TabIndex = 0;
            this.cpuPerformanceControl1.Threads = "-";
            this.cpuPerformanceControl1.TotalCpu = "-";
            this.cpuPerformanceControl1.TotalCpuUser = "-";
            this.cpuPerformanceControl1.UpdateInterval = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 433);
            this.Controls.Add(this.cpuPerformanceControl1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Berg Performance Interpreter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CpuPerformanceControl cpuPerformanceControl1;
    }
}

