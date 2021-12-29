using System;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalLesson9Task2
{
    class SourceMonitor
    {
        /// <summary>Sets warning, critical and collect values for memory.</summary>
        public static void CheckRAM(int warning, int critical, int collect)
        {
            if (GC.GetTotalMemory(false) / 1024 > warning)
                Console.WriteLine("Warning");
            if (GC.GetTotalMemory(false) / 1024 > critical)
                Console.WriteLine("Critical");
            if (GC.GetTotalMemory(false) / 1024 > collect)
            {
                GC.Collect();
                Console.WriteLine("Unused objects were collected by GC.");
            }
        }

        /// <summary>
        /// Shows how many times GC has gone through all GC Generations.
        /// </summary>
        public static void ShowGenLoops()
        {
            Console.WriteLine(GC.CollectionCount(0));
            Console.WriteLine(GC.CollectionCount(1));
            Console.WriteLine(GC.CollectionCount(2));
        }
    }
}
