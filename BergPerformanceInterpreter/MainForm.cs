using BergDataServices;
using System.Windows.Forms;

namespace BergPerformanceInterpreter
{
    public partial class MainForm : Form
    {
        #region Member Variables..
        private BergNamedPipeServer _BergNamedPipeServer;
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #region MainForm
        public MainForm()
        {
            InitializeComponent();

            _BergNamedPipeServer = new BergNamedPipeServer();
        }
        #endregion MainForm
        #endregion Constructors.. 
    }
}
