using System.Globalization;
using System.Windows.Forms;

namespace GundrillPlugin.Source.Windows
{
    public partial class WindowCreateBox : Form
    {
        #region Свойства

        public int X
        {
            get { return GetValueByTrack(trackBarX); }
        }

        public int Y
        {
            get { return GetValueByTrack(trackBarY); }
        }

        public int Z
        {
            get { return GetValueByTrack(trackBarZ); }
        }

        #endregion

        #region Конструктор

        public WindowCreateBox()
        {
            InitializeComponent();
        }

        #endregion

        #region Методы

        private int GetValueByTrack(TrackBar trackBar)
        {
            return trackBar.Value;
        }

        private void UpdateValues()
        {
            labelX.Text = trackBarX.Value.ToString(CultureInfo.InvariantCulture);
            labelY.Text = trackBarY.Value.ToString(CultureInfo.InvariantCulture);
            labelZ.Text = trackBarZ.Value.ToString(CultureInfo.InvariantCulture);
        }

        private void trackBarX_ValueChanged(object sender, System.EventArgs e)
        {
            UpdateValues();
        }

        #endregion
    }
}