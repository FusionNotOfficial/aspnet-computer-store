using Microsoft.Owin;
using Owin;
using System.Globalization;

[assembly: OwinStartupAttribute(typeof(PasoconStore.Startup))]
namespace PasoconStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var cultureInfo = new CultureInfo("en-US");
            cultureInfo.NumberFormat.CurrencySymbol = "$";

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
            ConfigureAuth(app);
        }
    }
}
