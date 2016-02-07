using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExploreJenkins.Startup))]
namespace ExploreJenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
