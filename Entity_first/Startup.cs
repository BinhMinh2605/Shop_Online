using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Entity_first.Startup))]
namespace Entity_first
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
