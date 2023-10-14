using System;
namespace SimpleMath
{
	public sealed class Logger
	{
        Guid obj = Guid.NewGuid();
        private Logger() {}
        private static Logger _instance = null;

        private static readonly object Instancelock = new object();
        public static Logger GetLoggerInstance()
        {
            lock (Instancelock)
            { 
                if (_instance == null)
                {
                    _instance = new Logger();
                }
            } 
            return _instance;

        }
        public void Log(string text)
        {
            Console.WriteLine(obj.ToString() + " " + text);
        }
    }

}

