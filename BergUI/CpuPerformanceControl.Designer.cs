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
            this.cmbScope = new System.Windows.Forms.ComboBox();
            this.lblThreads = new System.Windows.Forms.Label();
            this.lblTotalCpu = new System.Windows.Forms.Label();
            this.ctxChartCpu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCpuViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOverallUtilization = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogicalProcessors = new System.Windows.Forms.ToolStripMenuItem();
            this.bergChart1 = new BergUI.BergChart();
            this.toolTipLabel1 = new BergUI.ToolTipLabel();
            this.toolTipLabel6 = new BergUI.ToolTipLabel();
            this.ttlProcessor = new BergUI.ToolTipLabel();
            this.groupBoxCPU.SuspendLayout();
            this.ctxChartCpu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCPU
            // 
            this.groupBoxCPU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCPU.Controls.Add(this.bergChart1);
            this.groupBoxCPU.Controls.Add(this.cmbScope);
            this.groupBoxCPU.Controls.Add(this.lblThreads);
            this.groupBoxCPU.Controls.Add(this.toolTipLabel1);
            this.groupBoxCPU.Controls.Add(this.lblTotalCpu);
            this.groupBoxCPU.Controls.Add(this.toolTipLabel6);
            this.groupBoxCPU.Controls.Add(this.ttlProcessor);
            this.groupBoxCPU.Location = new System.Drawing.Point(2, 3);
            this.groupBoxCPU.Name = "groupBoxCPU";
            this.groupBoxCPU.Size = new System.Drawing.Size(749, 464);
            this.groupBoxCPU.TabIndex = 9;
            this.groupBoxCPU.TabStop = false;
            this.groupBoxCPU.Text = "CPU";
            // 
            // cmbScope
            // 
            this.cmbScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScope.FormattingEnabled = true;
            this.cmbScope.Location = new System.Drawing.Point(57, 39);
            this.cmbScope.Name = "cmbScope";
            this.cmbScope.Size = new System.Drawing.Size(227, 21);
            this.cmbScope.TabIndex = 29;
            this.cmbScope.SelectionChangeCommitted += new System.EventHandler(this.CmbScope_SelectedValueChanged);
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreads.Location = new System.Drawing.Point(139, 345);
            this.lblThreads.Margin = new System.Windows.Forms.Padding(0);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(52, 13);
            this.lblThreads.TabIndex = 28;
            this.lblThreads.Text = "[Threads]";
            this.lblThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalCpu
            // 
            this.lblTotalCpu.AutoSize = true;
            this.lblTotalCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCpu.Location = new System.Drawing.Point(139, 326);
            this.lblTotalCpu.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCpu.Name = "lblTotalCpu";
            this.lblTotalCpu.Size = new System.Drawing.Size(56, 13);
            this.lblTotalCpu.TabIndex = 21;
            this.lblTotalCpu.Text = "[TotalCpu]";
            this.lblTotalCpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // bergChart1
            // 
            this.bergChart1.Location = new System.Drawing.Point(6, 66);
            this.bergChart1.Name = "bergChart1";
            this.bergChart1.Size = new System.Drawing.Size(717, 250);
            this.bergChart1.TabIndex = 30;
            // 
            // toolTipLabel1
            // 
            this.toolTipLabel1.AutoSize = true;
            this.toolTipLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolTipLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel1.InfoToolTipEnabled = false;
            this.toolTipLabel1.InfoToolTipText = "";
            this.toolTipLabel1.KeyObjectToolTipEnabled = true;
            this.toolTipLabel1.KeyObjectToolTipText = "";
            this.toolTipLabel1.Location = new System.Drawing.Point(61, 345);
            this.toolTipLabel1.Name = "toolTipLabel1";
            this.toolTipLabel1.Size = new System.Drawing.Size(58, 13);
            this.toolTipLabel1.TabIndex = 27;
            this.toolTipLabel1.Text = "Threads:";
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
            this.toolTipLabel6.Location = new System.Drawing.Point(61, 326);
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
            this.ttlProcessor.Location = new System.Drawing.Point(449, 42);
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
            this.Size = new System.Drawing.Size(754, 470);
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
        private ToolTipLabel ttlProcessor;
        private System.Windows.Forms.Label lblTotalCpu;
        private ToolTipLabel toolTipLabel6;
        private System.Windows.Forms.Label lblThreads;
        private ToolTipLabel toolTipLabel1;
        private System.Windows.Forms.ComboBox cmbScope;
        private BergChart bergChart1;
    }
}
