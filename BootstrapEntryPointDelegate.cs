using System;
using EliteKillerz.DotnetVcmp.RuntimeClient.VcmpSdk;

namespace EliteKillerz.DotnetVcmp.RuntimeClient
{
    public delegate bool BootstrapEntryPointDelegate(PluginFunctions pluginFunctions, ref PluginEvents pluginEvents, ref PluginInfo pluginInfo);
}
