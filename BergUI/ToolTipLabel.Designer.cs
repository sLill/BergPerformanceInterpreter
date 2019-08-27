namespace BergUI
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
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.lblTextValue = new System.Windows.Forms.Label();
            this.toolTipKeyObject = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.AutomaticDelay = 100;
            this.toolTipInfo.AutoPopDelay = 32767;
            this.toolTipInfo.InitialDelay = 100;
            this.toolTipInfo.IsBalloon = true;
            this.toolTipInfo.ReshowDelay = 20;
            this.toolTipInfo.UseAnimation = false;
            this.toolTipInfo.UseFading = false;
            // 
            // pbInfo
            // 
            this.pbInfo.BackColor = System.Drawing.Color.Transparent;
            this.pbInfo.Image = global::BergUI.Properties.Resources.tooltip_info;
            this.pbInfo.Location = new System.Drawing.Point(0, 0);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(8, 8);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInfo.TabIndex = 4;
            this.pbInfo.TabStop = false;
            this.pbInfo.MouseHover += new System.EventHandler(this.PbTooltip_MouseHover);
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
            this.lblTextValue.MouseHover += new System.EventHandler(this.LblTextValue_MouseHover);
            // 
            // toolTipKeyObject
            // 
            this.toolTipKeyObject.AutomaticDelay = 100;
            this.toolTipKeyObject.AutoPopDelay = 32767;
            this.toolTipKeyObject.InitialDelay = 100;
            this.toolTipKeyObject.IsBalloon = true;
            this.toolTipKeyObject.ReshowDelay = 20;
            this.toolTipKeyObject.UseAnimation = false;
            this.toolTipKeyObject.UseFading = false;
            // 
            // ToolTipLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbInfo);
            this.Controls.Add(this.lblTextValue);
            this.Name = "ToolTipLabel";
            this.Size = new System.Drawing.Size(87, 17);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.Label lblTextValue;
        private System.Windows.Forms.ToolTip toolTipKeyObject;
    }
}
