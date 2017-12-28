using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAutomationBuildApp.Startup))]
namespace TestAutomationBuildApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
