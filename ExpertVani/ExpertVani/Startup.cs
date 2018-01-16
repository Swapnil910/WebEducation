using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpertVani.Startup))]
namespace ExpertVani
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
