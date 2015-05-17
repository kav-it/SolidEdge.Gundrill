using System.Reflection;

[assembly: AssemblyCopyright(Gundrill.Version.AUTHOR)]
[assembly: AssemblyVersion(Gundrill.Version.SHORT)]
[assembly: AssemblyFileVersion(Gundrill.Version.SHORT)]

namespace Gundrill
{
    internal static class Version
    {
        internal const string AUTHOR = "Крыцкий Андрей (kav.it@mail.ru)";

        internal const string V1 = "1";

        internal const string V2 = "1";

        internal const string V3 = "0";

        internal const string V4 = "0";

        internal const string FULL = V1 + "." + V2 + "." + V3 + "." + V4;

        internal const string SHORT = V1 + "." + V2;
    }
}