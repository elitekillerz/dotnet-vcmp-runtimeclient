using System.Runtime.InteropServices;

namespace EliteKillerz.DotnetVcmp.RuntimeClient.VcmpSdk
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ServerSettings
    {
        private readonly uint StructSize;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string Name;

        public uint MaxPlayers;
        public uint Port;
        public uint Flags;
    }
}
