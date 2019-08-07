using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BergPerformanceDashboard
{
    public partial class ToolTipLabel : UserControl
    {
        #region Properties..
        #region Text
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return lblTextValue.Text; }
            set { lblTextValue.Text = value; }
        }
        #endregion Text

        #region ToolTipText
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ToolTipText
        {
            get { return toolTip.GetToolTip(pbTooltip); }
            set { toolTip.SetToolTip(pbTooltip, value); }
        }
        #endregion ToolTipText

        #region ToolTipEnabled
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ToolTipEnabled
        {
            get { return pbTooltip.Visible; }
            set { pbTooltip.Visible = value; }
        }
        #endregion ToolTipEnabled
        #endregion Properties..

        #region Constructors..
        public ToolTipLabel()
        {
            InitializeComponent();
        }
        #endregion Constructors..

        #region Methods..
        #region Events..
        #region pbTooltip_MouseHover
        private void pbTooltip_MouseHover(object sender, EventArgs e)
        {

        }
        #endregion pbTooltip_MouseHover
        #endregion Events..
        #endregion Methods..
    }
}
