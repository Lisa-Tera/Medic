using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(m.Startup))]
namespace m
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
