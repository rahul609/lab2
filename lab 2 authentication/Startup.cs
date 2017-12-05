using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab_2_authentication.Startup))]
namespace lab_2_authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
