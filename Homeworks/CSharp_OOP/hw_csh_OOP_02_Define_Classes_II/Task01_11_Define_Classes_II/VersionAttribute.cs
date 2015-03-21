
namespace Education_3D
{
    using System;
    using System.Runtime.InteropServices;

    [AttributeUsage(AttributeTargets.Struct |  AttributeTargets.Class | AttributeTargets.Interface,  AllowMultiple = true)]
    public class VersionAttribute : Attribute
    {
        public string Version { get; private set; }

        public VersionAttribute(string version)
        {
            this.Version = version;
        }

    }
}
