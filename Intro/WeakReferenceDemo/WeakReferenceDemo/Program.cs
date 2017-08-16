using System;

namespace WeakReferenceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            object o1 = new object();

            WeakReference wr = new WeakReference(o1);
            o1 = null;

            GC.Collect(1);


            object o2 = wr.Target;
            if (o2 != null)
            {

            }
        }
    }
}