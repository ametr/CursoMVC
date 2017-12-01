using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CursoPresencial.Startup))]
namespace CursoPresencial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
