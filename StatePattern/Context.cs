using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.@interface;

namespace StatePattern
{
    public class Context
    {
        private IState _state;

        public Context()
        {
            _state = null;
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public IState GetState()
        {
            return _state;
        }

    }
}
