using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EJuiceBox.Startup))]
namespace EJuiceBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
