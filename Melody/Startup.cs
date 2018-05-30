using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Melody.Startup))]
namespace Melody
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
