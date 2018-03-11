using System;

namespace CrashConsole
{
    public class HugeAndComplexService
    {
        public static void DoSomeImportantWork()
        {
            throw new InvalidOperationException("Meaningful troubleshooting information");
        }
    }
}
