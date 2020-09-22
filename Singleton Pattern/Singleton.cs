using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern
{
    public class Singleton
    {
        private Singleton()
        {

        }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
