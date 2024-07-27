namespace SingletonDesignPattern
{
    public class Logger
    {
        // Constructor private olarak işaretlenir. Çünkü Singleton Design Pattern da nesneyi direkt olarak new anahtar kelimesi ile oluşturmamalıyız.
        private Logger()
        {

        }

        //Lazy Initialization: Lazy<T> sınıfı, Logger sınıfının örneğinin yalnızca gerekli olduğunda oluşturulmasını sağlar. Bu, örneğin kullanılmadığı durumlarda gereksiz yere bellek kullanılmasını önler. Örnek zaten oluşturulmuşşa tekrar bir daha oluşturulmaz.

        //Lazy<T> sınıfı, varsayılan olarak thread-safe'dir, bu da aynı anda birden fazla iş parçacığı tarafından erişilmesi durumunda dahi yalnızca bir örnek oluşturulacağını garanti eder.
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());

        public static Logger Instance
        {

            get
            {
                return _instance.Value;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

}

