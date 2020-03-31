using System;
using System.IO;

namespace SOLIDPrinciples.DependencyInversion
{
    internal class Dip : IPrinciple
    {
        public string Principle()
        {
            return "Dependency Inversion";
        }

        // e.g. when it is used:
        private void UseDependencyInjectionForLogger()
        {
            var customer = new BetterCustomer(new EmailLogger());
            customer.Add(new Database());
        }

        internal class FileLogger
        {
            public void Handle(string error)
            {
                File.WriteAllText(@"C:\Error.txt", error);
            }
        }

        // Bad: We are relying on the customer to say that we
        // are using a File Logger, rather than another type of
        // logger, e.g. EmailLogger.
        internal class Customer
        {
            private readonly FileLogger _logger = new FileLogger();

            public void Add(Database db)
            {
                try
                {
                    db.Add();
                }
                catch (Exception error)
                {
                    _logger.Handle(error.ToString());
                }
            }
        }

        // Good: We pass in a Logger interface to the customer
        // so it doesnt know what type of logger it is
        private class BetterCustomer
        {
            private readonly ILogger _logger;

            public BetterCustomer(ILogger logger)
            {
                _logger = logger;
            }

            public void Add(Database db)
            {
                try
                {
                    db.Add();
                }
                catch (Exception error)
                {
                    _logger.Handle(error.ToString());
                }
            }
        }

        private class EmailLogger : ILogger
        {
            public void Handle(string error)
            {
                File.WriteAllText(@"C:\Error.txt", error);
            }
        }

        private interface ILogger
        {
            void Handle(string error);
        }
    }
}