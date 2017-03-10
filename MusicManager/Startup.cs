using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicManager.Startup))]
namespace MusicManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
