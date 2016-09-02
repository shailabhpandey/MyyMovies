using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyyMovies.Startup))]
namespace MyyMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
