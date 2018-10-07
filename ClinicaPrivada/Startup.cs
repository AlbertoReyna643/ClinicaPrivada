using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClinicaPrivada.Startup))]
namespace ClinicaPrivada
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
