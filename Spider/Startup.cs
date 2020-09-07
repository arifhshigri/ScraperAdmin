using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Spider.Startup))]
namespace Spider
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
