namespace BergUI
{
    partial class BergChart
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
            this.lblAxisYTitle = new System.Windows.Forms.Label();
            this.chartBase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartBase)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAxisYTitle
            // 
            this.lblAxisYTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAxisYTitle.AutoSize = true;
            this.lblAxisYTitle.Location = new System.Drawing.Point(1, 116);
            this.lblAxisYTitle.Name = "lblAxisYTitle";
            this.lblAxisYTitle.Size = new System.Drawing.Size(15, 13);
            this.lblAxisYTitle.TabIndex = 34;
            this.lblAxisYTitle.Text = "%";
            this.lblAxisYTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chartBase
            // 
            this.chartBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartBase.BackColor = System.Drawing.Color.Transparent;
            this.chartBase.Location = new System.Drawing.Point(-11, -6);
            this.chartBase.Margin = new System.Windows.Forms.Padding(0);
            this.chartBase.Name = "chartBase";
            this.chartBase.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartBase.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))))};
            this.chartBase.Size = new System.Drawing.Size(670, 274);
            this.chartBase.TabIndex = 33;
            this.chartBase.Text = "chart1";
            this.chartBase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChartBase_MouseMove);
            this.chartBase.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.ChartBase_MouseWheel);
            // 
            // BergChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAxisYTitle);
            this.Controls.Add(this.chartBase);
            this.Name = "BergChart";
            this.Size = new System.Drawing.Size(659, 265);
            ((System.ComponentModel.ISupportInitialize)(this.chartBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxisYTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBase;
    }
}
