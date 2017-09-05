using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroupAssignment.Startup))]
namespace GroupAssignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
