using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Novi.Art.Startup))]
namespace Novi.Art
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
