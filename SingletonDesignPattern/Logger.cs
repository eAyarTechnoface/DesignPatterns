namespace SingletonDesignPattern
{
    public class Logger
    {
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());

        //Logger sınıfının yapıcısı(constructor) özel olarak işaretlenmiştir, bu nedenle sınıfın dışından yeni örnek oluşturulamaz.Bu, Singleton tasarım deseninin önemli bir parçasıdır.
        private Logger()
        {
        }

        // Lazy<T> sınıfı, Logger sınıfının örneğinin yalnızca gerekli olduğunda oluşturulmasını sağlar.Bu, örneğin kullanılmadığı durumlarda gereksiz yere bellek kullanılmasını önler.
        // Lazy<T> sınıfı, varsayılan olarak thread-safe'dir, bu da aynı anda birden fazla iş parçacığı tarafından erişilmesi durumunda dahi yalnızca bir örnek oluşturulacağını garanti eder.Bu örneğin kullanımı, örneğin yalnızca bir kez oluşturulmasını sağlar.
        public static Logger Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
