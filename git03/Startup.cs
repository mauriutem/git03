using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(git03.Startup))]
namespace git03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
