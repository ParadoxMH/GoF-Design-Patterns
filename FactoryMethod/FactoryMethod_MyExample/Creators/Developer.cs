using FactoryMethod_MyExample.Products;

namespace FactoryMethod_MyExample.Creators
{
    public abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string name)
        {
            Name = name;
        }

        public abstract IWebSite CreateWebSite();
        public string SomeOperation()
        {
            var webSite = CreateWebSite();
            var result = "Creator: The same creator's code has just worked with "
                + webSite.Operation();

            return result;
        }
    }
}
