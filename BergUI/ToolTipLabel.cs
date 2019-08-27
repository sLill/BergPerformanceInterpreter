using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BergUI
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

        #region KeyObjectToolTipEnabled
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true), DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool KeyObjectToolTipEnabled
        {
            get { return toolTipKeyObject.Active; }
            set { toolTipKeyObject.Active = value; }
        }
        #endregion KeyObjectToolTipEnabled

        #region KeyObjectToolTipText
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string KeyObjectToolTipText
        {
            get { return toolTipKeyObject.GetToolTip(lblTextValue); }
            set { toolTipKeyObject.SetToolTip(lblTextValue, value); }
        }
        #endregion KeyObjectToolTipText

        #region InfoToolTipEnabled
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool InfoToolTipEnabled
        {
            get { return pbInfo.Visible; }
            set { pbInfo.Visible = value; }
        }
        #endregion InfoToolTipEnabled

        #region InfoToolTipText
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string InfoToolTipText
        {
            get { return toolTipInfo.GetToolTip(pbInfo); }
            set { toolTipInfo.SetToolTip(pbInfo, value); }
        }
        #endregion InfoToolTipText
        #endregion Properties..

        #region Constructors..
        #region ToolTipLabel
        public ToolTipLabel()
        {
            InitializeComponent();
        }
        #endregion ToolTipLabel
        #endregion Constructors..

        #region Methods..
        #region Events..
        #region LblTextValue_MouseHover
        private void LblTextValue_MouseHover(object sender, EventArgs e)
        {

        }
        #endregion LblTextValue_MouseHover

        #region PbTooltip_MouseHover
        private void PbTooltip_MouseHover(object sender, EventArgs e)
        {

        }
        #endregion PbTooltip_MouseHover
        #endregion Events..

        #endregion Methods..
    }
}
