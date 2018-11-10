using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForRich.Startup))]
namespace ForRich
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
