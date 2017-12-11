using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IS_403_Project_1.Startup))]
namespace IS_403_Project_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
