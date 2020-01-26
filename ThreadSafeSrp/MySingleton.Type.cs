namespace singleton_srp.ThreadSafeSrp
{
    public sealed partial class MySingleton
    {
        private static MySingleton _instance = null;
        private static object _lock = new object();
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
    }
}