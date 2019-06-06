using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GestCoFact
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Mock();
        }
        

        protected void Mock()
        {
            ClientRepository lClientRepository = new ClientRepository();
            lClientRepository.GetClients();

            FactureRepository lFactureRepository = new FactureRepository();
            lFactureRepository.GetFactures();

            CommandeRepository lCommandeRepository = new CommandeRepository();
            lCommandeRepository.GetCommandes();
        }

    }
}
