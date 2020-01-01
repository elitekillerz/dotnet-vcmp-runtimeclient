using System;
using System.Collections.Generic;
using System.Text;

namespace EliteKillerz.DotnetVcmp.RuntimeClient
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class UserEntryPointAttribute : Attribute { }
}
