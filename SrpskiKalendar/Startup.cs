using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SrpskiKalendar.Startup))]
namespace SrpskiKalendar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
