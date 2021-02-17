using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dd106516MIS4200.Startup))]
namespace dd106516MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
