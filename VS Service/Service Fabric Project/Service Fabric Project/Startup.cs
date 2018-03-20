using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Service_Fabric_Project.Startup))]
namespace Service_Fabric_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
