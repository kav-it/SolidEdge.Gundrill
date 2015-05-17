using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GundrillPlugin
{
    /// <summary>
    /// Константы приложения
    /// </summary>
    internal static class Constants
    {
        /// <summary>
        /// Версия UI
        /// </summary>
        /// <remarks>
        /// Если плагин используется Ribbon и элементы в этом меню меняются в новой версии плагина, то необходимо
        /// версию <see cref="GUI_VERSION"/> увеличивать, чтобы Solid Edge обновил кеш
        /// </remarks>
        internal const int GUI_VERSION = 1;

        /// <summary>
        /// Guid сборки (dll)
        /// </summary>
        internal const string ASSEMBLY_GUID = "BE1644A9-741B-4401-BB2A-D8DB540B66C6";

        /// <summary>
        /// Guid основного класса плагина (используется в COM)
        /// </summary>
        internal const string PLUGIN_GUID = "8646BB57-3365-450F-B38E-343A00F7B98B";

        /// <summary>
        /// ProgId основного класса плагина (используется в COM)
        /// </summary>
        internal const string PLUGIN_PROG_ID = "Kavit.Gundrill.Plugin";

        /// <summary>
        /// Краткое описание плагина (отображается в свойствах dll)
        /// </summary>
        internal const string PLUGIN_TITLE = "Плагин для Solid Edge";

        /// <summary>
        /// Имя плагина (отображается в свойствах dll и на закладке AddIn-s в SolidEdge)
        /// </summary>
        internal const string PLUGIN_PRODUCT = "Gundrill Plugin";

        /// <summary>
        /// Описание плагина (используется в свойствах dll)
        /// </summary>
        internal const string PLUGIN_DESC = "Плагин для проектирования оружейного сверла";

    }
}
