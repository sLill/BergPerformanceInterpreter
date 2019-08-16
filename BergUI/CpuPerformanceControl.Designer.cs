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
            this.chartCpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ctxChartCpu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCpuViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOverallUtilization = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogicalProcessors = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelCpuDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalCpu = new System.Windows.Forms.Label();
            this.lblLogicalProcessors = new System.Windows.Forms.Label();
            this.lblCores = new System.Windows.Forms.Label();
            this.lblThreads = new System.Windows.Forms.Label();
            this.lblTotalCpuUser = new System.Windows.Forms.Label();
            this.ttlParentProcessName = new BergUI.ToolTipLabel();
            this.toolTipLabel4 = new BergUI.ToolTipLabel();
            this.toolTipLabel5 = new BergUI.ToolTipLabel();
            this.toolTipLabel6 = new BergUI.ToolTipLabel();
            this.toolTipLabel7 = new BergUI.ToolTipLabel();
            this.toolTipLabel8 = new BergUI.ToolTipLabel();
            this.groupBoxCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCpu)).BeginInit();
            this.ctxChartCpu.SuspendLayout();
            this.tableLayoutPanelCpuDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCPU
            // 
            this.groupBoxCPU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCPU.Controls.Add(this.ttlParentProcessName);
            this.groupBoxCPU.Controls.Add(this.chartCpu);
            this.groupBoxCPU.Controls.Add(this.tableLayoutPanelCpuDetails);
            this.groupBoxCPU.Location = new System.Drawing.Point(2, 3);
            this.groupBoxCPU.Name = "groupBoxCPU";
            this.groupBoxCPU.Size = new System.Drawing.Size(749, 385);
            this.groupBoxCPU.TabIndex = 9;
            this.groupBoxCPU.TabStop = false;
            this.groupBoxCPU.Text = "CPU";
            // 
            // chartCpu
            // 
            this.chartCpu.BackColor = System.Drawing.Color.Transparent;
            this.chartCpu.ContextMenuStrip = this.ctxChartCpu;
            this.chartCpu.Location = new System.Drawing.Point(-14, 31);
            this.chartCpu.Margin = new System.Windows.Forms.Padding(0);
            this.chartCpu.Name = "chartCpu";
            this.chartCpu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartCpu.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))))};
            this.chartCpu.Size = new System.Drawing.Size(715, 276);
            this.chartCpu.TabIndex = 15;
            this.chartCpu.Text = "chart1";
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
            // tableLayoutPanelCpuDetails
            // 
            this.tableLayoutPanelCpuDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelCpuDetails.ColumnCount = 6;
            this.tableLayoutPanelCpuDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanelCpuDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanelCpuDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanelCpuDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanelCpuDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanelCpuDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCpuDetails.Controls.Add(this.toolTipLabel4, 0, 1);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.lblTotalCpu, 3, 0);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.toolTipLabel5, 0, 0);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.lblLogicalProcessors, 1, 1);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.lblCores, 1, 0);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.lblThreads, 5, 0);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.toolTipLabel6, 2, 0);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.toolTipLabel7, 2, 1);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.toolTipLabel8, 4, 0);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.lblTotalCpuUser, 3, 1);
            this.tableLayoutPanelCpuDetails.Location = new System.Drawing.Point(61, 310);
            this.tableLayoutPanelCpuDetails.Name = "tableLayoutPanelCpuDetails";
            this.tableLayoutPanelCpuDetails.RowCount = 3;
            this.tableLayoutPanelCpuDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCpuDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCpuDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCpuDetails.Size = new System.Drawing.Size(619, 47);
            this.tableLayoutPanelCpuDetails.TabIndex = 18;
            // 
            // lblTotalCpu
            // 
            this.lblTotalCpu.AutoSize = true;
            this.lblTotalCpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCpu.Location = new System.Drawing.Point(292, 0);
            this.lblTotalCpu.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCpu.Name = "lblTotalCpu";
            this.lblTotalCpu.Size = new System.Drawing.Size(68, 20);
            this.lblTotalCpu.TabIndex = 7;
            this.lblTotalCpu.Text = "-";
            this.lblTotalCpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLogicalProcessors
            // 
            this.lblLogicalProcessors.AutoSize = true;
            this.lblLogicalProcessors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogicalProcessors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogicalProcessors.Location = new System.Drawing.Point(111, 20);
            this.lblLogicalProcessors.Name = "lblLogicalProcessors";
            this.lblLogicalProcessors.Size = new System.Drawing.Size(46, 20);
            this.lblLogicalProcessors.TabIndex = 4;
            this.lblLogicalProcessors.Text = "-";
            this.lblLogicalProcessors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCores
            // 
            this.lblCores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCores.Location = new System.Drawing.Point(111, 0);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(46, 20);
            this.lblCores.TabIndex = 3;
            this.lblCores.Text = "-";
            this.lblCores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreads.Location = new System.Drawing.Point(487, 0);
            this.lblThreads.Margin = new System.Windows.Forms.Padding(0);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(132, 20);
            this.lblThreads.TabIndex = 8;
            this.lblThreads.Text = "-";
            this.lblThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalCpuUser
            // 
            this.lblTotalCpuUser.AutoSize = true;
            this.lblTotalCpuUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCpuUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCpuUser.Location = new System.Drawing.Point(292, 20);
            this.lblTotalCpuUser.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCpuUser.Name = "lblTotalCpuUser";
            this.lblTotalCpuUser.Size = new System.Drawing.Size(68, 20);
            this.lblTotalCpuUser.TabIndex = 13;
            this.lblTotalCpuUser.Text = "-";
            this.lblTotalCpuUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ttlParentProcessName
            // 
            this.ttlParentProcessName.AutoSize = true;
            this.ttlParentProcessName.BackColor = System.Drawing.Color.Transparent;
            this.ttlParentProcessName.Location = new System.Drawing.Point(24, 16);
            this.ttlParentProcessName.Name = "ttlParentProcessName";
            this.ttlParentProcessName.Size = new System.Drawing.Size(77, 13);
            this.ttlParentProcessName.TabIndex = 19;
            this.ttlParentProcessName.Text = "-";
            this.ttlParentProcessName.ToolTipEnabled = false;
            this.ttlParentProcessName.ToolTipText = "";
            // 
            // toolTipLabel4
            // 
            this.toolTipLabel4.AutoSize = true;
            this.toolTipLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolTipLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel4.Location = new System.Drawing.Point(3, 23);
            this.toolTipLabel4.Name = "toolTipLabel4";
            this.toolTipLabel4.Size = new System.Drawing.Size(102, 13);
            this.toolTipLabel4.TabIndex = 9;
            this.toolTipLabel4.Text = "Logical Processors:";
            this.toolTipLabel4.ToolTipEnabled = true;
            this.toolTipLabel4.ToolTipText = "Typically equal to twice the number of physical cpu cores when hyperthreading is " +
    "enabled";
            // 
            // toolTipLabel5
            // 
            this.toolTipLabel5.AutoSize = true;
            this.toolTipLabel5.BackColor = System.Drawing.Color.Transparent;
            this.toolTipLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel5.Location = new System.Drawing.Point(3, 3);
            this.toolTipLabel5.Name = "toolTipLabel5";
            this.toolTipLabel5.Size = new System.Drawing.Size(43, 13);
            this.toolTipLabel5.TabIndex = 1;
            this.toolTipLabel5.Text = "Cores:";
            this.toolTipLabel5.ToolTipEnabled = false;
            this.toolTipLabel5.ToolTipText = "things and stuff";
            // 
            // toolTipLabel6
            // 
            this.toolTipLabel6.AutoSize = true;
            this.toolTipLabel6.BackColor = System.Drawing.Color.Transparent;
            this.toolTipLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolTipLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel6.Location = new System.Drawing.Point(163, 3);
            this.toolTipLabel6.Name = "toolTipLabel6";
            this.toolTipLabel6.Size = new System.Drawing.Size(126, 14);
            this.toolTipLabel6.TabIndex = 10;
            this.toolTipLabel6.Text = "Total CPU Usage";
            this.toolTipLabel6.ToolTipEnabled = false;
            this.toolTipLabel6.ToolTipText = "";
            // 
            // toolTipLabel7
            // 
            this.toolTipLabel7.AutoSize = true;
            this.toolTipLabel7.BackColor = System.Drawing.Color.Transparent;
            this.toolTipLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolTipLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel7.Location = new System.Drawing.Point(163, 23);
            this.toolTipLabel7.Name = "toolTipLabel7";
            this.toolTipLabel7.Size = new System.Drawing.Size(126, 14);
            this.toolTipLabel7.TabIndex = 11;
            this.toolTipLabel7.Text = "Total CPU Usage (User):";
            this.toolTipLabel7.ToolTipEnabled = true;
            this.toolTipLabel7.ToolTipText = "Time spent working on user applications and user environment specific processes";
            // 
            // toolTipLabel8
            // 
            this.toolTipLabel8.AutoSize = true;
            this.toolTipLabel8.BackColor = System.Drawing.Color.Transparent;
            this.toolTipLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolTipLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel8.Location = new System.Drawing.Point(363, 3);
            this.toolTipLabel8.Name = "toolTipLabel8";
            this.toolTipLabel8.Size = new System.Drawing.Size(121, 14);
            this.toolTipLabel8.TabIndex = 12;
            this.toolTipLabel8.Text = "Threads:";
            this.toolTipLabel8.ToolTipEnabled = false;
            this.toolTipLabel8.ToolTipText = "The number";
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
            this.tableLayoutPanelCpuDetails.ResumeLayout(false);
            this.tableLayoutPanelCpuDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCpu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCpuDetails;
        private ToolTipLabel toolTipLabel4;
        private System.Windows.Forms.Label lblTotalCpu;
        private ToolTipLabel toolTipLabel5;
        private System.Windows.Forms.Label lblLogicalProcessors;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.Label lblThreads;
        private ToolTipLabel toolTipLabel6;
        private ToolTipLabel toolTipLabel7;
        private ToolTipLabel toolTipLabel8;
        private System.Windows.Forms.Label lblTotalCpuUser;
        private System.Windows.Forms.ContextMenuStrip ctxChartCpu;
        private System.Windows.Forms.ToolStripMenuItem tsCpuViewMode;
        private System.Windows.Forms.ToolStripMenuItem tsOverallUtilization;
        private System.Windows.Forms.ToolStripMenuItem tsLogicalProcessors;
        private ToolTipLabel ttlParentProcessName;
    }
}
