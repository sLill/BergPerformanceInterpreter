namespace BergPerformanceDashboard
{
    partial class ToolTipLabel
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pbTooltip = new System.Windows.Forms.PictureBox();
            this.lblTextValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTooltip)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            this.toolTip.UseAnimation = false;
            this.toolTip.UseFading = false;
            // 
            // pbTooltip
            // 
            this.pbTooltip.BackColor = System.Drawing.Color.Transparent;
            this.pbTooltip.Image = global::BergPerformanceDashboard.Properties.Resources.tooltip_info;
            this.pbTooltip.Location = new System.Drawing.Point(0, 0);
            this.pbTooltip.Name = "pbTooltip";
            this.pbTooltip.Size = new System.Drawing.Size(8, 8);
            this.pbTooltip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTooltip.TabIndex = 4;
            this.pbTooltip.TabStop = false;
            // 
            // lblTextValue
            // 
            this.lblTextValue.AutoSize = true;
            this.lblTextValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTextValue.Location = new System.Drawing.Point(6, 0);
            this.lblTextValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblTextValue.Name = "lblTextValue";
            this.lblTextValue.Size = new System.Drawing.Size(65, 13);
            this.lblTextValue.TabIndex = 3;
            this.lblTextValue.Text = "TooltipLabel";
            this.lblTextValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolTipLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbTooltip);
            this.Controls.Add(this.lblTextValue);
            this.Name = "ToolTipLabel";
            this.Size = new System.Drawing.Size(87, 17);
            ((System.ComponentModel.ISupportInitialize)(this.pbTooltip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pbTooltip;
        private System.Windows.Forms.Label lblTextValue;
    }
}
