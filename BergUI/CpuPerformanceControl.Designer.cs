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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ttlTotalCpu = new BergUI.ToolTipLabel();
            this.ttlThreads = new BergUI.ToolTipLabel();
            this.lblThreads = new System.Windows.Forms.Label();
            this.lblTotalCpu = new System.Windows.Forms.Label();
            this.lvPerformanceWatches = new BrightIdeasSoftware.ObjectListView();
            this.watchName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.chartCpu = new BergUI.BergChart();
            this.cmbScope = new System.Windows.Forms.ComboBox();
            this.ttlProcessor = new BergUI.ToolTipLabel();
            this.ctxChartCpu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCpuViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOverallUtilization = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogicalProcessors = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCPU.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvPerformanceWatches)).BeginInit();
            this.ctxChartCpu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCPU
            // 
            this.groupBoxCPU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCPU.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxCPU.Controls.Add(this.lvPerformanceWatches);
            this.groupBoxCPU.Controls.Add(this.chartCpu);
            this.groupBoxCPU.Controls.Add(this.cmbScope);
            this.groupBoxCPU.Controls.Add(this.ttlProcessor);
            this.groupBoxCPU.Location = new System.Drawing.Point(2, 3);
            this.groupBoxCPU.Name = "groupBoxCPU";
            this.groupBoxCPU.Size = new System.Drawing.Size(749, 436);
            this.groupBoxCPU.TabIndex = 9;
            this.groupBoxCPU.TabStop = false;
            this.groupBoxCPU.Text = "CPU";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ttlTotalCpu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ttlThreads, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblThreads, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalCpu, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 310);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 42);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // ttlTotalCpu
            // 
            this.ttlTotalCpu.AutoSize = true;
            this.ttlTotalCpu.BackColor = System.Drawing.Color.Transparent;
            this.ttlTotalCpu.Cursor = System.Windows.Forms.Cursors.Default;
            this.ttlTotalCpu.Dock = System.Windows.Forms.DockStyle.Right;
            this.ttlTotalCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlTotalCpu.InfoToolTipEnabled = false;
            this.ttlTotalCpu.InfoToolTipText = "";
            this.ttlTotalCpu.KeyObjectToolTipEnabled = true;
            this.ttlTotalCpu.KeyObjectToolTipText = "";
            this.ttlTotalCpu.Location = new System.Drawing.Point(3, 3);
            this.ttlTotalCpu.Name = "ttlTotalCpu";
            this.ttlTotalCpu.Size = new System.Drawing.Size(137, 13);
            this.ttlTotalCpu.TabIndex = 22;
            this.ttlTotalCpu.Text = "% Cpu Utilization (System):";
            // 
            // ttlThreads
            // 
            this.ttlThreads.AutoSize = true;
            this.ttlThreads.BackColor = System.Drawing.Color.Transparent;
            this.ttlThreads.Cursor = System.Windows.Forms.Cursors.Default;
            this.ttlThreads.Dock = System.Windows.Forms.DockStyle.Right;
            this.ttlThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlThreads.InfoToolTipEnabled = false;
            this.ttlThreads.InfoToolTipText = "";
            this.ttlThreads.KeyObjectToolTipEnabled = true;
            this.ttlThreads.KeyObjectToolTipText = "";
            this.ttlThreads.Location = new System.Drawing.Point(42, 22);
            this.ttlThreads.Name = "ttlThreads";
            this.ttlThreads.Size = new System.Drawing.Size(98, 17);
            this.ttlThreads.TabIndex = 27;
            this.ttlThreads.Text = "Threads (System):";
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreads.Location = new System.Drawing.Point(143, 19);
            this.lblThreads.Margin = new System.Windows.Forms.Padding(0);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(52, 23);
            this.lblThreads.TabIndex = 28;
            this.lblThreads.Text = "[Threads]";
            this.lblThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalCpu
            // 
            this.lblTotalCpu.AutoSize = true;
            this.lblTotalCpu.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCpu.Location = new System.Drawing.Point(143, 0);
            this.lblTotalCpu.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCpu.Name = "lblTotalCpu";
            this.lblTotalCpu.Size = new System.Drawing.Size(56, 19);
            this.lblTotalCpu.TabIndex = 21;
            this.lblTotalCpu.Text = "[TotalCpu]";
            this.lblTotalCpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvPerformanceWatches
            // 
            this.lvPerformanceWatches.AllColumns.Add(this.watchName);
            this.lvPerformanceWatches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPerformanceWatches.CellEditUseWholeCell = false;
            this.lvPerformanceWatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.watchName});
            this.lvPerformanceWatches.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvPerformanceWatches.HasCollapsibleGroups = false;
            this.lvPerformanceWatches.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvPerformanceWatches.Location = new System.Drawing.Point(343, 312);
            this.lvPerformanceWatches.Name = "lvPerformanceWatches";
            this.lvPerformanceWatches.ShowGroups = false;
            this.lvPerformanceWatches.ShowHeaderInAllViews = false;
            this.lvPerformanceWatches.Size = new System.Drawing.Size(307, 97);
            this.lvPerformanceWatches.TabIndex = 31;
            this.lvPerformanceWatches.UseCompatibleStateImageBehavior = false;
            this.lvPerformanceWatches.UseHyperlinks = true;
            this.lvPerformanceWatches.View = System.Windows.Forms.View.List;
            // 
            // watchName
            // 
            this.watchName.AspectName = "Name";
            this.watchName.Groupable = false;
            this.watchName.Hyperlink = true;
            this.watchName.Text = "";
            this.watchName.Width = 1000;
            // 
            // chartCpu
            // 
            this.chartCpu.Location = new System.Drawing.Point(6, 51);
            this.chartCpu.Name = "chartCpu";
            this.chartCpu.Size = new System.Drawing.Size(717, 250);
            this.chartCpu.TabIndex = 30;
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
            // CpuPerformanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBoxCPU);
            this.Name = "CpuPerformanceControl";
            this.Size = new System.Drawing.Size(754, 442);
            this.groupBoxCPU.ResumeLayout(false);
            this.groupBoxCPU.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvPerformanceWatches)).EndInit();
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
        private ToolTipLabel ttlTotalCpu;
        private ToolTipLabel ttlProcessor;
        private BrightIdeasSoftware.ObjectListView lvPerformanceWatches;
        private BrightIdeasSoftware.OLVColumn watchName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
