using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APlus.Startup))]
namespace APlus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
