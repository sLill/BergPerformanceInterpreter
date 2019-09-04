namespace BergUI
{
    partial class LoadingSplash
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressIndicator = new BergUI.ProgressIndicator();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(115, 121);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(187, 12);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Waiting on performance stream..";
            // 
            // progressIndicator
            // 
            this.progressIndicator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressIndicator.CircleColor = System.Drawing.Color.LightBlue;
            this.progressIndicator.CircleSize = 0.5F;
            this.progressIndicator.Location = new System.Drawing.Point(149, -3);
            this.progressIndicator.Name = "progressIndicator";
            this.progressIndicator.NumberOfCircles = 16;
            this.progressIndicator.NumberOfVisibleCircles = 16;
            this.progressIndicator.Percentage = 0F;
            this.progressIndicator.Size = new System.Drawing.Size(117, 117);
            this.progressIndicator.TabIndex = 0;
            // 
            // LoadingSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressIndicator);
            this.Name = "LoadingSplash";
            this.Size = new System.Drawing.Size(416, 173);
            this.Resize += new System.EventHandler(this.LoadingSplash_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressIndicator progressIndicator;
        private System.Windows.Forms.Label lblStatus;
    }
}
