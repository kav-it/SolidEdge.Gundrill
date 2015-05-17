using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

using WixSharp;
using WixSharp.CommonTasks;

using File = WixSharp.File;

public class Script
{
    internal const string PRODUCT_NAME = "Gundrill";
    internal const string COMPANY_NAME = "codeofrussia.ru";
    internal const string MANUFACTORER_NAME = "Крыцкий Андрей (kav.it@mail.ru)";

    internal static string DestDir
    {
        get { return string.Format(@"c:\Program Files (x86)\{0}\{1}", COMPANY_NAME, PRODUCT_NAME); }
    }

    static public void Main(string[] args)
    {
        var destDir = DestDir;

        var project = new ManagedProject()
        {
            Name = PRODUCT_NAME,
            GUID = new Guid("FE96C2EC-97D9-467E-93F1-C2DE59999652"),
            UI = WUI.WixUI_InstallDir,
            Dirs = new[]
            {
                new Dir(destDir)    
                {
                    Files = new []
                    {
                        new File(@"\..\Deploy\Temp\register.bat"),
                        new File(@"\..\Deploy\Temp\unregister.bat"),
                        new File(@"\..\Deploy\Temp\Gundrill.Plugin.dll"),
                        new File(@"\..\Deploy\Temp\Interop.SolidEdge.dll"),
                        new File(@"\..\Deploy\Temp\SolidEdge.Community.dll"),
                    },
                    Shortcuts = new []
                    {
                        new ExeFileShortcut("Uninstall", "[System64Folder]msiexec.exe", "/x [ProductCode]")
                    }
                }
            }
        };

        project.RemoveDialogsBetween(Dialogs.WelcomeDlg, Dialogs.InstallDirDlg);

        project.Version = new Version(Gundrill.Version.SHORT);
        project.Language = "ru-RU";
        project.Encoding = System.Text.Encoding.UTF8;

        project.ControlPanelInfo.Manufacturer = MANUFACTORER_NAME;
        project.ControlPanelInfo.ProductIcon = "app.ico";
        project.ControlPanelInfo.NoRepair = true;

        project.BeforeInstall += project_BeforeExecute;
        project.AfterInstall += project_AfterExecute;

        project.OutFileName = string.Format("{0} ({1})", PRODUCT_NAME, Gundrill.Version.SHORT);
        project.OutDir = "../Deploy/Installer".PathGetFullPath();

        Compiler.BuildMsi(project);
    }

    static void project_BeforeExecute(SetupEventArgs e)
    {
        if (e.IsUninstalling)
        {
            // Разрегистрация .NET COM
            var startInfo = new ProcessStartInfo()
            {
                FileName = Path.Combine(DestDir, "unregister.bat"),
                WorkingDirectory = DestDir
            };

            var process = Process.Start(startInfo);
            process.WaitForExit(5000);
        }
    }

    static void project_AfterExecute(SetupEventArgs e)
    {
        if (e.IsInstalling)
        {
            // Регистрация .NET COM
            var startInfo = new ProcessStartInfo()
            {
                FileName = Path.Combine(DestDir, "register.bat"),
                WorkingDirectory = DestDir
            };

            var process = Process.Start(startInfo);
            process.WaitForExit(5000);
        }
    }
}



