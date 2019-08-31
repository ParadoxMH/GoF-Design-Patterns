using FactoryMethod_MyExample.Creators;
using FactoryMethod_MyExample.Products;
using System;

namespace FactoryMethod_MyExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new NetDeveloper("Manolii");
            dev.SomeOperation();


            Developer dev2 = new JavaDeveloper("Mykola");
            IWebSite javaSite = dev2.CreateWebSite();

            Console.ReadLine();
        }
    }
}
