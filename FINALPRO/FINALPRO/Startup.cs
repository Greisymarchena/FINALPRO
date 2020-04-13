using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FINALPRO.Startup))]
namespace FINALPRO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
