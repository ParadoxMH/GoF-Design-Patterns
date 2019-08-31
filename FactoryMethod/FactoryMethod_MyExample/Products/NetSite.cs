using System;

namespace FactoryMethod_MyExample.Products
{
    public class NetSite : IWebSite
    {
        public NetSite()
        {
            Console.WriteLine(".Net web site is done.");
        }

        public string Operation()
        {
            return ".Net web site is done.";
        }
    }
}
