using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TajMahel.Startup))]
namespace TajMahel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
