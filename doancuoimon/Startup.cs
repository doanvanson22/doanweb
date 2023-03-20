using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(doancuoimon.Startup))]
namespace doancuoimon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
