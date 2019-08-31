using System;

namespace FactoryMethod_MyExample.Products
{
    public class JavaSite : IWebSite
    {
        public JavaSite()
        {
            Console.WriteLine("Java web site is done.");
        }

        public string Operation()
        {
            return "Java web site is done.";
        }
    }
}
