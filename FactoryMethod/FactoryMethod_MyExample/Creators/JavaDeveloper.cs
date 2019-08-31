using FactoryMethod_MyExample.Products;

namespace FactoryMethod_MyExample.Creators
{
    public class JavaDeveloper : Developer
    {
        public JavaDeveloper(string n)
            : base(n) { }
        public override IWebSite CreateWebSite()
        {
            return new JavaSite();
        }
    }
}
