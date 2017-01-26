using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Music_Manager.Startup))]
namespace Music_Manager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
