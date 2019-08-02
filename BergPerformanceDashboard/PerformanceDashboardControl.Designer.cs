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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxPerformanceDashboard = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelPerformanceDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCPU = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelCPU = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelCPUDetails = new System.Windows.Forms.TableLayoutPanel();
            this.toolTipLabelLogicalCores = new BergPerformanceDashboard.ToolTipLabel();
            this.lblTotalCPU = new System.Windows.Forms.Label();
            this.toolTipLabelCores = new BergPerformanceDashboard.ToolTipLabel();
            this.lblLogicalProcessors = new System.Windows.Forms.Label();
            this.lblCores = new System.Windows.Forms.Label();
            this.lblThreadCount = new System.Windows.Forms.Label();
            this.chartLogicalProcessingUnits = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTipLabel1 = new BergPerformanceDashboard.ToolTipLabel();
            this.toolTipLabel2 = new BergPerformanceDashboard.ToolTipLabel();
            this.toolTipLabel3 = new BergPerformanceDashboard.ToolTipLabel();
            this.lblTotalCpuUser = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxPerformanceDashboard.SuspendLayout();
            this.tableLayoutPanelPerformanceDashboard.SuspendLayout();
            this.groupBoxCPU.SuspendLayout();
            this.tableLayoutPanelCPU.SuspendLayout();
            this.tableLayoutPanelCPUDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLogicalProcessingUnits)).BeginInit();
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
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(779, 582);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxPerformanceDashboard
            // 
            this.groupBoxPerformanceDashboard.Controls.Add(this.tableLayoutPanelPerformanceDashboard);
            this.groupBoxPerformanceDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPerformanceDashboard.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPerformanceDashboard.Name = "groupBoxPerformanceDashboard";
            this.groupBoxPerformanceDashboard.Size = new System.Drawing.Size(689, 524);
            this.groupBoxPerformanceDashboard.TabIndex = 1;
            this.groupBoxPerformanceDashboard.TabStop = false;
            this.groupBoxPerformanceDashboard.Text = "Performance Dashboard";
            // 
            // tableLayoutPanelPerformanceDashboard
            // 
            this.tableLayoutPanelPerformanceDashboard.ColumnCount = 1;
            this.tableLayoutPanelPerformanceDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPerformanceDashboard.Controls.Add(this.groupBoxCPU, 0, 0);
            this.tableLayoutPanelPerformanceDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPerformanceDashboard.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelPerformanceDashboard.Name = "tableLayoutPanelPerformanceDashboard";
            this.tableLayoutPanelPerformanceDashboard.RowCount = 2;
            this.tableLayoutPanelPerformanceDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPerformanceDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPerformanceDashboard.Size = new System.Drawing.Size(683, 505);
            this.tableLayoutPanelPerformanceDashboard.TabIndex = 1;
            // 
            // groupBoxCPU
            // 
            this.groupBoxCPU.Controls.Add(this.tableLayoutPanelCPU);
            this.groupBoxCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCPU.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCPU.Name = "groupBoxCPU";
            this.groupBoxCPU.Size = new System.Drawing.Size(677, 300);
            this.groupBoxCPU.TabIndex = 0;
            this.groupBoxCPU.TabStop = false;
            this.groupBoxCPU.Text = "CPU";
            // 
            // tableLayoutPanelCPU
            // 
            this.tableLayoutPanelCPU.ColumnCount = 1;
            this.tableLayoutPanelCPU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCPU.Controls.Add(this.tableLayoutPanelCPUDetails, 0, 1);
            this.tableLayoutPanelCPU.Controls.Add(this.chartLogicalProcessingUnits, 0, 0);
            this.tableLayoutPanelCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCPU.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelCPU.Name = "tableLayoutPanelCPU";
            this.tableLayoutPanelCPU.RowCount = 3;
            this.tableLayoutPanelCPU.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCPU.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCPU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCPU.Size = new System.Drawing.Size(671, 281);
            this.tableLayoutPanelCPU.TabIndex = 2;
            // 
            // tableLayoutPanelCPUDetails
            // 
            this.tableLayoutPanelCPUDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelCPUDetails.ColumnCount = 6;
            this.tableLayoutPanelCPUDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanelCPUDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanelCPUDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanelCPUDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanelCPUDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanelCPUDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCPUDetails.Controls.Add(this.toolTipLabelLogicalCores, 0, 1);
            this.tableLayoutPanelCPUDetails.Controls.Add(this.lblTotalCPU, 3, 0);
            this.tableLayoutPanelCPUDetails.Controls.Add(this.toolTipLabelCores, 0, 0);
            this.tableLayoutPanelCPUDetails.Controls.Add(this.lblLogicalProcessors, 1, 1);
            this.tableLayoutPanelCPUDetails.Controls.Add(this.lblCores, 1, 0);
            this.tableLayoutPanelCPUDetails.Controls.Add(this.lblThreadCount, 5, 0);
            this.tableLayoutPanelCPUDetails.Controls.Add(this.toolTipLabel1, 2, 0);
            this.tableLayoutPanelCPUDetails.Controls.Add(this.toolTipLabel2, 2, 1);
            this.tableLayoutPanelCPUDetails.Controls.Add(this.toolTipLabel3, 4, 0);
            this.tableLayoutPanelCPUDetails.Controls.Add(this.lblTotalCpuUser, 3, 1);
            this.tableLayoutPanelCPUDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCPUDetails.Location = new System.Drawing.Point(3, 231);
            this.tableLayoutPanelCPUDetails.Name = "tableLayoutPanelCPUDetails";
            this.tableLayoutPanelCPUDetails.RowCount = 3;
            this.tableLayoutPanelCPUDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCPUDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCPUDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCPUDetails.Size = new System.Drawing.Size(665, 47);
            this.tableLayoutPanelCPUDetails.TabIndex = 2;
            // 
            // toolTipLabelLogicalCores
            // 
            this.toolTipLabelLogicalCores.AutoSize = true;
            this.toolTipLabelLogicalCores.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabelLogicalCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabelLogicalCores.Location = new System.Drawing.Point(3, 23);
            this.toolTipLabelLogicalCores.Name = "toolTipLabelLogicalCores";
            this.toolTipLabelLogicalCores.Size = new System.Drawing.Size(80, 14);
            this.toolTipLabelLogicalCores.TabIndex = 9;
            this.toolTipLabelLogicalCores.Text = "Logical Cores:";
            this.toolTipLabelLogicalCores.ToolTipEnabled = true;
            this.toolTipLabelLogicalCores.ToolTipText = "Equal to 2x the number of physical cpu cores when hyperthreading is enabled";
            // 
            // lblTotalCPU
            // 
            this.lblTotalCPU.AutoSize = true;
            this.lblTotalCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCPU.Location = new System.Drawing.Point(292, 0);
            this.lblTotalCPU.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCPU.Name = "lblTotalCPU";
            this.lblTotalCPU.Size = new System.Drawing.Size(107, 20);
            this.lblTotalCPU.TabIndex = 7;
            this.lblTotalCPU.Text = "-";
            this.lblTotalCPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTipLabelCores
            // 
            this.toolTipLabelCores.AutoSize = true;
            this.toolTipLabelCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabelCores.Location = new System.Drawing.Point(3, 3);
            this.toolTipLabelCores.Name = "toolTipLabelCores";
            this.toolTipLabelCores.Size = new System.Drawing.Size(47, 14);
            this.toolTipLabelCores.TabIndex = 1;
            this.toolTipLabelCores.Text = "Cores:";
            this.toolTipLabelCores.ToolTipEnabled = false;
            this.toolTipLabelCores.ToolTipText = "things and stuff";
            // 
            // lblLogicalProcessors
            // 
            this.lblLogicalProcessors.AutoSize = true;
            this.lblLogicalProcessors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogicalProcessors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogicalProcessors.Location = new System.Drawing.Point(89, 20);
            this.lblLogicalProcessors.Name = "lblLogicalProcessors";
            this.lblLogicalProcessors.Size = new System.Drawing.Size(68, 20);
            this.lblLogicalProcessors.TabIndex = 4;
            this.lblLogicalProcessors.Text = "-";
            this.lblLogicalProcessors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCores
            // 
            this.lblCores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCores.Location = new System.Drawing.Point(89, 0);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(68, 20);
            this.lblCores.TabIndex = 3;
            this.lblCores.Text = "-";
            this.lblCores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThreadCount
            // 
            this.lblThreadCount.AutoSize = true;
            this.lblThreadCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThreadCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreadCount.Location = new System.Drawing.Point(559, 0);
            this.lblThreadCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblThreadCount.Name = "lblThreadCount";
            this.lblThreadCount.Size = new System.Drawing.Size(106, 20);
            this.lblThreadCount.TabIndex = 8;
            this.lblThreadCount.Text = "-";
            this.lblThreadCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chartLogicalProcessingUnits
            // 
            this.chartLogicalProcessingUnits.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartLogicalProcessingUnits.ChartAreas.Add(chartArea3);
            this.chartLogicalProcessingUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartLogicalProcessingUnits.Location = new System.Drawing.Point(3, 3);
            this.chartLogicalProcessingUnits.Name = "chartLogicalProcessingUnits";
            this.chartLogicalProcessingUnits.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartLogicalProcessingUnits.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))))};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Name = "Series1";
            this.chartLogicalProcessingUnits.Series.Add(series3);
            this.chartLogicalProcessingUnits.Size = new System.Drawing.Size(665, 222);
            this.chartLogicalProcessingUnits.TabIndex = 3;
            this.chartLogicalProcessingUnits.Text = "chart1";
            // 
            // toolTipLabel1
            // 
            this.toolTipLabel1.AutoSize = true;
            this.toolTipLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolTipLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel1.Location = new System.Drawing.Point(163, 3);
            this.toolTipLabel1.Name = "toolTipLabel1";
            this.toolTipLabel1.Size = new System.Drawing.Size(126, 14);
            this.toolTipLabel1.TabIndex = 10;
            this.toolTipLabel1.Text = "Total CPU Usage";
            this.toolTipLabel1.ToolTipEnabled = true;
            this.toolTipLabel1.ToolTipText = "The number";
            // 
            // toolTipLabel2
            // 
            this.toolTipLabel2.AutoSize = true;
            this.toolTipLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolTipLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel2.Location = new System.Drawing.Point(163, 23);
            this.toolTipLabel2.Name = "toolTipLabel2";
            this.toolTipLabel2.Size = new System.Drawing.Size(126, 14);
            this.toolTipLabel2.TabIndex = 11;
            this.toolTipLabel2.Text = "Total CPU Usage (User):";
            this.toolTipLabel2.ToolTipEnabled = true;
            this.toolTipLabel2.ToolTipText = "The number";
            // 
            // toolTipLabel3
            // 
            this.toolTipLabel3.AutoSize = true;
            this.toolTipLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolTipLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel3.Location = new System.Drawing.Point(402, 3);
            this.toolTipLabel3.Name = "toolTipLabel3";
            this.toolTipLabel3.Size = new System.Drawing.Size(154, 14);
            this.toolTipLabel3.TabIndex = 12;
            this.toolTipLabel3.Text = "Threads";
            this.toolTipLabel3.ToolTipEnabled = false;
            this.toolTipLabel3.ToolTipText = "The number";
            // 
            // lblTotalCpuUser
            // 
            this.lblTotalCpuUser.AutoSize = true;
            this.lblTotalCpuUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCpuUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCpuUser.Location = new System.Drawing.Point(292, 20);
            this.lblTotalCpuUser.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCpuUser.Name = "lblTotalCpuUser";
            this.lblTotalCpuUser.Size = new System.Drawing.Size(107, 20);
            this.lblTotalCpuUser.TabIndex = 13;
            this.lblTotalCpuUser.Text = "-";
            this.lblTotalCpuUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BergPerformanceDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "BergPerformanceDashboardControl";
            this.Size = new System.Drawing.Size(779, 582);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.groupBoxPerformanceDashboard.ResumeLayout(false);
            this.tableLayoutPanelPerformanceDashboard.ResumeLayout(false);
            this.groupBoxCPU.ResumeLayout(false);
            this.tableLayoutPanelCPU.ResumeLayout(false);
            this.tableLayoutPanelCPUDetails.ResumeLayout(false);
            this.tableLayoutPanelCPUDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLogicalProcessingUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxPerformanceDashboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPerformanceDashboard;
        private System.Windows.Forms.GroupBox groupBoxCPU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCPU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCPUDetails;
        private System.Windows.Forms.Label lblLogicalProcessors;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLogicalProcessingUnits;
        private System.Windows.Forms.Label lblThreadCount;
        private System.Windows.Forms.Label lblTotalCPU;
        private ToolTipLabel toolTipLabelCores;
        private ToolTipLabel toolTipLabelLogicalCores;
        private ToolTipLabel toolTipLabel1;
        private ToolTipLabel toolTipLabel2;
        private ToolTipLabel toolTipLabel3;
        private System.Windows.Forms.Label lblTotalCpuUser;
    }
}
