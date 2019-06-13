using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cloudmarket.Startup))]

namespace Cloudmarket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
