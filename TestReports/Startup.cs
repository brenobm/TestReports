using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestReports.Startup))]
namespace TestReports
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
