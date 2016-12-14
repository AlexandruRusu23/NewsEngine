using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorldOfNews.Startup))]
namespace WorldOfNews
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
