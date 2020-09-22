using System;
using Builder_Pattern.Classes;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var director=new Director();
            var builder=new BuilderService();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct());
            Console.WriteLine(builder.GetProduct().PartsList());


            Console.WriteLine("Complete spec product:");
            director.BuildFullSpecProduct();
            Console.WriteLine(builder.GetProduct().PartsList());


        }
    }
}
