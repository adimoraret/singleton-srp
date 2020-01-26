using System;
namespace singleton_srp
{
    class Program
    {
        private static void NonThreadSafeExample()
        {
            var instance1 = NonThreadSafe.MySingleton.Instance;
            instance1.OperationX();
            var instance2 = NonThreadSafe.MySingleton.Instance;
            instance2.OperationX();
            Console.WriteLine(instance1.Equals(instance2));
        }

        private static void ThreadSafeExample()
        {
            var instance1 = ThreadSafe.MySingleton.Instance;
            instance1.OperationX();
            instance1.OperationY();
            var instance2 = ThreadSafe.MySingleton.Instance;
            instance2.OperationX();
            instance2.OperationX();
            Console.WriteLine(instance1.Equals(instance2));
        }

        private static void ThreadSafeSrpExample()
        {
            var instance1 = ThreadSafeSrp.MySingleton.Instance;
            instance1.OperationX();
            instance1.OperationY();
            var instance2 = ThreadSafeSrp.MySingleton.Instance;
            instance2.OperationX();
            instance2.OperationX();
            Console.WriteLine(instance1.Equals(instance2));
        }

        static void Main(string[] args)
        {
            NonThreadSafeExample();
            ThreadSafeExample();
            ThreadSafeSrpExample();
        }
    }
}
