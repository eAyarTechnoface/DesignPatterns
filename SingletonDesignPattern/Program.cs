
using SingletonDesignPattern;


Logger logger1 = Logger.Instance;
Logger logger2 = Logger.Instance;

logger1.Log("Hello from logger1");
logger2.Log("Hello from logger2");

if (ReferenceEquals(logger1, logger2))
{
    Console.WriteLine("logger1 and logger2 are the same instance");
}
else
{
    Console.WriteLine("logger1 and logger2 are different instances");
}

