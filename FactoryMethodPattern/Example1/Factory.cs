using System;

namespace FactoryMethodPattern.Example1
{
    public class Factory
    {
        private interface ILogger
        {
            void Log(string message);
        }

        private enum LoggerType
        {
            File,
            Database,
            EventViewer
        }

        private class FileLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine("{0} - Logged in File.", message);
            }
        }

        private class DatabaseLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine("{0} - Logged in Database.", message);
            }
        }

        private class EventViewerLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine("{0} - Logged in EventViewer.", message);
            }
        }

        private class LoggerFactory
        {
            public static ILogger Get(LoggerType type)
            {
                switch (type)
                {
                    case LoggerType.Database:
                        return new DatabaseLogger();

                    case LoggerType.EventViewer:
                        return new EventViewerLogger();

                    case LoggerType.File:
                        return new FileLogger();

                    default:
                        return new FileLogger();
                }
            }
        }

        //static void Main(string[] args)
        //{
        //    var logger1 = LoggerFactory.Get(LoggerType.Database);
        //    logger1.Log("Message from Main");

        //    var logger2 = LoggerFactory.Get(LoggerType.File);
        //    logger2.Log("Message from Main");

        //    var logger3 = LoggerFactory.Get(LoggerType.EventViewer);
        //    logger3.Log("Message from Main");

        //    Console.ReadKey();

        //    /*Output
        //    Message from Main - Logged in Database.
        //    Message from Main - Logged in File.
        //    Message from Main - Logged in EventViewer.
        //    */
        //}
    }
}