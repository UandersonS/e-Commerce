using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Print_Shop.Startup))]
namespace Print_Shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
