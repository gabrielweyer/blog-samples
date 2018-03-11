using System;

namespace CrashConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HugeAndComplexService.DoSomeImportantWork();
            }
            catch (Exception)
            {
                throw new Exception("YOLO - LMAO");
            }
        }
    }
}
