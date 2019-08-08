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
            this.cpuPerformanceControl1.Location = new System.Drawing.Point(61, 33);
            this.cpuPerformanceControl1.Name = "cpuPerformanceControl1";
            this.cpuPerformanceControl1.Size = new System.Drawing.Size(512, 292);
            this.cpuPerformanceControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 528);
            this.Controls.Add(this.cpuPerformanceControl1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Berg Performance Interpreter";
            this.ResumeLayout(false);

        }

        #endregion

        private CpuPerformanceControl cpuPerformanceControl1;
    }
}

