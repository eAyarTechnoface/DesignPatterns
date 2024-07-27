using SingletonDesignPattern;

Logger logger1 = Logger.Instance;
Logger logger2 = Logger.Instance;


logger1.Log("This is the first log message.");
logger2.Log("This is the second log message.");

if (ReferenceEquals(logger1, logger2))
{
    Console.WriteLine("Logger1 and Logger2 are the same instance.");
}