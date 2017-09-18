using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iadapt.wireframe.Startup))]
namespace iadapt.wireframe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
