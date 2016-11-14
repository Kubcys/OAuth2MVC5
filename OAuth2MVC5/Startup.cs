using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAuth2MVC5.Startup))]
namespace OAuth2MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
