using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.AnotherExample.@interface;

namespace StatePattern.AnotherExample
{
    public class Policy : IPolicyState
    {
        public void Open(DateTime? writtenDate = null)
        {
            throw new NotImplementedException();
        }

        public void Void()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Close(DateTime closeDate)
        {
            throw new NotImplementedException();
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }
    }
}
