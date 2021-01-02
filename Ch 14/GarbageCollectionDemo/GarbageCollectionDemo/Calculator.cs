using System;

namespace GarbageCollectionDemo
{
    class Calculator : IDisposable
    {
        private bool disposed = false;

        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }

        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }

        public int Divide(int first, int second)
        {
            return first / second;
        }

        public void Dispose()
        {
            if (!this.disposed)
            {
                Console.WriteLine("Calculator being disposed");
            }
            this.disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
