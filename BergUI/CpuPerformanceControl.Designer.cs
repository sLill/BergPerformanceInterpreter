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
            this.ctxChartCpu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCpuViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOverallUtilization = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogicalProcessors = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotalCpu = new System.Windows.Forms.Label();
            this.lblThreads = new System.Windows.Forms.Label();
            this.cmbScope = new System.Windows.Forms.ComboBox();
            this.chartCpu = new BergUI.BergChart();
            this.ttlThreads = new BergUI.ToolTipLabel();
            this.toolTipLabel6 = new BergUI.ToolTipLabel();
            this.ttlProcessor = new BergUI.ToolTipLabel();
            this.groupBoxCPU.SuspendLayout();
            this.ctxChartCpu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCPU
            // 
            this.groupBoxCPU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCPU.Controls.Add(this.chartCpu);
            this.groupBoxCPU.Controls.Add(this.cmbScope);
            this.groupBoxCPU.Controls.Add(this.lblThreads);
            this.groupBoxCPU.Controls.Add(this.ttlThreads);
            this.groupBoxCPU.Controls.Add(this.lblTotalCpu);
            this.groupBoxCPU.Controls.Add(this.toolTipLabel6);
            this.groupBoxCPU.Controls.Add(this.ttlProcessor);
            this.groupBoxCPU.Location = new System.Drawing.Point(2, 3);
            this.groupBoxCPU.Name = "groupBoxCPU";
            this.groupBoxCPU.Size = new System.Drawing.Size(749, 371);
            this.groupBoxCPU.TabIndex = 9;
            this.groupBoxCPU.TabStop = false;
            this.groupBoxCPU.Text = "CPU";
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
            // lblTotalCpu
            // 
            this.lblTotalCpu.AutoSize = true;
            this.lblTotalCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCpu.Location = new System.Drawing.Point(139, 311);
            this.lblTotalCpu.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCpu.Name = "lblTotalCpu";
            this.lblTotalCpu.Size = new System.Drawing.Size(56, 13);
            this.lblTotalCpu.TabIndex = 21;
            this.lblTotalCpu.Text = "[TotalCpu]";
            this.lblTotalCpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreads.Location = new System.Drawing.Point(139, 330);
            this.lblThreads.Margin = new System.Windows.Forms.Padding(0);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(52, 13);
            this.lblThreads.TabIndex = 28;
            this.lblThreads.Text = "[Threads]";
            this.lblThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbScope
            // 
            this.cmbScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScope.FormattingEnabled = true;
            this.cmbScope.Location = new System.Drawing.Point(57, 24);
            this.cmbScope.Name = "cmbScope";
            this.cmbScope.Size = new System.Drawing.Size(227, 21);
            this.cmbScope.TabIndex = 29;
            this.cmbScope.SelectionChangeCommitted += new System.EventHandler(this.CmbScope_SelectedValueChanged);
            // 
            // chartCpu
            // 
            this.chartCpu.Location = new System.Drawing.Point(6, 51);
            this.chartCpu.Name = "chartCpu";
            this.chartCpu.Size = new System.Drawing.Size(717, 250);
            this.chartCpu.TabIndex = 30;
            // 
            // ttlThreads
            // 
            this.ttlThreads.AutoSize = true;
            this.ttlThreads.BackColor = System.Drawing.Color.Transparent;
            this.ttlThreads.Cursor = System.Windows.Forms.Cursors.Default;
            this.ttlThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlThreads.InfoToolTipEnabled = false;
            this.ttlThreads.InfoToolTipText = "";
            this.ttlThreads.KeyObjectToolTipEnabled = true;
            this.ttlThreads.KeyObjectToolTipText = "";
            this.ttlThreads.Location = new System.Drawing.Point(61, 330);
            this.ttlThreads.Name = "ttlThreads";
            this.ttlThreads.Size = new System.Drawing.Size(58, 13);
            this.ttlThreads.TabIndex = 27;
            this.ttlThreads.Text = "Threads:";
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
            this.toolTipLabel6.Size = new System.Drawing.Size(83, 13);
            this.toolTipLabel6.TabIndex = 22;
            this.toolTipLabel6.Text = "% Utilization:";
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
            this.ttlProcessor.Location = new System.Drawing.Point(449, 27);
            this.ttlProcessor.Name = "ttlProcessor";
            this.ttlProcessor.Size = new System.Drawing.Size(77, 13);
            this.ttlProcessor.TabIndex = 20;
            this.ttlProcessor.Text = "[Processor]";
            // 
            // CpuPerformanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBoxCPU);
            this.Name = "CpuPerformanceControl";
            this.Size = new System.Drawing.Size(754, 377);
            this.groupBoxCPU.ResumeLayout(false);
            this.groupBoxCPU.PerformLayout();
            this.ctxChartCpu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCPU;
        private System.Windows.Forms.ContextMenuStrip ctxChartCpu;
        private System.Windows.Forms.ToolStripMenuItem tsCpuViewMode;
        private System.Windows.Forms.ToolStripMenuItem tsOverallUtilization;
        private System.Windows.Forms.ToolStripMenuItem tsLogicalProcessors;
        private BergChart chartCpu;
        private System.Windows.Forms.ComboBox cmbScope;
        private System.Windows.Forms.Label lblThreads;
        private ToolTipLabel ttlThreads;
        private System.Windows.Forms.Label lblTotalCpu;
        private ToolTipLabel toolTipLabel6;
        private ToolTipLabel ttlProcessor;
    }
}
