using System;
using System.Runtime.InteropServices;

using R5T.T0064;


namespace R5T.D0024
{
    [ServiceDefinitionMarker]
    public interface IOSPlatformProvider : IServiceDefinition
    {
        OSPlatform GetOSPlatform();
    }
}
