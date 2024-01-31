using System.Web.Http;

//Para acessar aplicação
//localhost:64195/api/produto
//localhost:64195/api/usuario

namespace Server
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}