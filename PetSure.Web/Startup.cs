using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetSure.Web.Startup))]
namespace PetSure.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
