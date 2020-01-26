namespace singleton_srp.ThreadSafe
{
    public sealed class MySingleton
    {
        private static MySingleton _instance = null;
        private static object _lock = new object();
        private MySingleton() { }
        public static MySingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock(_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new MySingleton();
                        }
                    }
                }
                return _instance;
            }
        }
        public void OperationX() { }
        public void OperationY() { }
    }
}