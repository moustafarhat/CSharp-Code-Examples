using System;

namespace StatePattern.AnotherExample.@interface
{
    public interface IPolicyState
    {
        void Open(DateTime? writtenDate = null);
        void Void();
        void Update();
        void Close(DateTime closeDate);
        void Cancel();
    }
}
