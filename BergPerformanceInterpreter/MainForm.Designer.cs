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
            this.tableLayoutPanelBackground = new System.Windows.Forms.TableLayoutPanel();
            this.bergPerformanceDashboardControl1 = new BergPerformanceDashboard.BergPerformanceDashboardControl();
            this.tableLayoutPanelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBackground
            // 
            this.tableLayoutPanelBackground.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelBackground.ColumnCount = 2;
            this.tableLayoutPanelBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBackground.Controls.Add(this.bergPerformanceDashboardControl1, 0, 0);
            this.tableLayoutPanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBackground.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBackground.Name = "tableLayoutPanelBackground";
            this.tableLayoutPanelBackground.RowCount = 1;
            this.tableLayoutPanelBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBackground.Size = new System.Drawing.Size(1102, 678);
            this.tableLayoutPanelBackground.TabIndex = 0;
            // 
            // bergPerformanceDashboardControl1
            // 
            this.bergPerformanceDashboardControl1.Location = new System.Drawing.Point(3, 3);
            this.bergPerformanceDashboardControl1.Name = "bergPerformanceDashboardControl1";
            this.bergPerformanceDashboardControl1.Size = new System.Drawing.Size(1099, 672);
            this.bergPerformanceDashboardControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 678);
            this.Controls.Add(this.tableLayoutPanelBackground);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Berg Performance Interpreter";
            this.tableLayoutPanelBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBackground;
        private BergPerformanceDashboard.BergPerformanceDashboardControl bergPerformanceDashboardControl1;
    }
}

