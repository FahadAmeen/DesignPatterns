using System;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            Console.WriteLine(s1 == s2? "Singleton works, both variables contain the same instance." : "Singleton failed, variables contain different instances.");
        }
    }
}
