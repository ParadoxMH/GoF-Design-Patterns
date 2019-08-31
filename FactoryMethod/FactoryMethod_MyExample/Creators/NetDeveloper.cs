using FactoryMethod_MyExample.Products;

namespace FactoryMethod_MyExample.Creators
{
    class NetDeveloper : Developer
    {
        public NetDeveloper(string n)
            : base(n) { }
        public override IWebSite CreateWebSite()
        {
            return new NetSite();
        }
    }
}
