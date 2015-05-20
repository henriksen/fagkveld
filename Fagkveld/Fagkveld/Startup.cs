using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fagkveld.Startup))]
namespace Fagkveld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
