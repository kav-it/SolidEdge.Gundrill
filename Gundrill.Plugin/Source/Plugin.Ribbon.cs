using System;

using GundrillPlugin.Source.Windows;

using SolidEdgeCommunity.AddIn;
using SolidEdgeCommunity.Extensions;

using SolidEdgeConstants;

using SolidEdgePart;

namespace GundrillPlugin
{
    internal class PluginRibbon : Ribbon
    {
        #region Константы

        private const string EMBEDDED_RESOURCE_NAME = "GundrillPlugin.Source.Assets.Ribbon.xml";

        #endregion

        #region Поля

        private RibbonButton _buttonCreate;

        #endregion

        #region Конструктор

        public PluginRibbon()
        {
            // Загрузка структуры ribbon из ресурсов сборки
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            LoadXml(assembly, EMBEDDED_RESOURCE_NAME);

            // Получение ссылка на элементы управления из Ribbon
            _buttonCreate = GetButton(0);

            // Добавление обработчиков
            _buttonCreate.Click += ButtonCreateOnClick;
        }

        #endregion

        #region Методы

        private void ButtonCreateOnClick(RibbonControl control)
        {
            using (var win = new WindowCreateBox())
            {
                if (PluginHelper.ShowDialog(win))
                {
                    CreateCube(win.X, win.Y, win.Z);        
                }
            }
        }

        private void CreateCube(double x, double y, double z)
        {
            // Перевод размеров из мм в м
            x = x / 1000;
            y = y / 1000;
            z = z / 1000;

            // Получение ссылки на текущий активный документ Part
            var app = SolidEdgeAddIn.Instance.Application;
            var partDocument = app.Documents.AddPartDocument();

            var models = partDocument.Models;
            var sketches = partDocument.Sketches;
            var refPlanes = partDocument.RefPlanes;

            // Выбор плоскости, в которой будет нарисован профиль (прямоугольник)
            var refPlane = refPlanes.GetTopPlane();

            // Создание нового Sketch
            var sketch = sketches.Add();
            var profile = sketch.Profiles.Add(refPlane);
            var lines = profile.Lines2d;

            // Создание контура прямоугольника из 4-х линий
            lines.AddBy2Points(0, 0, x, 0);
            lines.AddBy2Points(x, 0, x, y);
            lines.AddBy2Points(x, y, 0, y);
            lines.AddBy2Points(0, y, 0, 0);

            // Определение отношений между линиями (для того, чтобы контур был замкнутый)
            var relations = (SolidEdgeFrameworkSupport.Relations2d)profile.Relations2d;
            relations.AddKeypoint(lines.Item(1), (int)KeypointIndexConstants.igLineStart, lines.Item(2), (int)KeypointIndexConstants.igLineEnd, true);
            relations.AddKeypoint(lines.Item(2), (int)KeypointIndexConstants.igLineStart, lines.Item(3), (int)KeypointIndexConstants.igLineEnd, true);
            relations.AddKeypoint(lines.Item(3), (int)KeypointIndexConstants.igLineStart, lines.Item(4), (int)KeypointIndexConstants.igLineEnd, true);
            relations.AddKeypoint(lines.Item(4), (int)KeypointIndexConstants.igLineStart, lines.Item(1), (int)KeypointIndexConstants.igLineEnd, true);

            // Закрытие профиля
            profile.End(SolidEdgePart.ProfileValidationType.igProfileClosed);

            // Создание массива профилей (сейчас только один) для параметра операции ExtrudedProtrusion
            Array profiles = new Profile[1];
            profiles.SetValue(profile, 0);

            // Операция "Выдавливание"
            models.AddFiniteExtrudedProtrusion(
                profiles.Length,
                ref profiles,
                SolidEdgePart.FeaturePropertyConstants.igRight,
                z);

            // Установка вида ISO (для наглядности)
            app.StartCommand(PartCommandConstants.PartViewISOView);
        }

        #endregion
    }
}



