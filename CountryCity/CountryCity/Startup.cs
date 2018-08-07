using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CountryCity.Startup))]
namespace CountryCity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
