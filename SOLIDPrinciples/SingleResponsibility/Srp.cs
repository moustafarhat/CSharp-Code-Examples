using System;
using System.IO;
using Solid;

namespace SOLIDPrinciples.SingleResponsibility
{
    class Srp : IPrinciple
    {
        public string Principle()
        {
            return "Single Responsibility";
        }
    }

    // Violating the Single Responsibility Principle
    internal class Customer
    {
        // This Add method does too much,
        // it shouldnt know how to write to the log and add a customer
        public void Add(Database db)
        {
            try
            {
                db.Add();
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Error.txt", ex.ToString());
            }
        }
    }

    // Good Way, not violating the single responsibility principle
    // Now we abstract the logger, so its just writing the error.
    class CustomerBetter
    {
        private readonly FileLogger _logger = new FileLogger();

        public void Add(Database db)
        {
            try {
                db.Add();
            }
            catch (Exception ex)
            {
                _logger.Handle(ex.ToString());
            }
        }
    }
    internal class FileLogger
    {
        public void Handle(string error)
        {
            File.WriteAllText(@"C:\Error.txt", error);
        }
    }

    // Even Better Way
    // Even better, the customer only knows how to add, and we
    // wrap the add method in an error handler.
    // @see Utilities/Customer
    class Wrapper
    {
        public void HandleAdd(FileLogger logger, Database db, Customer customer)
        {
            try
            {
                customer.Add(db);
            }
            catch (Exception error)
            {
                logger.Handle(error.ToString());
            }
        }
    }

}
