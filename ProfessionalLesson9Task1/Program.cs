using System;
using System.IO;

namespace ProfessionalLesson9Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                using (ObjectForGC ob = new ObjectForGC())
                {
                    Console.WriteLine("Some internal code in USING");
                }
            }

            Console.WriteLine(GC.CollectionCount(0));
            Console.WriteLine(GC.CollectionCount(1));
            Console.WriteLine(GC.CollectionCount(2));
        }
    }
}
