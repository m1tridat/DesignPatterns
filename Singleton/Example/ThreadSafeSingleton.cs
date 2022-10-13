namespace Singleton.Example
{
    public sealed class ThreadSafeSingleton
    {
        private static readonly ThreadSafeSingleton Instance;
        private ThreadSafeSingleton() {}

        static ThreadSafeSingleton()
        {
            Instance = new ThreadSafeSingleton();
        }

        public static ThreadSafeSingleton GetInstance(string value)
        {
            Instance.Value = value;
            return Instance;
        }
        
        public string Value { get; set; }
    }
}