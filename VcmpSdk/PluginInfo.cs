using System.Runtime.InteropServices;

namespace EliteKillerz.DotnetVcmp.RuntimeClient.VcmpSdk
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PluginInfo
    {
        private uint StructSize;

        public uint PluginID;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string PluginName;
        public uint PluginVersion;

        public ushort ApiMajorVersion;
        public ushort ApiMinorVersion;
    }

}
