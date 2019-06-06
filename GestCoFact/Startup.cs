using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestCoFact.Startup))]
namespace GestCoFact
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
