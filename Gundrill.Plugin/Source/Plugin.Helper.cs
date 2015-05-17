using System.Windows.Forms;

using SolidEdgeCommunity.AddIn;
using SolidEdgeCommunity.Extensions;

namespace GundrillPlugin
{
    internal static class PluginHelper
    {
        #region Свойства

        public static NativeWindow AppWindow
        {
            get { return SolidEdgeAddIn.Instance.Application.GetNativeWindow(); }
        }

        #endregion

        #region Методы

        public static bool ShowDialog(Form win)
        {
            if (win.ShowDialog(AppWindow) == DialogResult.OK)
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}