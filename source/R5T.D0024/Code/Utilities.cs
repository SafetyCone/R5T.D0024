using System;
using System.Runtime.InteropServices;


namespace R5T.D0024
{
    public static class Utilities
    {
        public static string GetUnknownOSPlatformExceptionMessage()
        {
            var message = $"Unknown {nameof(OSPlatform)} value. \nKnown {nameof(OSPlatform)} values:\n* {OSPlatform.Windows} (Windows)\n* {OSPlatform.OSX} (OSX)\n* {OSPlatform.Linux} (Linux)";
            return message;
        }

        public static Exception GetUnknownOSPlatformException()
        {
            var message = Utilities.GetUnknownOSPlatformExceptionMessage();

            var exception = new Exception(message);
            return exception;
        }
    }
}
