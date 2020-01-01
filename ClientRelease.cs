using System;
using System.Collections.Generic;
using System.Text;

namespace EliteKillerz.DotnetVcmp.RuntimeClient
{
    public static class ClientRelease
    {
        public static Version SdkVersion => new Version(2, 0);

        public static uint PluginId => 0x2109afdc;
        public static string Name => "Dotnet VCMP";
        public static Version PluginVersion => SdkVersion;
    }
}
