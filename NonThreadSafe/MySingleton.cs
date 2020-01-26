namespace singleton_srp.NonThreadSafe
{
    public sealed class MySingleton
    {
        private static MySingleton _instance = null;
        private MySingleton() { }
        public static MySingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MySingleton();
                }
                return _instance;
            }
        }
        public void OperationX() { }
    }
}