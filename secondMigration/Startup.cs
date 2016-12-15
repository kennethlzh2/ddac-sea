using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(secondMigration.Startup))]
namespace secondMigration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
