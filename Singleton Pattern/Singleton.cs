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
            return _instance ??= new Singleton();
        }
    }
}
