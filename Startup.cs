using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShppingCart.Startup))]
namespace ShppingCart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
