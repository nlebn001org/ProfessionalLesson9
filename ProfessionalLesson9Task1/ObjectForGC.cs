using System;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalLesson9Task1
{
    class ObjectForGC : IDisposable
    {
        byte[] arr = new byte[1024 * 1000];
        bool disposed = false;

        public void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                    Console.WriteLine("Were closed all connections with unmannaged sources.");
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ObjectForGC()
        {
            Console.WriteLine($"Object destructor of {this.GetType()}.");
        }
    }
}
