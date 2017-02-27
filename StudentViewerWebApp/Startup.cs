using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentViewerWebApp.Startup))]
namespace StudentViewerWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
