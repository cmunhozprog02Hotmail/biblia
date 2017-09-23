using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Biblia.Startup))]
namespace Biblia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
