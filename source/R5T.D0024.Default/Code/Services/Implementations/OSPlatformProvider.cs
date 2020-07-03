using System;
using System.Runtime.InteropServices;


namespace R5T.D0024.Default
{
    public class OSPlatformProvider : IOSPlatformProvider
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
