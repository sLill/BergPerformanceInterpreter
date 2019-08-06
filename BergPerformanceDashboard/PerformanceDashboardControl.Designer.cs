namespace BergPerformanceDashboard
{
    partial class BergPerformanceDashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxPerformanceDashboard = new System.Windows.Forms.GroupBox();
            this.cpuPerformanceControl = new BergPerformanceDashboard.CpuPerformanceControl();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxPerformanceDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxPerformanceDashboard, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1116, 714);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxPerformanceDashboard
            // 
            this.groupBoxPerformanceDashboard.Controls.Add(this.cpuPerformanceControl);
            this.groupBoxPerformanceDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPerformanceDashboard.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPerformanceDashboard.Name = "groupBoxPerformanceDashboard";
            this.groupBoxPerformanceDashboard.Size = new System.Drawing.Size(1093, 601);
            this.groupBoxPerformanceDashboard.TabIndex = 1;
            this.groupBoxPerformanceDashboard.TabStop = false;
            this.groupBoxPerformanceDashboard.Text = "Performance Dashboard";
            // 
            // cpuPerformanceControl
            // 
            this.cpuPerformanceControl.AutoSize = true;
            this.cpuPerformanceControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cpuPerformanceControl.Cores = "-";
            this.cpuPerformanceControl.Location = new System.Drawing.Point(6, 19);
            this.cpuPerformanceControl.LogicalProcessors = "-";
            this.cpuPerformanceControl.Name = "cpuPerformanceControl";
            this.cpuPerformanceControl.Size = new System.Drawing.Size(822, 394);
            this.cpuPerformanceControl.TabIndex = 0;
            this.cpuPerformanceControl.Threads = "-";
            this.cpuPerformanceControl.TotalCpu = "-";
            this.cpuPerformanceControl.TotalCpuUser = "-";
            // 
            // BergPerformanceDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "BergPerformanceDashboardControl";
            this.Size = new System.Drawing.Size(1116, 714);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.groupBoxPerformanceDashboard.ResumeLayout(false);
            this.groupBoxPerformanceDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxPerformanceDashboard;
        private CpuPerformanceControl cpuPerformanceControl;
    }
}
