using System;
using System.Globalization;
using System.Runtime.InteropServices;

using SolidEdgeCommunity;
using SolidEdgeCommunity.AddIn;

namespace GundrillPlugin
{
    /// <summary>
    /// Основной класс плагина (наследник от SolidEdgeAddIn)
    /// </summary>
    /// <remarks>
    /// Определяются GUID-ы и методы регистрации в реестре
    /// </remarks>
    [ComVisible(true)]
    [Guid(Constants.PLUGIN_GUID)]
    [ProgId(Constants.PLUGIN_PROG_ID)]
    public class Plugin: SolidEdgeAddIn
    {
        private ConnectionPointController _connectionPointController;

        /// <summary>
        /// Вызывается, когда плагин первый раз загружается в Solid Edge
        /// </summary>
        public override void OnConnection(SolidEdgeFramework.Application application, SolidEdgeFramework.SeConnectMode connectMode, SolidEdgeFramework.AddIn addInInstance)
        {
            // TODO Добавить проверку версии
            // Чтение версии Solid Edge
            var version = Instance.SolidEdgeVersion;

            //// View.GetModelRange() is only available in ST6 or greater.
            //if (version.Major < 106)
            //{
            //}

            // Версия UI (инкрементируется при изменении элементов UI в плагине)
            AddInEx.GuiVersion = Constants.GUI_VERSION;

            // Создание экземпляра контроллера связи с Solid Edge. Этот контроллер помогает управлять COM-событиями
            _connectionPointController = new ConnectionPointController(this);
        }

        /// <summary>
        /// Вызывается, когда плагин впервые подключается к нового окружению Solid Edge
        /// </summary>
        public override void OnConnectToEnvironment(SolidEdgeFramework.Environment environment, bool firstTime)
        {
            // Пока не используется
        }

        /// <summary>
        /// Вызывается, когда плагин выгружается из Solid Edge
        /// </summary>
        public override void OnDisconnection(SolidEdgeFramework.SeDisconnectMode disconnectMode)
        {
            // Отключение от обработки всех COM событий
            _connectionPointController.UnadviseAllSinks();
        }

        /// <summary>
        /// Вызывается напрямую после OnConnectToEnvironment() для возможности настройки Ribbon
        /// для каждого Enviroment (Assembly, Parts, Draft и т.д.)
        /// </summary>
        public override void OnCreateRibbon(RibbonController controller, Guid environmentCategory, bool firstTime)
        {
            // Меню загружается для всех необходимых окружений

            if (environmentCategory.Equals(SolidEdgeSDK.EnvironmentCategories.Assembly)
                || environmentCategory.Equals(SolidEdgeSDK.EnvironmentCategories.Draft)
                || environmentCategory.Equals(SolidEdgeSDK.EnvironmentCategories.Part)
                || environmentCategory.Equals(SolidEdgeSDK.EnvironmentCategories.DMPart)
                || environmentCategory.Equals(SolidEdgeSDK.EnvironmentCategories.SheetMetal)
                || environmentCategory.Equals(SolidEdgeSDK.EnvironmentCategories.DMSheetMetal)
                )
            {
                // Assembly Environment
                // Draft Environment
                // Traditional Part Environment
                // Synchronous Part Environment
                // Traditional SheetMetal Environment
                // Synchronous SheetMetal Environment
                controller.Add<PluginRibbon>(environmentCategory, firstTime);
            }
        }

        /// <summary>
        /// Метод вызывается, когда выполняется регистрация сборки с использованием regasm.exe 
        /// </summary>
        [ComRegisterFunction]
        static void OnRegister(Type t)
        {
            try
            {
                // Конфигурация дополнительных параметров реестра, необходимых для Solid Edge плагинов
                var settings = new RegistrationSettings(t);
                var englishCulture = CultureInfo.GetCultureInfo(1033);

                settings.Enabled = true;
                settings.Environments.Add(SolidEdgeSDK.EnvironmentCategories.Application);
                settings.Environments.Add(SolidEdgeSDK.EnvironmentCategories.AllDocumentEnvrionments);

                settings.Titles.Add(englishCulture, Constants.PLUGIN_PRODUCT);
                settings.Summaries.Add(englishCulture, Constants.PLUGIN_DESC);

                Register(settings);
            }
            catch (Exception)
            {
                // TODO Добавить логгирование
                // MessageBox.Show(ex.StackTrace, ex.Message);
            }
        }

        /// <summary>
        /// Метод вызывается, когда выполняется разрегистрация сборки с использованием regasm.exe 
        /// </summary>
        [ComUnregisterFunction]
        static void OnUnregister(Type t)
        {
            Unregister(t);
        }
    }
}