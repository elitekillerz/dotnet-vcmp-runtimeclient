using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EliteKillerz.DotnetVcmp.RuntimeClient.VcmpSdk;

namespace EliteKillerz.DotnetVcmp.RuntimeClient
{
    public static class Bootstrap
    {
        public static bool VcmpInitialize(PluginFunctions pluginFunctions, ref PluginEvents pluginEvents, ref PluginInfo pluginInfo)
        {
            SetPluginInfo(ref pluginInfo);
            DiscoverAndInvokeUserEntryPoint(pluginFunctions, ref pluginEvents);

            return true;
        }

        private static void SetPluginInfo(ref PluginInfo pluginInfo)
        {
            pluginInfo.ApiMajorVersion = (ushort)ClientRelease.SdkVersion.Major;
            pluginInfo.ApiMinorVersion = (ushort)ClientRelease.SdkVersion.Minor;

            pluginInfo.PluginID = ClientRelease.PluginId;
            pluginInfo.PluginName = ClientRelease.Name;
            pluginInfo.PluginVersion = (uint)(
                    ((ushort)ClientRelease.PluginVersion.Major << 8)
                    + (ushort)ClientRelease.PluginVersion.Minor
                );
        }

        private static void DiscoverAndInvokeUserEntryPoint(PluginFunctions pluginFunctions, ref PluginEvents pluginEvents)
        {
            IEnumerable<Assembly> assemblies = AppDomain.CurrentDomain.GetAssemblies();

            MethodInfo targetMethodInfo =
                (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                 from type in assembly.GetTypes()
                 from methodInfo in type.GetMethods()
                 where Attribute.IsDefined(methodInfo, typeof(UserEntryPointAttribute))
                 select methodInfo).FirstOrDefault();

            if (targetMethodInfo == null || !targetMethodInfo.IsStatic)
                return;

            ((UserEntryPointDelegate)targetMethodInfo.CreateDelegate(typeof(UserEntryPointDelegate)))
                .Invoke(pluginFunctions, ref pluginEvents);
        }
    }
}
