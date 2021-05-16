using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollegeSystemMVCWithOAuth.Startup))]
namespace CollegeSystemMVCWithOAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
