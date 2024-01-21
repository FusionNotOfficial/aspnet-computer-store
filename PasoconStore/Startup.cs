using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PasoconStore.Startup))]
namespace PasoconStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
