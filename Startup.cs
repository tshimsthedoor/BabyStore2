using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BabyStore2.Startup))]
namespace BabyStore2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
