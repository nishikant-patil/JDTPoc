using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JDTPoc.Startup))]
namespace JDTPoc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
