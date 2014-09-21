using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RapidPrototypingMVC5Examples.Startup))]
namespace RapidPrototypingMVC5Examples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
