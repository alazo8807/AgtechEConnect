using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgtechEConnect.Startup))]
namespace AgtechEConnect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
