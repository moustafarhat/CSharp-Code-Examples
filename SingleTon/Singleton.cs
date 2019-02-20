using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTon
{
    public class Singleton
    {
        private static Singleton _singleton = null;
        private Singleton()
        { }

        public static Singleton GetInstance()
        {
            if (_singleton==null)
                _singleton=new Singleton();
            return _singleton;
        }
    }
}
