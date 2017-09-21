using Swashbuckle.Application;
using System.Web;
using System.Web.Http;

namespace Swashbuckle.AutoRestExtensions.NetFramework.Example
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
