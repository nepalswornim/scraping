using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Scraping.Startup))]
namespace Scraping
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
