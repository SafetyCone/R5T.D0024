using System;
using System.Runtime.InteropServices;using R5T.T0064;


namespace R5T.D0024.Default
{[ServiceImplementationMarker]
    public class OSPlatformProvider : IOSPlatformProvider,IServiceImplementation
    {
        public OSPlatform GetOSPlatform()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return OSPlatform.Windows;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return OSPlatform.OSX;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return OSPlatform.Linux;
            }

            throw Utilities.GetUnknownOSPlatformException();
        }
    }
}
