using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySecondApp.Startup))]
namespace MySecondApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
