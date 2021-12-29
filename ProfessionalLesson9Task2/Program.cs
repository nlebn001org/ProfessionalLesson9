using System;
using System.Collections.Generic;

namespace ProfessionalLesson9Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine("Actual memory used: " + GC.GetTotalMemory(false) / 1024);
                byte[] b = new byte[1024 * 50];
                SourceMonitor.CheckRAM(500, 700, 900);
            }
            SourceMonitor.ShowGenLoops();
        }
    }
}
