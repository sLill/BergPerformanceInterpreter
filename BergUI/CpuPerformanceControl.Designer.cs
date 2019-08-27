namespace BergUI
{
    partial class CpuPerformanceControl
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxCPU = new System.Windows.Forms.GroupBox();
            this.lblTotalCpu = new System.Windows.Forms.Label();
            this.toolTipLabel6 = new BergUI.ToolTipLabel();
            this.toolTipLabel7 = new BergUI.ToolTipLabel();
            this.lblTotalCpuUser = new System.Windows.Forms.Label();
            this.ttlProcessor = new BergUI.ToolTipLabel();
            this.ttlParentProcessName = new BergUI.ToolTipLabel();
            this.chartCpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ctxChartCpu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCpuViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOverallUtilization = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogicalProcessors = new System.Windows.Forms.ToolStripMenuItem();
            this.ttlTotalCpuProcess = new BergUI.ToolTipLabel();
            this.lblTotalCpuParent = new System.Windows.Forms.Label();
            this.groupBoxCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCpu)).BeginInit();
            this.ctxChartCpu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCPU
            // 
            this.groupBoxCPU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCPU.Controls.Add(this.ttlTotalCpuProcess);
            this.groupBoxCPU.Controls.Add(this.lblTotalCpuParent);
            this.groupBoxCPU.Controls.Add(this.lblTotalCpu);
            this.groupBoxCPU.Controls.Add(this.toolTipLabel6);
            this.groupBoxCPU.Controls.Add(this.toolTipLabel7);
            this.groupBoxCPU.Controls.Add(this.lblTotalCpuUser);
            this.groupBoxCPU.Controls.Add(this.ttlProcessor);
            this.groupBoxCPU.Controls.Add(this.ttlParentProcessName);
            this.groupBoxCPU.Controls.Add(this.chartCpu);
            this.groupBoxCPU.Location = new System.Drawing.Point(2, 3);
            this.groupBoxCPU.Name = "groupBoxCPU";
            this.groupBoxCPU.Size = new System.Drawing.Size(749, 385);
            this.groupBoxCPU.TabIndex = 9;
            this.groupBoxCPU.TabStop = false;
            this.groupBoxCPU.Text = "CPU";
            // 
            // lblTotalCpu
            // 
            this.lblTotalCpu.AutoSize = true;
            this.lblTotalCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCpu.Location = new System.Drawing.Point(238, 311);
            this.lblTotalCpu.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCpu.Name = "lblTotalCpu";
            this.lblTotalCpu.Size = new System.Drawing.Size(56, 13);
            this.lblTotalCpu.TabIndex = 21;
            this.lblTotalCpu.Text = "[TotalCpu]";
            this.lblTotalCpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTipLabel6
            // 
            this.toolTipLabel6.AutoSize = true;
            this.toolTipLabel6.BackColor = System.Drawing.Color.Transparent;
            this.toolTipLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel6.InfoToolTipEnabled = false;
            this.toolTipLabel6.InfoToolTipText = "";
            this.toolTipLabel6.KeyObjectToolTipEnabled = true;
            this.toolTipLabel6.KeyObjectToolTipText = "";
            this.toolTipLabel6.Location = new System.Drawing.Point(61, 311);
            this.toolTipLabel6.Name = "toolTipLabel6";
            this.toolTipLabel6.Size = new System.Drawing.Size(96, 13);
            this.toolTipLabel6.TabIndex = 22;
            this.toolTipLabel6.Text = "Total CPU";
            // 
            // toolTipLabel7
            // 
            this.toolTipLabel7.AutoSize = true;
            this.toolTipLabel7.BackColor = System.Drawing.Color.Transparent;
            this.toolTipLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel7.InfoToolTipEnabled = true;
            this.toolTipLabel7.InfoToolTipText = "Time spent working on user applications and user environment specific processes";
            this.toolTipLabel7.KeyObjectToolTipEnabled = true;
            this.toolTipLabel7.KeyObjectToolTipText = "";
            this.toolTipLabel7.Location = new System.Drawing.Point(61, 329);
            this.toolTipLabel7.Name = "toolTipLabel7";
            this.toolTipLabel7.Size = new System.Drawing.Size(130, 13);
            this.toolTipLabel7.TabIndex = 23;
            this.toolTipLabel7.Text = "Total CPU (User):";
            // 
            // lblTotalCpuUser
            // 
            this.lblTotalCpuUser.AutoSize = true;
            this.lblTotalCpuUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCpuUser.Location = new System.Drawing.Point(238, 329);
            this.lblTotalCpuUser.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCpuUser.Name = "lblTotalCpuUser";
            this.lblTotalCpuUser.Size = new System.Drawing.Size(78, 13);
            this.lblTotalCpuUser.TabIndex = 24;
            this.lblTotalCpuUser.Text = "[TotalCpuUser]";
            this.lblTotalCpuUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ttlProcessor
            // 
            this.ttlProcessor.AutoSize = true;
            this.ttlProcessor.BackColor = System.Drawing.Color.Transparent;
            this.ttlProcessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlProcessor.InfoToolTipEnabled = false;
            this.ttlProcessor.InfoToolTipText = "";
            this.ttlProcessor.KeyObjectToolTipEnabled = true;
            this.ttlProcessor.KeyObjectToolTipText = "";
            this.ttlProcessor.Location = new System.Drawing.Point(61, 35);
            this.ttlProcessor.Name = "ttlProcessor";
            this.ttlProcessor.Size = new System.Drawing.Size(77, 13);
            this.ttlProcessor.TabIndex = 20;
            this.ttlProcessor.Text = "[Processor]";
            // 
            // ttlParentProcessName
            // 
            this.ttlParentProcessName.AutoSize = true;
            this.ttlParentProcessName.BackColor = System.Drawing.Color.Transparent;
            this.ttlParentProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlParentProcessName.InfoToolTipEnabled = false;
            this.ttlParentProcessName.InfoToolTipText = "";
            this.ttlParentProcessName.KeyObjectToolTipEnabled = true;
            this.ttlParentProcessName.KeyObjectToolTipText = "";
            this.ttlParentProcessName.Location = new System.Drawing.Point(61, 16);
            this.ttlParentProcessName.Name = "ttlParentProcessName";
            this.ttlParentProcessName.Size = new System.Drawing.Size(116, 13);
            this.ttlParentProcessName.TabIndex = 19;
            this.ttlParentProcessName.Text = "[ParentProcessName]";
            // 
            // chartCpu
            // 
            this.chartCpu.BackColor = System.Drawing.Color.Transparent;
            this.chartCpu.ContextMenuStrip = this.ctxChartCpu;
            this.chartCpu.Location = new System.Drawing.Point(-14, 35);
            this.chartCpu.Margin = new System.Windows.Forms.Padding(0);
            this.chartCpu.Name = "chartCpu";
            this.chartCpu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartCpu.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))))};
            this.chartCpu.Size = new System.Drawing.Size(715, 276);
            this.chartCpu.TabIndex = 15;
            this.chartCpu.Text = "chart1";
            this.chartCpu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChartCpu_MouseMove);
            this.chartCpu.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.ChartCpu_MouseWheel);
            // 
            // ctxChartCpu
            // 
            this.ctxChartCpu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCpuViewMode});
            this.ctxChartCpu.Name = "ctxChartCpu";
            this.ctxChartCpu.Size = new System.Drawing.Size(160, 26);
            // 
            // tsCpuViewMode
            // 
            this.tsCpuViewMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOverallUtilization,
            this.tsLogicalProcessors});
            this.tsCpuViewMode.Name = "tsCpuViewMode";
            this.tsCpuViewMode.Size = new System.Drawing.Size(159, 22);
            this.tsCpuViewMode.Text = "CPU View Mode";
            this.tsCpuViewMode.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsCpuViewMode_DropDownItemClicked);
            // 
            // tsOverallUtilization
            // 
            this.tsOverallUtilization.Checked = true;
            this.tsOverallUtilization.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsOverallUtilization.Name = "tsOverallUtilization";
            this.tsOverallUtilization.Size = new System.Drawing.Size(171, 22);
            this.tsOverallUtilization.Text = "Overall Utilization";
            // 
            // tsLogicalProcessors
            // 
            this.tsLogicalProcessors.Name = "tsLogicalProcessors";
            this.tsLogicalProcessors.Size = new System.Drawing.Size(171, 22);
            this.tsLogicalProcessors.Text = "Logical Processors";
            // 
            // ttlTotalCpuProcess
            // 
            this.ttlTotalCpuProcess.AutoSize = true;
            this.ttlTotalCpuProcess.BackColor = System.Drawing.Color.Transparent;
            this.ttlTotalCpuProcess.Cursor = System.Windows.Forms.Cursors.Default;
            this.ttlTotalCpuProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlTotalCpuProcess.InfoToolTipEnabled = false;
            this.ttlTotalCpuProcess.InfoToolTipText = "";
            this.ttlTotalCpuProcess.KeyObjectToolTipEnabled = false;
            this.ttlTotalCpuProcess.KeyObjectToolTipText = "";
            this.ttlTotalCpuProcess.Location = new System.Drawing.Point(61, 348);
            this.ttlTotalCpuProcess.Name = "ttlTotalCpuProcess";
            this.ttlTotalCpuProcess.Size = new System.Drawing.Size(146, 13);
            this.ttlTotalCpuProcess.TabIndex = 25;
            this.ttlTotalCpuProcess.Text = "Total CPU (Parent Process):";
            // 
            // lblTotalCpuParent
            // 
            this.lblTotalCpuParent.AutoSize = true;
            this.lblTotalCpuParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCpuParent.Location = new System.Drawing.Point(238, 348);
            this.lblTotalCpuParent.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCpuParent.Name = "lblTotalCpuParent";
            this.lblTotalCpuParent.Size = new System.Drawing.Size(125, 13);
            this.lblTotalCpuParent.TabIndex = 26;
            this.lblTotalCpuParent.Text = "[TotalCpuParentProcess]";
            this.lblTotalCpuParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CpuPerformanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBoxCPU);
            this.Name = "CpuPerformanceControl";
            this.Size = new System.Drawing.Size(754, 391);
            this.groupBoxCPU.ResumeLayout(false);
            this.groupBoxCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCpu)).EndInit();
            this.ctxChartCpu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCpu;
        private System.Windows.Forms.ContextMenuStrip ctxChartCpu;
        private System.Windows.Forms.ToolStripMenuItem tsCpuViewMode;
        private System.Windows.Forms.ToolStripMenuItem tsOverallUtilization;
        private System.Windows.Forms.ToolStripMenuItem tsLogicalProcessors;
        private ToolTipLabel ttlParentProcessName;
        private ToolTipLabel ttlProcessor;
        private System.Windows.Forms.Label lblTotalCpu;
        private ToolTipLabel toolTipLabel6;
        private ToolTipLabel toolTipLabel7;
        private System.Windows.Forms.Label lblTotalCpuUser;
        private ToolTipLabel ttlTotalCpuProcess;
        private System.Windows.Forms.Label lblTotalCpuParent;
    }
}
